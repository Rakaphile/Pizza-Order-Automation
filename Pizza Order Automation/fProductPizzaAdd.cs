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
    public partial class fProductPizzaAdd : Form
    {
        public fProductPizzaAdd()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=JARVIS;Initial Catalog=PizzaTryDB;Integrated Security=True;MultipleActiveResultSets=true");
        private void fProductPizzaAdd_Load(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //PizzaToppings
            cmd.CommandText = "select * from tPizzaToppings where tSize = 1";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmxToppings.Items.Add((dr["tName"]).ToString());
            }
            con.Close();
            dr.Close();
        }

        private void cmxToppings_Click(object sender, EventArgs e)
        {
            checkToppings();
        }
        async Task checkToppings()
        {
            //CheckedItemsAdd
            await Task.Delay(1);
            lbxToppings.Items.Clear();
            foreach (object x in cmxToppings.CheckedItems)
            {
                lbxToppings.Items.Add(x.ToString());
            }
        }

        private void btnAddPizza_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            int typeID = 0;
            string name = "";
            if (txtName.Text == "" | txtCost.Text == "") MessageBox.Show("Lütfen tüm alanları doldurunuz!", "DİKKAT", MessageBoxButtons.OK);
            else
            {
                //ProductCheck
                cmd.CommandText = "select * from tPizzaTypes where ptName = @name and ptBitState = 1";
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    name = (dr["ptName"]).ToString();
                }
                con.Close();
                dr.Close();

                if (name == "")
                {
                    //CreatePizza
                    cmd.CommandText = "insert into tPizzaTypes (ptName, ptCost, ptDescription, ptBitState, ptProductType) " +
                        "values (@name, @cost, @desc, @bitState, @type)";
                    cmd.Parameters.AddWithValue("@cost", Convert.ToDouble(txtCost.Text));
                    cmd.Parameters.AddWithValue("@desc", txtName.Text + " - " + txtCost.Text + " TL");
                    cmd.Parameters.AddWithValue("@bitState", 1);
                    cmd.Parameters.AddWithValue("@type", "Pizza Type");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    cmd.CommandText = "select MAX(PizzaTypeID) AS ID from tPizzaTypes";
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
                    cmd.Parameters.AddWithValue("@typeName", "Pizza Type");
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@cost", Convert.ToDouble(txtCost.Text));
                    cmd.Parameters.AddWithValue("@bitState", 1);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    string topping = "";

                    cmd.Parameters.Clear();

                    foreach (object x in lbxToppings.Items)
                    {
                        topping = x.ToString();
                        cmd.CommandText = "insert into tPTypeToppings (PizzaTypeID, typeToppings, tBitState, tProductType) " +
                            "values (@typeID, @topping, @bitState, @toppingName)";
                        cmd.Parameters.AddWithValue("@typeID", typeID);
                        cmd.Parameters.AddWithValue("@topping", topping);
                        cmd.Parameters.AddWithValue("@bitState", 1);
                        cmd.Parameters.AddWithValue("@toppingName", "Pizza Type Topping");
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmd.Parameters.Clear();
                    }

                    if (MessageBox.Show("Ürün eklendi!", "Boyut Ekle", MessageBoxButtons.OK) == DialogResult.OK) this.Close();
                }
                else MessageBox.Show("Eklemek istediğiniz isimde ürün bulunmakta!", "DİKKAT", MessageBoxButtons.OK);
            }
        }
    }
}
