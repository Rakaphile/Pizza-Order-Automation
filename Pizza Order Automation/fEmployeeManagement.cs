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
    public partial class fEmployeeManagement : Form
    {
        public fEmployeeManagement()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=JARVIS;Initial Catalog=PizzaTryDB;Integrated Security=True");
        int selectedEmpID;
        private void fEmployeeManagement_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fAddEmployee fAddEmployee = new fAddEmployee();
            fAddEmployee.Show();
        }


        public void BindGrid(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand employeeDB = new SqlCommand("Select EmployeeID AS PersonelID, eName AS Ad, eSurname AS Soyad, ePhone AS Telefon, eUserName AS KullanıcıAdı from tEmployees", con);
            SqlDataAdapter da = new SqlDataAdapter(employeeDB);
            DataSet ds = new DataSet();
            da.Fill(ds, "PersonelListesi");
            dataGridView1.DataSource = ds.Tables["PersonelListesi"];
            con.Close();
        }
        public void BindGrid()
        {
            con.Open();
            SqlCommand employeeDB = new SqlCommand("Select EmployeeID AS PersonelID, eName AS Ad, eSurname AS Soyad, ePhone AS Telefon, eUserName AS KullanıcıAdı from tEmployees", con);
            SqlDataAdapter da = new SqlDataAdapter(employeeDB);
            DataSet ds = new DataSet();
            da.Fill(ds, "PersonelListesi");
            dataGridView1.DataSource = ds.Tables["PersonelListesi"];
            con.Close();
        }
        
        private void fCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedEmpID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PersonelID"].FormattedValue.ToString());
            }
            catch (Exception)
            {

            }
        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili personelin kaydını silmek istediğinize emin misiniz?", "Seçili Kaydı Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete tEmployees where EmployeeID = '" + selectedEmpID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                BindGrid();
            }
        }

        private void btnClearSearchText_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtUserName.Text = "";
            txtPhone.Text = "";
        }

        private void btnAllEmployees_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = con;
           

            if (txtName.Text == "" & txtSurname.Text == "" & txtUserName.Text == "" & txtPhone.Text == "") MessageBox.Show("Lütfen arama yapmak için değer giriniz!", "Dikkat", MessageBoxButtons.OK);
            else
            {
                cmd.CommandText = "Select EmployeeID AS PersonelID, eName AS Ad, eSurname AS Soyad, ePhone AS Telefon, eUserName AS KullanıcıAdı " +
                    "from tEmployees where eName like '%' + @subsname + '%' and eSurname like '%' + @subssurname + '%' and eUserName like '%' + " +
                    "@subsusername + '%' and ePhone like '%' + @subsphone + '%'";
                cmd.Parameters.AddWithValue("@subsname", txtName.Text);
                cmd.Parameters.AddWithValue("@subssurname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@subsusername", txtUserName.Text);
                cmd.Parameters.AddWithValue("@subsphone", txtPhone.Text);
                con.Open();
                da.Fill(ds, "PersonelListesi");
                dataGridView1.DataSource = ds.Tables["PersonelListesi"];
                con.Close();
            }
        }
    }
}
