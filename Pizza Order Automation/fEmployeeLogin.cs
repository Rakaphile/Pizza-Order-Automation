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
    public partial class fEmployeeLogin : Form
    {
        public fEmployeeLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public static string empUserName;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=JARVIS;Initial Catalog=PizzaTryDB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" | txtPassword.Text == "") MessageBox.Show("Lütfen tüm alanları doldurunuz!", "DİKKAT", MessageBoxButtons.OK);
            else
            {
                try
                {
                    con.Open();
                    SqlDataReader dr;
                    SqlParameter prmUser = new SqlParameter("userName", txtUserName.Text.Trim());
                    SqlParameter prmPassword = new SqlParameter("password", txtPassword.Text.Trim());
                    SqlCommand userNP = new SqlCommand("Select * from tEmployees where eUserName=@userName AND ePassword=@password", con);
                    userNP.Parameters.Add(prmUser);
                    userNP.Parameters.Add(prmPassword);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(userNP);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        empUserName = txtUserName.Text;
                        fEmployeeScreen fEmployeeScreen = new fEmployeeScreen();
                        fEmployeeScreen.Show();
                        this.Close();
                        Form form = Application.OpenForms.Cast<Form>().Where(f => f.GetType() == typeof(fStart)).FirstOrDefault();
                        form.Hide();
                    }
                    else MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                    con.Close();
                }

                catch (Exception)
                {
                    
                }
            } 
        }

        private void fEmployeeLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
