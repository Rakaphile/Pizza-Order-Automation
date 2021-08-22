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
    public partial class fCrustAdd : Form
    {
        public fCrustAdd()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=JARVIS;Initial Catalog=PizzaTryDB;Integrated Security=True;MultipleActiveResultSets=true");
        private void btnAddCrust_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            int typeID = 0;
            string name = "";

            if(txtName.Text == "" | txtCost.Text == "") MessageBox.Show("Lütfen tüm alanları doldurunuz!", "DİKKAT", MessageBoxButtons.OK);
            else
            {
                //ProductCheck
                cmd.CommandText = "select pcName from tPizzaCrusts where pcName = @name and pcBitState = 1";
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    name = (dr["pcName"]).ToString();
                }
                con.Close();
                dr.Close();

                if (name == "")
                {
                    //CreateCrust
                    cmd.CommandText = "insert into tPizzaCrusts (pcName, pcCost, pcDescription, pcBitState, pcProductType) " +
                        "values (@name, @cost, @desc, @bitState, @type)";
                    cmd.Parameters.AddWithValue("@cost", Convert.ToDouble(txtCost.Text));
                    cmd.Parameters.AddWithValue("@desc", txtName.Text + " - " + txtCost.Text + " TL");
                    cmd.Parameters.AddWithValue("@bitState", 1);
                    cmd.Parameters.AddWithValue("@type", "Pizza Crust");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    cmd.CommandText = "select MAX(pizzaCrustID) AS ID from tPizzaCrusts";
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
                    cmd.Parameters.AddWithValue("@typeName", "Pizza Crust");
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@cost", Convert.ToDouble(txtCost.Text));
                    cmd.Parameters.AddWithValue("@bitState", 1);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    if (MessageBox.Show("Ürün eklendi!", "Kenar Ekle", MessageBoxButtons.OK) == DialogResult.OK) this.Close();
                }
                else MessageBox.Show("Eklemek istediğiniz isimde ürün bulunmakta!", "DİKKAT", MessageBoxButtons.OK);
            }
            
        }
    }
}
