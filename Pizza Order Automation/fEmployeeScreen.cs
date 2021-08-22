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
    public partial class fEmployeeScreen : Form
    {
        public fEmployeeScreen()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=JARVIS;Initial Catalog=PizzaTryDB;Integrated Security=True;MultipleActiveResultSets=true");
        int OrderID = 0;

        private void bOrderCreate_Click(object sender, EventArgs e)
        {
            fOrderScreen fOrderScreen = new fOrderScreen();
            fOrderScreen.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            fStart fStart = new fStart();
            fStart.Show();
            Close();
        }

        private void bPasswordChange_Click(object sender, EventArgs e)
        {
            fPasswordChange fPasswordChange = new fPasswordChange();
            fPasswordChange.ShowDialog();
        }

        private void fExit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bInformationUpdate_Click(object sender, EventArgs e)
        {
            fUpdateInformation fUpdateInformation = new fUpdateInformation();
            fUpdateInformation.ShowDialog();
        }

        private void bEmployeeUpdate_Click(object sender, EventArgs e)
        {
            fEmployeeManagement fEmployeeManagement = new fEmployeeManagement();
            fEmployeeManagement.ShowDialog();
        }

        private void fEmployeeScreen_Load(object sender, EventArgs e)
        {
            //Siparişi oluşturan personelin ad soyadını ilgili bölüme yerleştiren kod bloğu
            SqlDataReader dr;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from tEmployees where eUserName=@userName";
            cmd.Parameters.AddWithValue("@userName", fEmployeeLogin.empUserName);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fStart.OrderCreatedBy = (dr["eName"]).ToString() + " " + (dr["eSurname"]).ToString();
            }
            dr.Close();
            con.Close();
           
            lblUserName.Text = fEmployeeLogin.empUserName;
            BindGrid();
        }

        private void BindGrid()
        {
            //Sipariş kayıtlarını tablo olarak çekip görüntüleyen kod bloğu
            SqlDataReader dr;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select OrderID AS SiparişID, CustomerID AS MüşteriID, oProductsDescription AS Ürünler, oCost AS Ücret, oStatus AS Durum," +
                "oCreate AS Oluşturan, oDate AS Tarih from tOrders where oBitState = 1";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(ds, "Siparişler");
            dgOrders.DataSource = ds.Tables["Siparişler"];
            con.Close();
        }

        private void fEmployeeScreen_Activated(object sender, EventArgs e)
        {
            lblUserName.Text = fEmployeeLogin.empUserName;
            BindGrid();
        }

        private void bProductUpdate_Click(object sender, EventArgs e)
        {
            fUpdateProduct fUpdateProduct = new fUpdateProduct();
            fUpdateProduct.ShowDialog();
        }

        private void dgOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Seçili sipariş ID'sini alarak sipariş bilgilerini getiren kod bloğu
                OrderID = Convert.ToInt32(dgOrders.Rows[e.RowIndex].Cells["SiparişID"].FormattedValue.ToString());


                int cID = 0;
                string oDate = "";
                string order = "";
                string oNote = "";
                string name = "";
                string surname = "";
                string phone = "";
                string address = "";
                string cNote = "";
                string oStatus = "";

                SqlDataReader dr;
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from tOrders where oBitState = 1 and OrderID = @orderID";
                cmd.Parameters.AddWithValue("@orderID", OrderID);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cID = Convert.ToInt32((dr["CustomerID"]).ToString());
                    oDate = (dr["oDate"]).ToString();
                    order = (dr["oProductSDescription"]).ToString();
                    oNote = (dr["oNote"]).ToString();
                    oStatus = (dr["oStatus"].ToString());
                    
                }
                con.Close();
                dr.Close();

                //Seçili sipariş ID'sini alarak müşteri bilgilerini getiren kod bloğu
                cmd.CommandText = "Select * from tCustomers inner join tOrders on tOrders.CustomerID = tCustomers.CustomerID " +
                   "where oBitState = 1 and tCustomers.CustomerID = @customerID";
                cmd.Parameters.AddWithValue("@customerID", cID);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    name = (dr["cName"]).ToString(); 
                    surname = (dr["cSurname"]).ToString();
                    phone = (dr["cPhone"]).ToString();
                    address = (dr["cAddresses"]).ToString();
                    cNote = (dr["cDescription"]).ToString();
                }
                con.Close();
                dr.Close();

                //Seçili sipariş için siparişin içeriğini getiren kod bloğu
                lbxOrderProducts.Items.Clear();
                cmd.CommandText = "Select * from tOrderProduct where pOrderID = @orderID";
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lbxOrderProducts.Items.Add((dr["productDescription"].ToString()));
                }
                con.Close();
                dr.Close();

                //Seçili sipariş için siparişin detaylarını getiren kod bloğu
                lbxOrder.Items.Clear();
                lbxOrder.Items.Add("Sipariş ID: " + OrderID);
                lbxOrder.Items.Add("Sipariş Durumu: " + oStatus);
                lbxOrder.Items.Add("Sipariş Tarihi: " + oDate);
                lbxOrder.Items.Add("");
                lbxOrder.Items.Add("Müşteri ID: " + cID);
                lbxOrder.Items.Add("Müşteri Adı Soyadı: " + name + " " + surname);
                lbxOrder.Items.Add("Telefon Numarası: " + phone);
                lbxOrder.Items.Add("");
                lbxOrder.Items.Add("Adres: " + address);
                lbxOrder.Items.Add("Müşteri Notu: " + cNote);
                lbxOrder.Items.Add("Sipariş Notu: " + oNote);

                //Seçili siparişin durum güncelleme kısmını düzenleyen kod bloğu
                switch (oStatus)
                {
                    case "Bekleniyor":
                        cbxDelivered.Checked = false;
                        cbxPaid.Checked = false;
                        cbxPreparing.Checked = false;
                        cbxPreparing.Text = "Hazırlanıyor";
                        break;
                    case "Sipariş Hazırlanıyor, Ödeme Bekleniyor":
                        cbxDelivered.Checked = false;
                        cbxPaid.Checked = false;
                        cbxPreparing.Checked = true;
                        cbxPreparing.Text = "Hazırlanıyor";
                        break;
                    case "Sipariş Hazırlanıyor, Ödeme Alındı":
                        cbxDelivered.Checked = false;
                        cbxPaid.Checked = true;
                        cbxPreparing.Checked = true;
                        cbxPreparing.Text = "Hazırlanıyor";
                        break;
                    case "Sipariş Teslim Edildi, Ödeme Bekleniyor":
                        cbxDelivered.Checked = true;
                        cbxPaid.Checked = false;
                        cbxPreparing.Checked = true;
                        cbxPreparing.Text = "Hazırlandı";
                        break;
                    case "Sipariş Tamamlandı":
                        cbxDelivered.Checked = true;
                        cbxPaid.Checked = true;
                        cbxPreparing.Checked = true;
                        cbxPreparing.Text = "Hazırlandı";
                        break;
                }
            }
            catch (Exception)
            {

            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili siparişi iptal etmek istediğinize emin misiniz?", "Seçili Siparişi İptal Et", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update tOrders set oBitState = 0 where OrderID = @orderID", con);
                cmd.Parameters.AddWithValue("@orderID", OrderID);
                cmd.ExecuteNonQuery();
                con.Close();
                BindGrid();
                lbxOrder.Items.Clear();
                lbxOrderProducts.Items.Clear();
                cbxDelivered.Checked = false;
                cbxPaid.Checked = false;
            }
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            //Seçili sipariş durumunu güncellediğimizde çalışacak kod bloğu
            bool prepared = cbxPreparing.Checked;
            bool delivered = cbxDelivered.Checked;
            bool paid = cbxPaid.Checked;

            SqlDataReader dr;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@orderID", OrderID);
            cmd.CommandText = "Update tOrders set oStatus = @Status where OrderID = @orderID";
            con.Open();

            if (!prepared & !paid & !delivered)
            {
                cmd.Parameters.AddWithValue("@Status", "Bekleniyor");
                cbxPreparing.Text = "Hazırlanıyor";
            }
            else if (!delivered & !paid & prepared)
            {
                cmd.Parameters.AddWithValue("@Status", "Sipariş Hazırlanıyor, Ödeme Bekleniyor");
                cbxPreparing.Text = "Hazırlanıyor";
            }
            else if (!delivered & paid & prepared) 
            {
                cmd.Parameters.AddWithValue("@Status", "Sipariş Hazırlanıyor, Ödeme Alındı");
                cbxPreparing.Text = "Hazırlanıyor";
            } 
            else if (delivered & !paid & prepared)
            {
                cmd.Parameters.AddWithValue("@Status", "Sipariş Teslim Edildi, Ödeme Bekleniyor");
                cbxPreparing.Text = "Hazırlandı";
            }
            else if (delivered & paid & prepared)
            {
                cmd.Parameters.AddWithValue("@Status", "Sipariş Tamamlandı");
                cbxPreparing.Text = "Hazırlandı";
            }
            
            cmd.ExecuteNonQuery();
            con.Close();
            BindGrid();
            lbxOrder.Items.Clear();
            lbxOrderProducts.Items.Clear();
            cbxDelivered.Checked = false;
            cbxPaid.Checked = false;
        }

        private void cbxDelivered_Click(object sender, EventArgs e)
        {
            if (cbxDelivered.Checked) cbxPreparing.Checked = true; 
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            //Sipariş arama fonksiyonunu yerine getiren kod bloğu
            string customerName = txtName.Text;

            SqlDataReader dr;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = con;
          
            if (txtSearch.Text == "" & txtName.Text == "" & txtSurname.Text == "" & txtPhone.Text == "") MessageBox.Show("Lütfen arama yapmak için değer giriniz!", "Dikkat", MessageBoxButtons.OK);
            else
            {
                cmd.CommandText = "Select tOrders.OrderID AS SiparişID, tOrders.CustomerID AS MüşteriID, oProductsDescription AS Ürünler, oCost AS Ücret, oStatus AS Durum, " +
                    "oCreate AS Oluşturan, oDate AS Tarih from tOrders inner join tCustomers on tCustomers.OrderID = tOrders.OrderID where tOrders.oBitState = 1 " +
                    "and tOrders.oProductsDescription like '%' + @substring + '%' and tCustomers.cName like '%' + @name + '%' and tCustomers.cSurname like '%' + @surname + '%' and " +
                    "tCustomers.cPhone like '%' + @phone + '%'";
                cmd.Parameters.AddWithValue("@orderID", OrderID);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@substring", txtSearch.Text);
                con.Open();
                da.Fill(ds, "Siparişler");
                dgOrders.DataSource = ds.Tables["Siparişler"];
                con.Close();
            }
        }
        
        private void btnClearSearchText_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtPhone.Text = "";
        }
    }
}
