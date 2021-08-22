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
    public partial class fPasswordChange : Form
    {
        public fPasswordChange()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=JARVIS;Initial Catalog=PizzaTryDB;Integrated Security=True");
        private void btnChangePw_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            if (txtOldPw.Text == "" | txtNewPw.Text == "" | txtNewPwA.Text == "") MessageBox.Show("Lütfen tüm alanları doldurunuz!", "DİKKAT", MessageBoxButtons.OK);
            else
            {
                if (txtNewPw.Text == txtNewPwA.Text)
                {
                    if (txtNewPw.Text.Length >= 8)
                    {
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

                            if (txtOldPw.Text == pw)
                            {
                                if (MessageBox.Show("Şifrenizi güncellemek istediğinize emin misiniz?", "DİKKAT", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    con.Open();
                                    SqlCommand cmdUpdatePw = new SqlCommand("update tEmployees set ePassword=@password where eUserName=@username", con);
                                    cmdUpdatePw.Parameters.AddWithValue("@password", txtNewPw.Text);
                                    cmdUpdatePw.Parameters.AddWithValue("@username", fEmployeeLogin.empUserName);
                                    cmdUpdatePw.ExecuteNonQuery();

                                    MessageBox.Show("Şifreniz başarıyla değiştirildi!");

                                    this.Close();
                                    con.Close();
                                }
                            }
                            else MessageBox.Show("Eski şifreniz yanlış!");
                        }
                        catch
                        {
                            MessageBox.Show("Oturum girişi bulunamadı!");
                        }
                    }
                    else MessageBox.Show("Şifreniz en az 8 karakter uzunluğunda olmalıdır!");
                }
                else MessageBox.Show("Girilen şifreler birbirleriyle uyuşmuyor!");
            }
         
        }

    }
}
