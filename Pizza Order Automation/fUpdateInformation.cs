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
    public partial class fUpdateInformation : Form
    {
        public fUpdateInformation()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=JARVIS;Initial Catalog=PizzaTryDB;Integrated Security=True");

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" & txtSurname.Text != "" & txtPhone.Text != "" & txtUserName.Text != "" & txtPassword.Text != "")
            {
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string pw = "";
                try
                {
                    cmd.CommandText = "Select ePassword from tEmployees where eUserName=@username";
                    cmd.Parameters.AddWithValue("@username", fEmployeeLogin.empUserName);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        pw = dr["ePassword"].ToString();
                    }
                    con.Close();
                    dr.Close();

                    if (txtPassword.Text == pw)
                    {
                        string username = txtUserName.Text;

                        cmd.CommandText = "select * from tEmployees where eUserName = @username";
                        cmd.Parameters.AddWithValue("@username", username);
                        con.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            username = (dr["eUserName"]).ToString();
                        }
                        con.Close();
                        dr.Close();

                        if (username == "")
                        {
                            if (MessageBox.Show("Bilgilerinizi güncellemek istediğinize emin misiniz?", "DİKKAT", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                con.Open();
                                SqlCommand cmdUpdate = new SqlCommand("Update tEmployees set eName=@name, eSurname=@surname, ePhone=@phone, eUserName=@userName, ePassword=@password where eUserName=@usernameid", con);
                                cmdUpdate.Parameters.AddWithValue("@name", txtName.Text);
                                cmdUpdate.Parameters.AddWithValue("@surname", txtSurname.Text);
                                cmdUpdate.Parameters.AddWithValue("@phone", txtPhone.Text);
                                cmdUpdate.Parameters.AddWithValue("@userName", txtUserName.Text);
                                cmdUpdate.Parameters.AddWithValue("@password", txtPassword.Text);
                                cmdUpdate.Parameters.AddWithValue("@usernameid", fEmployeeLogin.empUserName);
                                cmdUpdate.ExecuteNonQuery();
                                fEmployeeLogin.empUserName = txtUserName.Text;
                                this.Close();
                                con.Close();
                                MessageBox.Show("Bilgileriniz başarıyla güncellendi!");
                            }
                        }
                        else MessageBox.Show("Girdiğiniz kullanıcı adı kullanılmakta!");
                        
                    }
                    else MessageBox.Show("Girdiğiniz şifre yanlış!", "DİKKAT", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Oturum girişi bulunamadı!");
                }  
            }
            else MessageBox.Show("Lütfen tüm alanları doldurunuz!", "DİKKAT", MessageBoxButtons.OK);
        }

        private void fUpdateInformation_Load(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@username", fEmployeeLogin.empUserName);

            //NameText
            cmd.CommandText = "select * from tEmployees where eUserName=@username";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = (dr["eName"]).ToString();
            }
            con.Close();
            dr.Close();

            //SurnameText
            cmd.CommandText = "select * from tEmployees where eUserName=@username";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtSurname.Text = (dr["eSurname"]).ToString();
            }
            con.Close();
            dr.Close();

            //PhoneText
            cmd.CommandText = "select * from tEmployees where eUserName=@username";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtPhone.Text = (dr["ePhone"]).ToString();
            }
            con.Close();
            dr.Close();

            //UsernameText
            cmd.CommandText = "select * from tEmployees where eUserName=@username";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtUserName.Text = (dr["eUserName"]).ToString();
            }
            con.Close();
            dr.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@username", fEmployeeLogin.empUserName);

            //NameText
            cmd.CommandText = "select * from tEmployees where eUserName=@username";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = (dr["eName"]).ToString();
            }
            con.Close();
            dr.Close();

            //SurnameText
            cmd.CommandText = "select * from tEmployees where eUserName=@username";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtSurname.Text = (dr["eSurname"]).ToString();
            }
            con.Close();
            dr.Close();

            //PhoneText
            cmd.CommandText = "select * from tEmployees where eUserName=@username";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtPhone.Text = (dr["ePhone"]).ToString();
            }
            con.Close();
            dr.Close();

            //UsernameText
            cmd.CommandText = "select * from tEmployees where eUserName=@username";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtUserName.Text = (dr["eUserName"]).ToString();
            }
            con.Close();
            dr.Close();
        }
    }
}
