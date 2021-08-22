using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order_Automation
{
    public partial class fSauce : Form
    {
        public fSauce()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=JARVIS;Initial Catalog=PizzaTryDB;Integrated Security=True;MultipleActiveResultSets=true");
        public double sTotalCost = 0;
        double sCost = 0;
        int sCount = 1;
        int sID;
        string sauceDes = "";
        string name = "";
        private void fSauce_Load(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //SauceTypeComboBox
            cmd.CommandText = "select * from tSauces";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmxSauce.Items.Add((dr["sName"]).ToString() + " - " + (Convert.ToDouble((dr["sCost"]).ToString())).ToString() + " TL");
            }
            con.Close();
            dr.Close();
        }

        private void cmxSauce_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SauceCost
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from tSauces where sDescription=@desc";
            cmd.Parameters.AddWithValue("@desc", cmxSauce.SelectedItem.ToString());
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sCost = Convert.ToDouble(dr["sCost"]);
                sID = Convert.ToInt32(dr["SauceID"]);
                name = dr["sName"].ToString();
            }
            con.Close();
            dr.Close();
            sTotalCost = sCost * sCount;
            lblSauceCost.Text = sTotalCost.ToString() + " TL";
        }

        private void cmxCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            sCount = Convert.ToInt32(cmxCount.SelectedItem.ToString());
            sTotalCost = sCost * sCount;
            lblSauceCost.Text = sTotalCost.ToString() + " TL";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            if (cmxSauce.Text == "Seçiniz") MessageBox.Show("Lütfen seçim yapınız.", "DİKKAT", MessageBoxButtons.OK);

            else
            {
                if (fOrderScreen.OrderID == 0)
                {
                    cmd.CommandText = "insert into tOrders (oStatus, oBitState) values (@status, @oBitState)";
                    cmd.Parameters.AddWithValue("@status", "Waiting");
                    cmd.Parameters.AddWithValue("@oBitState", 0);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    cmd.CommandText = "select MAX(OrderID) AS OrderID from tOrders";
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        fOrderScreen.OrderID = Convert.ToInt32(dr["OrderID"].ToString());
                    }
                    con.Close();
                    dr.Close();
                }

                //AddProducts
                sauceDes = sTotalCost.ToString() + " TL: " + sCount + " Adet - " + name;
                cmd.CommandText = "insert into tOrderProduct (pOrderID, typeProductID, productType, productCost, productCount, productDescription, pName) " +
                    "values (@orderID, @pID, @pType, @pCost, @pCount, @pDes, @name)";
                cmd.Parameters.AddWithValue("@orderID", fOrderScreen.OrderID);
                cmd.Parameters.AddWithValue("@pID", sID);
                cmd.Parameters.AddWithValue("@pType", "Sauce");
                cmd.Parameters.AddWithValue("@pCost", sCost);
                cmd.Parameters.AddWithValue("@pCount", sCount);
                cmd.Parameters.AddWithValue("@pDes", sauceDes);
                cmd.Parameters.AddWithValue("@name", name);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
        }
    }
}
