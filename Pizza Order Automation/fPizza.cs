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
    public partial class fPizza : Form
    {
        public fPizza()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=JARVIS;Initial Catalog=PizzaTryDB;Integrated Security=True;MultipleActiveResultSets=true");
        public double pizzaTotalCost = 0;
        double typeCost = 0;
        double sizeCost = 0;
        double crustCost = 0;
        double thickCost = 0;
        double topCost = 0;
        int pizzaCount = 1;
        int pID;
        double pizzaCost = 0;
        string typeDesc = "";
        string sizeDesc = "";
        string crustDesc = "";
        string thickDesc = "";
        string toppingDesc = "";
        string extratoppingDesc = "";
        string pDes = "";
        string name = "";
        private void fPizza_Load(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //PizzaTypeComboBox
            cmd.CommandText = "select * from tPizzaTypes where tPizzaTypes.ptBitState = 1";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmxPizza.Items.Add((dr["ptName"]).ToString() + " - " + (Convert.ToDouble((dr["ptCost"]).ToString())).ToString() + " TL");
            }
            con.Close();
            dr.Close();

            //PizzaSizeComboBox
            cmd.CommandText = "select * from tPizzaSizes where sBitState = 1";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmxSize.Items.Add((dr["sName"]).ToString() + " - " + (Convert.ToDouble((dr["sCost"]).ToString())).ToString() + " TL");
            }
            con.Close();
            dr.Close();

            //PizzaCrustComboBox
            cmd.CommandText = "select * from tPizzaCrusts where pcBitState = 1";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmxCrust.Items.Add((dr["pcName"]).ToString() + " - " + (Convert.ToDouble((dr["pcCost"]).ToString())).ToString() + " TL");
            }
            con.Close();
            dr.Close();

            //PizzaThicknessComboBox
            cmd.CommandText = "select * from tPizzaThicks where ptBitState = 1";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmxThickness.Items.Add((dr["ptName"]).ToString() + " - " + (Convert.ToDouble((dr["ptCost"]).ToString())).ToString() + " TL");
            }
            con.Close();
            dr.Close();

        }

        private void cmxPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            //PizzaTypeToppingsComboBox
            lbTypeToppings.Items.Clear();
            string description = cmxPizza.SelectedItem.ToString();
            cmd.CommandText = "select * from tPTypeToppings inner join tPizzaTypes on tPTypeToppings.PizzaTypeID = tPizzaTypes.PizzaTypeID " +
                "where tPizzaTypes.ptDescription = @desc";
            cmd.Parameters.AddWithValue("@desc", description);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbTypeToppings.Items.Add(dr["typeToppings"]).ToString();
            }
            con.Close();
            dr.Close();

            //CheckAll
            for (int i = 0; i < lbTypeToppings.Items.Count; i++)
            {
                lbTypeToppings.SetItemChecked(i, true);
            }

            //TypeCost
            cmd.CommandText = "select * from tPizzaTypes where ptDescription=@desc";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                typeCost = Convert.ToDouble(dr["ptCost"]);
                pID = Convert.ToInt32((dr["PizzaTypeID"]).ToString());
                typeDesc = dr["ptName"].ToString();
            }
            con.Close();
            dr.Close();
            pizzaCost = typeCost + sizeCost + crustCost + thickCost + topCost;
            pizzaTotalCost = pizzaCost * pizzaCount;
            lblPizzaCost.Text = pizzaTotalCost.ToString() + " TL";
        }

        private void cmxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //PizzaToppings
            lbToppings.Items.Clear();
            string desc = cmxSize.SelectedItem.ToString();
            cmd.CommandText = "select * from tPizzaToppings inner join tPizzaSizes on tPizzaToppings.tSize = tPizzaSizes.PizzaSizeID " +
                "where tPizzaSizes.sDescription= @desc";
            cmd.Parameters.AddWithValue("@desc", desc);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbToppings.Items.Add((dr["tDescription"]).ToString());
            }
            con.Close();
            dr.Close();

            //SizeCost
            cmd.CommandText = "select * from tPizzaSizes where sDescription=@desc";
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sizeCost = Convert.ToDouble(dr["sCost"]);
                //sizeDesc = dr["sName"].ToString() + " Boy";
            }
            con.Close();
            dr.Close();
            pizzaCost = typeCost + sizeCost + crustCost + thickCost + topCost;
            pizzaTotalCost = pizzaCost * pizzaCount;
            lblPizzaCost.Text = pizzaTotalCost.ToString() + " TL";
        }

        private void cmxCrust_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //CrustCost
            cmd.CommandText = "select * from tPizzaCrusts where pcDescription=@desc";
            cmd.Parameters.AddWithValue("@desc", cmxCrust.SelectedItem.ToString());
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                crustCost = Convert.ToDouble(dr["pcCost"]);
                crustDesc = dr["pcName"].ToString();
            }
            con.Close();
            dr.Close();
            pizzaCost = typeCost + sizeCost + crustCost + thickCost + topCost;
            pizzaTotalCost = pizzaCost * pizzaCount;
            lblPizzaCost.Text = pizzaTotalCost.ToString() + " TL";
        }

        private void cmxThickness_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //ThicksCost
            cmd.CommandText = "select * from tPizzaThicks where ptDescription=@desc";
            cmd.Parameters.AddWithValue("@desc", cmxThickness.SelectedItem.ToString());
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                thickCost = Convert.ToDouble(dr["ptCost"]);
                thickDesc = dr["ptName"].ToString();
            }
            con.Close();
            dr.Close();
            pizzaCost = typeCost + sizeCost + crustCost + thickCost + topCost;
            pizzaTotalCost = pizzaCost * pizzaCount;
            lblPizzaCost.Text = pizzaTotalCost.ToString() + " TL";
        }

        private void lbToppings_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void lbToppings_Click(object sender, EventArgs e)
        {
            checkExtraToppings();
        }

        async Task checkExtraToppings()
        {
           

            string[] checkedToppings = new string[lbToppings.CheckedItems.Count];

            //CheckedItemsAdd
            await Task.Delay(1);
            lboxCheckedTops.Items.Clear();
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            double tCost = 0;
            topCost = 0;
            foreach (object x in lbToppings.CheckedItems)
            {
                lboxCheckedTops.Items.Add(x.ToString());
                cmd.CommandText = "select * from tPizzaToppings where tDescription=@desc";
                cmd.Parameters.AddWithValue("@desc", x.ToString());
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read()) 
                {
                    tCost = Convert.ToDouble((dr["tCost"]).ToString());
                }
                cmd.Parameters.Clear();
                con.Close();
                dr.Close();
                topCost += tCost;
            }
            

            pizzaCost = typeCost + sizeCost + crustCost + thickCost + topCost;
            pizzaTotalCost = pizzaCost * pizzaCount;
            lblPizzaCost.Text = pizzaTotalCost.ToString() + " TL";

            //CheckedItemsDesc
            extratoppingDesc = "Extra Pizza Malzemeleri: ";
            foreach (object x in lbToppings.CheckedItems)
            {
                extratoppingDesc += x.ToString() + ", ";
            }
            extratoppingDesc = extratoppingDesc.Substring(0, extratoppingDesc.Length - 1);
        }

        private void cmxCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            pizzaCount = Convert.ToInt32(cmxCount.Text);
            pizzaCost = typeCost + sizeCost + crustCost + thickCost + topCost;
            pizzaTotalCost = pizzaCost * pizzaCount;
            lblPizzaCost.Text = pizzaTotalCost.ToString() + " TL";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            if (cmxPizza.Text == "Seçiniz" | cmxSize.Text == "Seçiniz" | cmxCrust.Text == "Seçiniz" | cmxThickness.Text == "Seçiniz")
            {
                MessageBox.Show("Lütfen tüm seçimleri yapınız.", "DİKKAT", MessageBoxButtons.OK);
            }

            else
            {
                if (fOrderScreen.OrderID == 0)
                {
                    cmd.CommandText = "insert into tOrders (oStatus, oBitState) values (@status, @oBitState)";
                    cmd.Parameters.AddWithValue("@status", "Waiting");
                    cmd.Parameters.AddWithValue("@oBitState", 0);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    cmd.CommandText = "select MAX(OrderID) AS OrderID from tOrders";
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        fOrderScreen.OrderID = Convert.ToInt32(dr["OrderID"].ToString());
                    }
                    con.Close();
                    dr.Close();
                }

                //AddProducts

                pDes = pizzaTotalCost.ToString() + " TL: " + pizzaCount + " Adet - " + sizeDesc + " " + typeDesc + ", " + crustDesc + ", " + thickDesc + "," + toppingDesc + ", " + extratoppingDesc;
                name = sizeDesc + " " + typeDesc + ", " + crustDesc + ", " + thickDesc + "," + toppingDesc + ", " + extratoppingDesc;
                cmd.CommandText = "insert into tOrderProduct (pOrderID, typeProductID, productType, productCost, productCount, productDescription, pName) " +
                    "values (@orderID, @pID, @pType, @pCost, @pCount, @pDes, @name)";
                cmd.Parameters.AddWithValue("@orderID", fOrderScreen.OrderID);
                cmd.Parameters.AddWithValue("@pID", pID);
                cmd.Parameters.AddWithValue("@pType", "Pizza");
                cmd.Parameters.AddWithValue("@pCost", pizzaCost);
                cmd.Parameters.AddWithValue("@pCount", pizzaCount);
                cmd.Parameters.AddWithValue("@pDes", pDes);
                cmd.Parameters.AddWithValue("@name", name);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
            
        }

        private void lbTypeToppings_Click(object sender, EventArgs e)
        {
            checkToppings();
        }

        async Task checkToppings()
        {
            //CheckedItemsDesc
            await Task.Delay(1);
            toppingDesc = "Pizza Malzemeleri: ";
            foreach (object x in lbTypeToppings.CheckedItems)
            {
                toppingDesc += x.ToString() + ", ";
            }
            toppingDesc = toppingDesc.Substring(0, toppingDesc.Length - 1);
        }
    }
}

