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
    public partial class fProductToppingAdd : Form
    {
        public fProductToppingAdd()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=JARVIS;Initial Catalog=PizzaTryDB;Integrated Security=True;MultipleActiveResultSets=true");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            int typeID = 0;
            string name = "";

            if (txtName.Text == "" | txtSmall.Text == "" | txtMedium.Text == "" | txtLarge.Text == "") MessageBox.Show("Lütfen tüm alanları doldurunuz!", "DİKKAT", MessageBoxButtons.OK);
            else
            {
                //ProductCheck
                cmd.CommandText = "select tName from tPizzaToppings where tName = @name and tBitState = 1";
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    name = (dr["tName"]).ToString();
                }
                con.Close();
                dr.Close();

                if (name == "")
                {
                    //ToppingSmall
                    cmd.CommandText = "insert into tPizzaToppings (tSize, tName, tCost, tDescription, tBitState, tProductType) " +
                        "values (@size, @name, @cost, @desc, @bitState, @type)";
                    cmd.Parameters.AddWithValue("@size", 1);
                    cmd.Parameters.AddWithValue("@cost", Convert.ToDouble(txtSmall.Text));
                    cmd.Parameters.AddWithValue("@desc", txtName.Text + " - " + txtSmall.Text + " TL");
                    cmd.Parameters.AddWithValue("@bitState", 1);
                    cmd.Parameters.AddWithValue("@type", "Pizza Topping");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    cmd.CommandText = "select MAX(PizzaToppingID) AS ID from tPizzaToppings";
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        typeID = Convert.ToInt32((dr["ID"]).ToString());
                    }
                    con.Close();
                    dr.Close();

                    cmd.Parameters.Clear();
                    cmd.CommandText = "insert into tProducts (pTypeID, pTypeName, pName, pCost, pBitState) " +
                       "values (@typeID, @typeName, @name, @cost, @bitState)";
                    cmd.Parameters.AddWithValue("@typeID", typeID);
                    cmd.Parameters.AddWithValue("@typeName", "Pizza Topping");
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@cost", Convert.ToDouble(txtSmall.Text));
                    cmd.Parameters.AddWithValue("@bitState", 1);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    //ToppingMedium
                    cmd.Parameters.Clear();
                    cmd.CommandText = "insert into tPizzaToppings (tSize, tName, tCost, tDescription, tBitState, tProductType) " +
                        "values (@size, @name, @cost, @desc, @bitState, @type)";
                    cmd.Parameters.AddWithValue("@size", 2);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@cost", Convert.ToDouble(txtMedium.Text));
                    cmd.Parameters.AddWithValue("@desc", txtName.Text + " - " + txtMedium.Text + " TL");
                    cmd.Parameters.AddWithValue("@bitState", 1);
                    cmd.Parameters.AddWithValue("@type", "Pizza Topping");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    cmd.CommandText = "select MAX(PizzaToppingID) AS ID from tPizzaToppings";
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        typeID = Convert.ToInt32((dr["ID"]).ToString());
                    }
                    con.Close();
                    dr.Close();

                    cmd.Parameters.Clear();
                    cmd.CommandText = "insert into tProducts (pTypeID, pTypeName, pName, pCost, pBitState) " +
                       "values (@typeID, @typeName, @name, @cost, @bitState)";
                    cmd.Parameters.AddWithValue("@typeID", typeID);
                    cmd.Parameters.AddWithValue("@typeName", "Pizza Topping");
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@cost", Convert.ToDouble(txtMedium.Text));
                    cmd.Parameters.AddWithValue("@bitState", 1);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    //ToppingLarge
                    cmd.Parameters.Clear();
                    cmd.CommandText = "insert into tPizzaToppings (tSize, tName, tCost, tDescription, tBitState, tProductType) " +
                        "values (@size, @name, @cost, @desc, @bitState, @type)";
                    cmd.Parameters.AddWithValue("@size", 3);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@cost", Convert.ToDouble(txtLarge.Text));
                    cmd.Parameters.AddWithValue("@desc", txtName.Text + " - " + txtLarge.Text + " TL");
                    cmd.Parameters.AddWithValue("@bitState", 1);
                    cmd.Parameters.AddWithValue("@type", "Pizza Topping");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    cmd.CommandText = "select MAX(PizzaToppingID) AS ID from tPizzaToppings";
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        typeID = Convert.ToInt32((dr["ID"]).ToString());
                    }
                    con.Close();
                    dr.Close();

                    cmd.Parameters.Clear();
                    cmd.CommandText = "insert into tProducts (pTypeID, pTypeName, pName, pCost, pBitState) " +
                       "values (@typeID, @typeName, @name, @cost, @bitState)";
                    cmd.Parameters.AddWithValue("@typeID", typeID);
                    cmd.Parameters.AddWithValue("@typeName", "Pizza Topping");
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@cost", Convert.ToDouble(txtLarge.Text));
                    cmd.Parameters.AddWithValue("@bitState", 1);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    if (MessageBox.Show("Ürün eklendi!", "Malzeme Ekle", MessageBoxButtons.OK) == DialogResult.OK) this.Close();
                }

                else MessageBox.Show("Eklemek istediğiniz isimde ürün bulunmakta!", "DİKKAT", MessageBoxButtons.OK);
            }
        }
    }
}
