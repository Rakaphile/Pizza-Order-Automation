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
    public partial class fExtraAdd : Form
    {
        public fExtraAdd()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=JARVIS;Initial Catalog=PizzaTryDB;Integrated Security=True;MultipleActiveResultSets=true");
        private void btnAddExtra_Click(object sender, EventArgs e)
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
                cmd.CommandText = "select eName from tExtras where eName = @name and eBitState = 1";
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    name = (dr["eName"]).ToString();
                }
                con.Close();
                dr.Close();

                if (name == "")
                {
                    //CreateExtra
                    cmd.CommandText = "insert into tExtras (eName, eCost, eDescription, eBitState, eProductType) " +
                        "values (@name, @cost, @desc, @bitState, @type)";
                    cmd.Parameters.AddWithValue("@cost", Convert.ToDouble(txtCost.Text));
                    cmd.Parameters.AddWithValue("@desc", txtName.Text + " - " + txtCost.Text + " TL");
                    cmd.Parameters.AddWithValue("@bitState", 1);
                    cmd.Parameters.AddWithValue("@type", "Extra");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    cmd.CommandText = "select MAX(ExtraID) AS ID from tExtras";
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        typeID = Convert.ToInt32((dr["ID"]).ToString());
                    }
                    con.Close();
                    dr.Close();

                    //CreateProduct
                    cmd.Parameters.Clear();
                    cmd.CommandText = "insert into tProducts (pTypeID, pTypeName, pName, pCost, pBitState) " +
                       "values (@typeID, @typeName, @name, @cost, @bitState)";
                    cmd.Parameters.AddWithValue("@typeID", typeID);
                    cmd.Parameters.AddWithValue("@typeName", "Extra");
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@cost", Convert.ToDouble(txtCost.Text));
                    cmd.Parameters.AddWithValue("@bitState", 1);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    if (MessageBox.Show("Ürün eklendi!", "Ekstra Ekle", MessageBoxButtons.OK) == DialogResult.OK) this.Close();
                }

                else MessageBox.Show("Eklemek istediğiniz isimde ürün bulunmakta!", "DİKKAT", MessageBoxButtons.OK);
            }
        }
    }
}
