using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order_Automation
{
    public partial class fStart : Form
    {
        public fStart()
        {
            InitializeComponent();
        }

        public static string OrderCreatedBy = "Müşteri";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fStart_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fOrderScreen fOrderScreen = new fOrderScreen();
            fOrderScreen.Show();
            Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fEmployeeLogin fEmployeeLogin = new fEmployeeLogin();
            fEmployeeLogin.Show();
        }
    }
}
