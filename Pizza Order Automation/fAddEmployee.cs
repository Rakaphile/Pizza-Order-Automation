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
    public partial class fAddEmployee : Form
    {
        public fAddEmployee()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=JARVIS;Initial Catalog=PizzaTryDB;Integrated Security=True");


        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" & txtSurname.Text != "" & txtPhone.Text != "" & txtUserName.Text != "" & txtPassword.Text != "" & txtPwA.Text != "")
            {
                if (txtPassword.Text == txtPwA.Text)
                {
                    if (txtPassword.Text.Length >= 8)
                    {
                        SqlDataReader dr;
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;

                        string username = txtUserName.Text;
                        string eusername = "";
                        cmd.CommandText = "select * from tEmployees where eUserName = @username";
                        cmd.Parameters.AddWithValue("@username", username);
                        con.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            eusername = (dr["eUserName"]).ToString();
                        }
                        con.Close();
                        dr.Close();
                        
                        if (eusername == "")
                        {
                            SqlCommand employeeAdd = new SqlCommand("Insert into tEmployees (eName, eSurname, ePhone, eUserName, ePassword) values (@name, @surname, @phone, @userName, @Password)", con);
                            employeeAdd.Parameters.AddWithValue("@name", txtName.Text);
                            employeeAdd.Parameters.AddWithValue("@surname", txtSurname.Text);
                            employeeAdd.Parameters.AddWithValue("@phone", txtPhone.Text);
                            employeeAdd.Parameters.AddWithValue("@userName", txtUserName.Text);
                            employeeAdd.Parameters.AddWithValue("@password", txtPassword.Text);
                            con.Open();
                            employeeAdd.ExecuteNonQuery();
                            con.Close();
                            if (MessageBox.Show("Personel eklendi!", "Personel Ekle", MessageBoxButtons.OK) == DialogResult.OK) this.Close();
                        }
                        else MessageBox.Show("Girdiğiniz kullanıcı adı kullanılmakta!");

                    }
                    else MessageBox.Show("Şifreniz en az 8 karakter uzunluğunda olmalıdır!");
                }
                else MessageBox.Show("Girdiğiniz şifreler eşleşmemektedir!");
            }
            else MessageBox.Show("Lütfen tüm alanları doldurunuz!", "DİKKAT", MessageBoxButtons.OK);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtPhone.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtPwA.Text = "";
        }
    }
}
