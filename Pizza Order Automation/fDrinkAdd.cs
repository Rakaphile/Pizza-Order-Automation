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
    public partial class fDrinkAdd : Form
    {
        public fDrinkAdd()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=JARVIS;Initial Catalog=PizzaTryDB;Integrated Security=True;MultipleActiveResultSets=true");
        private void btnAddDrink_Click(object sender, EventArgs e)
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
                cmd.CommandText = "select dName from tDrinks where dName = @name and dBitState = 1";
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    name = (dr["dName"]).ToString();
                }
                con.Close();
                dr.Close();

                if (name == "")
                {
                    //CreateDrink
                    cmd.CommandText = "insert into tDrinks (dName, dCost, dDescription, dBitState, dProductType) " +
                        "values (@name, @cost, @desc, @bitState, @type)";
                    cmd.Parameters.AddWithValue("@cost", Convert.ToDouble(txtCost.Text));
                    cmd.Parameters.AddWithValue("@desc", txtName.Text + " - " + txtCost.Text + " TL");
                    cmd.Parameters.AddWithValue("@bitState", 1);
                    cmd.Parameters.AddWithValue("@type", "Drink");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    cmd.CommandText = "select MAX(DrinkID) AS ID from tDrinks";
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
                    cmd.Parameters.AddWithValue("@typeName", "Drink");
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@cost", Convert.ToDouble(txtCost.Text));
                    cmd.Parameters.AddWithValue("@bitState", 1);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    if (MessageBox.Show("Ürün eklendi!", "İçecek Ekle", MessageBoxButtons.OK) == DialogResult.OK) this.Close();
                }

                else MessageBox.Show("Eklemek istediğiniz isimde ürün bulunmakta!", "DİKKAT", MessageBoxButtons.OK);
            }
        }
    }
}
