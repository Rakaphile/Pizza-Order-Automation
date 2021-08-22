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
    public partial class fOrderScreen : Form
    {
        public fOrderScreen()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=JARVIS;Initial Catalog=PizzaTryDB;Integrated Security=True;MultipleActiveResultSets=true");
        public static int OrderID = 0;
        public static int CustomerID = 0;
        public static double totalOrderCost = 0;
        public static string OrderDescription = "";
        DateTime dt = DateTime.Now;
      
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().Where(f => f.GetType() == typeof(fStart)).FirstOrDefault();
            form.Show();
            this.Close();

        }

        private void bPizzaAdd_Click(object sender, EventArgs e)
        {
            fPizza fPizza = new fPizza();
            fPizza.ShowDialog();
        }

        private void bDrinkAdd_Click(object sender, EventArgs e)
        {
            fDrink fDrink = new fDrink();
            fDrink.ShowDialog();
        }

        private void bSauceAdd_Click(object sender, EventArgs e)
        {
            fSauce fSauce = new fSauce();
            fSauce.ShowDialog();
        }

        private void bExtraAdd_Click(object sender, EventArgs e)
        {
            fExtras fExtras = new fExtras();
            fExtras.ShowDialog();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            if(txtName.Text != "" & txtSurname.Text != "")
            {
                if (totalOrderCost != 0)
                {
                    if (MessageBox.Show("Siparişiniz oluşturulacaktır. Devam etmek istediğinize emin misiniz?", "Sepeti Onayla", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //Customer Create
                        cmd.CommandText = "Insert into tCustomers (OrderID, cName, cSurname, cPhone, cAddresses, cDescription, cBitState) " +
                        "values (@orderID ,@name, @surname, @phone, @address, @description, @cBitState)";
                        cmd.Parameters.AddWithValue("@orderID", OrderID);
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@cBitState", 1);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        //Get CustomerID
                        cmd.CommandText = "select * from tCustomers inner join tOrders on tOrders.OrderID = tCustomers.OrderID where tCustomers.OrderID = @orderID";
                        con.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            CustomerID = Convert.ToInt32((dr["CustomerID"]).ToString());
                        }
                        con.Close();
                        dr.Close();

                        //Get Order Description
                        OrderDescription = "";
                        foreach (object x in lbxOrders.Items)
                        {
                            OrderDescription += x.ToString() + "\n";
                        }
                        //Order Update
                        cmd.CommandText = "update tOrders set CustomerID = @customerID, oProductsDescription = @pDesc, oCost = @cost, " +
                            "oStatus = @status, oCreate = @create, oNote = @note, oDate = @date, oBitState = @oBitState where OrderID = @orderID";
                        cmd.Parameters.AddWithValue("@customerID", CustomerID);
                        cmd.Parameters.AddWithValue("@pDesc", OrderDescription);
                        cmd.Parameters.AddWithValue("@cost", totalOrderCost);
                        cmd.Parameters.AddWithValue("@status", "Bekleniyor");
                        cmd.Parameters.AddWithValue("@create", fStart.OrderCreatedBy);
                        cmd.Parameters.AddWithValue("@note", txtOrderNote.Text);
                        cmd.Parameters.AddWithValue("@date", dt.ToLongDateString() + " " + dt.ToLongTimeString());
                        cmd.Parameters.AddWithValue("@oBitState", 1);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        if (MessageBox.Show("Siparişiniz oluşturuldu! Sipariş ID'niz:" + OrderID + "\n" + dt.ToLongDateString(),
                            "Sipariş Oluşturuldu!", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            txtName.Text = "";
                            txtSurname.Text = "";
                            txtPhone.Text = "";
                            txtAddress.Text = "";
                            txtDescription.Text = "";
                            txtOrderNote.Text = "";
                            lblCount.Text = "0";
                            lblTotalCost.Text = "0 TL";
                            lbxOrders.Items.Clear();
                            OrderID = 0;
                            CustomerID = 0;
                        }
                    }
                }
                else MessageBox.Show("Siparişinizin oluşturulabilmesi için sepetinizde ürün bulunması gerekmektedir!", 
                    "DİKKAT", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Siparişinizin oluşturulabilmesi için ad ve soyad kısımlarını doldurmanız gerekmektedir!",
                     "DİKKAT", MessageBoxButtons.OK);
        }

        private void fOrderScreen_Activated(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            lbxOrders.Items.Clear();
            totalOrderCost = 0;
            cmd.CommandText = "select * from tOrderProduct where pOrderID = @orderID";
            cmd.Parameters.AddWithValue("@orderID", OrderID);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbxOrders.Items.Add(dr["productDescription"]);
                totalOrderCost += Convert.ToDouble((dr["productCost"]).ToString()) * Convert.ToInt32((dr["productCount"]).ToString());
            }
            con.Close();
            dr.Close();
            lblTotalCost.Text = totalOrderCost.ToString() + " TL";
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //DeleteSelected
            string selectedDesc = lbxOrders.SelectedItem.ToString();
            cmd.CommandText = "delete op from tOrderProduct op inner join tOrders o on o.OrderID = op.pOrderID " +
                "where op.productDescription = @desc and op.pOrderID = @orderID";
            cmd.Parameters.AddWithValue("@desc", selectedDesc);
            cmd.Parameters.AddWithValue("@orderID", OrderID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            //UpdateList
            lbxOrders.Items.Clear();
            totalOrderCost = 0;
            cmd.CommandText = "select * from tOrderProduct where pOrderID = @orderID";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbxOrders.Items.Add(dr["productDescription"]);
                totalOrderCost += Convert.ToDouble((dr["productCost"]).ToString()) * Convert.ToInt32((dr["productCount"]).ToString());
            }
            con.Close();
            dr.Close();
            lblTotalCost.Text = totalOrderCost.ToString() + " TL";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //DeleteAll
            cmd.CommandText = "delete op from tOrderProduct op inner join tOrders o on o.OrderID = op.pOrderID where op.pOrderID = @orderID";
            cmd.Parameters.AddWithValue("@orderID", OrderID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            lbxOrders.Items.Clear();
            lblTotalCost.Text = "0 TL";
            lblCount.Text = "0";

        }

        private void btnClearInf_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtDescription.Text = "";
            txtOrderNote.Text = "";
        }

        private void lbxOrders_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            if (lbxOrders.SelectedItem != null)
            {
                cmd.CommandText = "select * from tOrderProduct inner join tOrders on tOrders.OrderID = tOrderProduct.pOrderID " +
                    "where pOrderID = @orderID and productDescription = @desc";
                cmd.Parameters.AddWithValue("@orderID", OrderID);
                cmd.Parameters.AddWithValue("@desc", lbxOrders.SelectedItem.ToString());
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblCount.Text = (dr["productCount"]).ToString();
                }
                con.Close();
                dr.Close();
            }

        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblCount.Text) > 1 & lbxOrders.SelectedItem != null)
            {
                string type = "";
                string name = "";
                double cost = 0;
                int count = 0;

                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from tOrderProduct inner join tOrders on tOrders.OrderID = tOrderProduct.pOrderID " +
                    "where pOrderID = @orderID and productDescription = @desc";
                cmd.Parameters.AddWithValue("@orderID", OrderID);
                cmd.Parameters.AddWithValue("@desc", lbxOrders.SelectedItem.ToString());
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    type = (dr["productType"]).ToString();
                    name = (dr["pName"]).ToString();
                    count = Convert.ToInt32((dr["productCount"]).ToString());
                    cost = Convert.ToDouble((dr["productCost"]).ToString());
                }

                con.Close();
                dr.Close();

                count -= 1;
                cost *= count;
                string pDesc = cost.ToString() + " TL: " + count + " Adet - " + name;
                cmd.CommandText = "update tOrderProduct set productCount = @count, productDescription = @pdesc " +
                    "from tOrderProduct inner join tOrders on tOrders.OrderID = tOrderProduct.pOrderID where pOrderID = @orderID and productDescription = @desc";
                cmd.Parameters.AddWithValue("@count", count);
                cmd.Parameters.AddWithValue("@pdesc", pDesc);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                lbxOrders.Items.Clear();
                totalOrderCost = 0;

                cmd.CommandText = "select * from tOrderProduct where pOrderID = @orderID";
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lbxOrders.Items.Add(dr["productDescription"]);
                    totalOrderCost += Convert.ToDouble((dr["productCost"]).ToString()) * Convert.ToInt32((dr["productCount"]).ToString());
                }
                con.Close();
                dr.Close();
                lblTotalCost.Text = totalOrderCost.ToString() + " TL";

                lblCount.Text = count.ToString();

            }

        }

        private void btnInc_Click(object sender, EventArgs e)
        {
            if (lbxOrders.SelectedItem != null)
            {
                string type = "";
                string name = "";
                double cost = 0;
                int count = 0;

                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from tOrderProduct inner join tOrders on tOrders.OrderID = tOrderProduct.pOrderID " +
                    "where pOrderID = @orderID and productDescription = @desc";
                cmd.Parameters.AddWithValue("@orderID", OrderID);
                cmd.Parameters.AddWithValue("@desc", lbxOrders.SelectedItem.ToString());
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    type = (dr["productType"]).ToString();
                    name = (dr["pName"]).ToString();
                    count = Convert.ToInt32((dr["productCount"]).ToString());
                    cost = Convert.ToDouble((dr["productCost"]).ToString());
                }

                con.Close();
                dr.Close();

                count += 1;
                cost *= count;
                string pDesc = cost.ToString() + " TL: " + count + " Adet - " + name;
                cmd.CommandText = "update tOrderProduct set productCount = @count, productDescription = @pdesc " +
                    "from tOrderProduct inner join tOrders on tOrders.OrderID = tOrderProduct.pOrderID where pOrderID = @orderID and productDescription = @desc";
                cmd.Parameters.AddWithValue("@count", count);
                cmd.Parameters.AddWithValue("@pdesc", pDesc);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                lbxOrders.Items.Clear();
                totalOrderCost = 0;

                cmd.CommandText = "select * from tOrderProduct where pOrderID = @orderID";
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lbxOrders.Items.Add(dr["productDescription"]);
                    totalOrderCost += Convert.ToDouble((dr["productCost"]).ToString()) * Convert.ToInt32((dr["productCount"]).ToString());
                }
                con.Close();
                dr.Close();
                lblTotalCost.Text = totalOrderCost.ToString() + " TL";

                lblCount.Text = count.ToString();

            }
        }
    }
    
}

