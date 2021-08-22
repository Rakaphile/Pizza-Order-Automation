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
    public partial class fDrink : Form
    {
        public fDrink()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=JARVIS;Initial Catalog=PizzaTryDB;Integrated Security=True;MultipleActiveResultSets=true");
        public double dTotalCost = 0;
        double dCost = 0;
        int dCount = 1;
        int dID;
        string drinkDes = "";
        string name ="";
        private void fDrink_Load(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //DrinkTypeComboBox
            cmd.CommandText = "select * from tDrinks";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmxDrink.Items.Add((dr["dName"]).ToString() + " - " + (Convert.ToDouble((dr["dCost"]).ToString())).ToString() + " TL");
            }
            con.Close();
            dr.Close();
        }

        private void CmxPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DrinkCost
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from tDrinks where dDescription=@desc";
            cmd.Parameters.AddWithValue("@desc", cmxDrink.SelectedItem.ToString());
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dCost = Convert.ToDouble(dr["dCost"]);
                dID = Convert.ToInt32(dr["DrinkID"]);
                name = dr["dName"].ToString();
            }
            con.Close();
            dr.Close();
            dTotalCost = dCost * dCount;
            lblDrinkCost.Text = dTotalCost.ToString() + " TL";

        }

        private void cmxCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            dCount = Convert.ToInt32(cmxCount.SelectedItem.ToString());
            dTotalCost = dCost * dCount;
            lblDrinkCost.Text = dTotalCost.ToString() + " TL";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            if (cmxDrink.Text == "Seçiniz") MessageBox.Show("Lütfen seçim yapınız.", "DİKKAT", MessageBoxButtons.OK);

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
                drinkDes = dTotalCost.ToString() + " TL: " + dCount + " Adet - " + name;
                cmd.CommandText = "insert into tOrderProduct (pOrderID, typeProductID, productType, productCost, productCount, productDescription, pName) " +
                    "values (@orderID, @pID, @pType, @pCost, @pCount, @pDes, @name)";
                cmd.Parameters.AddWithValue("@orderID", fOrderScreen.OrderID);
                cmd.Parameters.AddWithValue("@pID", dID);
                cmd.Parameters.AddWithValue("@pType", "Drink");
                cmd.Parameters.AddWithValue("@pCost", dCost);
                cmd.Parameters.AddWithValue("@pCount", dCount);
                cmd.Parameters.AddWithValue("@pDes", drinkDes);
                cmd.Parameters.AddWithValue("@name", name);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
            
        }
    }
}
