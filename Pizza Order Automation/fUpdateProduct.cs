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
    public partial class fUpdateProduct : Form
    {
        public fUpdateProduct()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=JARVIS;Initial Catalog=PizzaTryDB;Integrated Security=True;MultipleActiveResultSets=true");
        int ProductID;
        int TypeID;
        string ProductType = "";
        string Name = "";
        double Cost = 0;
        private void fUpdateProduct_Load(object sender, EventArgs e)
        {
            SqlDataReader dr;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select ProductID AS ÜrünID, pTypeID AS TürID, pTypeName AS ÜrünTürü, pName AS ÜrünAdı, pCost AS ÜrünFiyatı " +
                "from tProducts where pBitState = 1";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(ds, "Ürünler");
            dgProducts.DataSource = ds.Tables["Ürünler"];
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddPizza_Click(object sender, EventArgs e)
        {
            fProductPizzaAdd fProductPizzaAdd = new fProductPizzaAdd();
            fProductPizzaAdd.ShowDialog();
        }

        private void btnAddPizzaTopping_Click(object sender, EventArgs e)
        {
            fProductToppingAdd fProductToppingAdd = new fProductToppingAdd();
            fProductToppingAdd.ShowDialog();
        }

        private void fUpdateProduct_Activated(object sender, EventArgs e)
        {
            SqlDataReader dr;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            cmd.CommandText = "Select ProductID AS ÜrünID, pTypeID AS TürID, pTypeName AS ÜrünTürü, pName AS ÜrünAdı, pCost AS ÜrünFiyatı " +
                "from tProducts where pBitState = 1";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(ds, "Ürünler");
            dgProducts.DataSource = ds.Tables["Ürünler"];
            con.Close();
        }

        public void BindGrid()
        {
            SqlDataReader dr;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            cmd.CommandText = "Select ProductID AS ÜrünID, pTypeID AS TürID, pName AS ÜrünAdı, pCost AS ÜrünFiyatı, pTypeName AS ÜrünTürü " +
                "from tProducts where pBitState = 1";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(ds, "Ürünler");
            dgProducts.DataSource = ds.Tables["Ürünler"];
            con.Close();
        }

        private void dgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ProductID = Convert.ToInt32(dgProducts.Rows[e.RowIndex].Cells["ÜrünID"].FormattedValue.ToString());
                TypeID = Convert.ToInt32(dgProducts.Rows[e.RowIndex].Cells["TürID"].FormattedValue.ToString());
                ProductType = dgProducts.Rows[e.RowIndex].Cells["ÜrünTürü"].FormattedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili ürünü silmek istediğinize emin misiniz?", "Seçili Kaydı Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Delete tProducts where pTypeID = @typeID AND ProductID = @productID";
                cmd.Parameters.AddWithValue("@typeID", TypeID);
                cmd.Parameters.AddWithValue("@productID", ProductID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                switch (ProductType)
                {
                    case "Pizza Type":
                        cmd.CommandText = "Update tPizzaTypes set ptBitState = 0 where PizzaTypeID = @typeID";
                        MessageBox.Show("222");
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Pizza Topping":
                        cmd.CommandText = "Delete tPizzaToppings where PizzaToppingID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Pizza Size":
                        cmd.CommandText = "Delete tPizzaSizes where PizzaSizeID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Pizza Crust":
                        cmd.CommandText = "Delete tPizzaCrusts where pizzaCrustID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Pizza Thick":
                        cmd.CommandText = "Delete tPizzaThicks where pizzaThickID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Drink":
                        cmd.CommandText = "Delete tDrinks where DrinkID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Extra":
                        cmd.CommandText = "Delete tExtras where ExtraID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Sauce":
                        cmd.CommandText = "Delete tSauces where SauceID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                }
                MessageBox.Show("İşlem tamamlandı!", "Ürün Kaldır", MessageBoxButtons.OK);
                BindGrid();
            }
        }

        private void btnUpdateName_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili ürün adını güncellemek istediğinize emin misiniz?", "Ürün Adını Güncelle", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                Name = txtName.Text;
                double pCost = 0;

                //GetCost
                cmd.CommandText = "select * from tProducts where pTypeID = @typeID AND ProductID = @productID";
                cmd.Parameters.AddWithValue("@typeID", TypeID);
                cmd.Parameters.AddWithValue("@productID", ProductID);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pCost = Convert.ToDouble((dr["pCost"]).ToString());
                }
                con.Close();
                dr.Close();

                //Description
                string desc = Name + " - " + pCost.ToString() + " TL";
                cmd.Parameters.AddWithValue("@desc", desc);

                //UpdateProduct
                cmd.CommandText = "Update tProducts set pName = @name where pTypeID = @typeID AND ProductID = @productID";
                cmd.Parameters.AddWithValue("@name", Name);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //UpdateProductType
                switch (ProductType)
                {
                    case "Pizza Type":
                        cmd.CommandText = "Update tPizzaTypes set ptName = @name, ptDescription = @desc where PizzaTypeID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Pizza Type Topping":
                        cmd.CommandText = "Update tPTypeToppings set typeToppings = @name where PizzaTypeToppingID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Pizza Topping":
                        cmd.CommandText = "Update tPizzaToppings set tName = @name, tDescription = @desc where PizzaToppingID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Pizza Size":
                        cmd.CommandText = "Update tPizzaSizes set sName = @name, sDescription = @desc where PizzaSizeID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Pizza Crust":
                        cmd.CommandText = "Update tPizzaCrusts set pcName = @name, pcDescription = @desct where pizzaCrustID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Pizza Thick":
                        cmd.CommandText = "Update tPizzaThicks set ptName = @name, ptDescription = @desc where pizzaThickID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Drink":
                        cmd.CommandText = "Update tDrinks set dName = @name, dDescription = @desc where DrinkID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Extra":
                        cmd.CommandText = "Update tExtras set eName = @name, eDescription = @desc where ExtraID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Sauce":
                        cmd.CommandText = "Update tSauces set sName = @name, sDescription = @desc where SauceID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                }
                txtName.Text = "";
                MessageBox.Show("İşlem tamamlandı!", "Ürün Adı Güncelle", MessageBoxButtons.OK);
                BindGrid();
            }
    }

        private void btnUpdateCost_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili ürün ücretini güncellemek istediğinize emin misiniz?", "Ürün Ücreti Güncelle", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                Cost = Convert.ToDouble(txtCost.Text);
                string pName = "";
                double pCost = 0;

                //GetName
                cmd.CommandText = "select * from tProducts where pTypeID = @typeID AND ProductID = @productID";
                cmd.Parameters.AddWithValue("@typeID", TypeID);
                cmd.Parameters.AddWithValue("@productID", ProductID);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pCost = Convert.ToDouble((dr["pCost"]).ToString());
                    pName = (dr["pName"]).ToString();
                }
                con.Close();
                dr.Close();

                //Description
                string desc = pName + " - " + Cost + " TL";

                //UpdateProduct
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.CommandText = "Update tProducts set pCost = @cost where pTypeID = @typeID AND ProductID = @productID";
                cmd.Parameters.AddWithValue("@cost", Cost);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                switch (ProductType)
                {
                    case "Pizza Type":
                        cmd.CommandText = "Update tPizzaTypes set ptCost = @cost, pDescription = @desc where PizzaTypeID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Pizza Type Topping":
                        //cmd.CommandText = "Update tPTypeToppings typeToppings = @name where PizzaTypeToppingID = @typeID";
                        //con.Open();
                        //cmd.ExecuteNonQuery();
                        //con.Close();
                        break;
                    case "Pizza Topping":
                        cmd.CommandText = "Update tPizzaToppings set tCost = @cost, tDescription = @desc where PizzaToppingID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Pizza Size":
                        cmd.CommandText = "Update tPizzaSizes set sCost = @cost, sDescription = @desc  where PizzaSizeID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Pizza Crust":
                        cmd.CommandText = "Update tPizzaCrusts set pcCost = @cost, pcDescription = @desc where pizzaCrustID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Pizza Thick":
                        cmd.CommandText = "Update tPizzaThicks set ptCost = @cost, ptDescription = @desc where pizzaThickID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Drink":
                        cmd.CommandText = "Update tDrinks set dCost = @cost, dDescription = @desc where DrinkID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Extra":
                        cmd.CommandText = "Update tExtras set eCost = @cost, eDescription = @desc where ExtraID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    case "Sauce":
                        cmd.CommandText = "Update tSauces set sCost = @cost, sDescription = @desc where SauceID = @typeID";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                }
                txtCost.Text = "";
                MessageBox.Show("İşlem tamamlandı!", "Ürün Ücreti Güncelle", MessageBoxButtons.OK);
                BindGrid();
            }
        }

        private void btnAddPizzaCrust_Click(object sender, EventArgs e)
        {
            fCrustAdd fCrustAdd = new fCrustAdd();
            fCrustAdd.ShowDialog();
        }

        private void btnAddPizzaThick_Click(object sender, EventArgs e)
        {
            fThickAdd fThickAdd = new fThickAdd();
            fThickAdd.ShowDialog();
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            fDrinkAdd fDrinkAdd = new fDrinkAdd();
            fDrinkAdd.ShowDialog();
        }

        private void btnAddSauce_Click(object sender, EventArgs e)
        {
            fSauceAdd fSauceAdd = new fSauceAdd();
            fSauceAdd.ShowDialog();
        }

        private void btnAddExtra_Click(object sender, EventArgs e)
        {
            fExtraAdd fExtraAdd = new fExtraAdd();
            fExtraAdd.ShowDialog();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = con;

            if (txtSName.Text == "" & txtSType.Text == "") MessageBox.Show("Lütfen arama yapmak için değer giriniz!", "Dikkat", MessageBoxButtons.OK);
            else
            {
                cmd.CommandText = "Select ProductID AS ÜrünID, pTypeID AS TürID, pTypeName AS ÜrünTürü, pName AS ÜrünAdı, pCost AS ÜrünFiyatı " +
                "from tProducts where pBitState = 1 and pName like '%' + @subsname + '%' and pTypeName like '%' + @substype + '%'";
                cmd.Parameters.AddWithValue("@subsname", txtSName.Text);
                cmd.Parameters.AddWithValue("@substype", txtSType.Text);
                con.Open();
                da.Fill(ds, "Ürünler");
                dgProducts.DataSource = ds.Tables["Ürünler"];
                con.Close();
            }
        }

        private void btnClearSearchText_Click(object sender, EventArgs e)
        {
            txtSName.Text = "";
            txtSType.Text = "";
        }

        private void btnAllProducts_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
