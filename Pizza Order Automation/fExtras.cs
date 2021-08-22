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
    public partial class fExtras : Form
    {
        public fExtras()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=JARVIS;Initial Catalog=PizzaTryDB;Integrated Security=True;MultipleActiveResultSets=true");
        public double eTotalCost = 0;
        double eCost = 0;
        int eCount = 1;
        int eID;
        string extraDes = "";
        string name = "";
        private void fExtras_Load(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //ExtrasTypeComboBox
            cmd.CommandText = "select * from tExtras";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmxExtras.Items.Add((dr["eName"]).ToString() + " - " + (Convert.ToDouble((dr["eCost"]).ToString())).ToString() + " TL");
                
            }
            con.Close();
            dr.Close();
        }

        private void cmxExtras_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SauceCost
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from tExtras where eDescription=@desc";
            cmd.Parameters.AddWithValue("@desc", cmxExtras.SelectedItem.ToString());
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                eCost = Convert.ToDouble(dr["eCost"]);
                eID = Convert.ToInt32(dr["ExtraID"]);
                name = dr["eName"].ToString();
            }
            con.Close();
            dr.Close();
            eTotalCost = eCost * eCount;
            lblExtraCost.Text = eTotalCost.ToString() + " TL";

        }

        private void cmxCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            eCount = Convert.ToInt32(cmxCount.SelectedItem.ToString());
            eTotalCost = eCost * eCount;
            lblExtraCost.Text = eTotalCost.ToString() + " TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            if (cmxExtras.Text == "Seçiniz") MessageBox.Show("Lütfen seçim yapınız.", "DİKKAT", MessageBoxButtons.OK);

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
                extraDes = eTotalCost.ToString() + " TL: " + eCount + " Adet - " + name;
                cmd.CommandText = "insert into tOrderProduct (pOrderID, typeProductID, productType, productCost, productCount, productDescription, pName) " +
                    "values (@orderID, @pID, @pType, @pCost, @pCount, @pDes, @name)";
                cmd.Parameters.AddWithValue("@orderID", fOrderScreen.OrderID);
                cmd.Parameters.AddWithValue("@pID", eID);
                cmd.Parameters.AddWithValue("@pType", "Extra");
                cmd.Parameters.AddWithValue("@pCost", eCost);
                cmd.Parameters.AddWithValue("@pCount", eCount);
                cmd.Parameters.AddWithValue("@pDes", extraDes);
                cmd.Parameters.AddWithValue("@name", name);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
        }
    }
}
