
namespace Pizza_Order_Automation
{
    partial class fProductPizzaAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddPizza = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmxToppings = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxToppings = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddPizza
            // 
            this.btnAddPizza.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddPizza.Location = new System.Drawing.Point(214, 101);
            this.btnAddPizza.Name = "btnAddPizza";
            this.btnAddPizza.Size = new System.Drawing.Size(121, 40);
            this.btnAddPizza.TabIndex = 62;
            this.btnAddPizza.Text = "PİZZA EKLE";
            this.btnAddPizza.UseVisualStyleBackColor = true;
            this.btnAddPizza.Click += new System.EventHandler(this.btnAddPizza_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 61;
            this.label3.Text = "PİZZA";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(89, 112);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(76, 20);
            this.txtCost.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Pizza Ücreti:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Pizza Adı:";
            // 
            // cmxToppings
            // 
            this.cmxToppings.CheckOnClick = true;
            this.cmxToppings.FormattingEnabled = true;
            this.cmxToppings.Location = new System.Drawing.Point(356, 61);
            this.cmxToppings.Name = "cmxToppings";
            this.cmxToppings.Size = new System.Drawing.Size(334, 364);
            this.cmxToppings.TabIndex = 63;
            this.cmxToppings.Click += new System.EventHandler(this.cmxToppings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Pizza Malzemeleri:";
            // 
            // lbxToppings
            // 
            this.lbxToppings.FormattingEnabled = true;
            this.lbxToppings.Location = new System.Drawing.Point(20, 174);
            this.lbxToppings.Name = "lbxToppings";
            this.lbxToppings.Size = new System.Drawing.Size(315, 251);
            this.lbxToppings.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Seçili Malzemeler:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 67;
            this.label6.Text = "TL";
            // 
            // fProductPizzaAdd
            // 
            this.AcceptButton = this.btnAddPizza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 436);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxToppings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmxToppings);
            this.Controls.Add(this.btnAddPizza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fProductPizzaAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Ekle";
            this.Load += new System.EventHandler(this.fProductPizzaAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPizza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox cmxToppings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxToppings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}