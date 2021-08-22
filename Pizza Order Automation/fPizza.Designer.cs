
namespace Pizza_Order_Automation
{
    partial class fPizza
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmxPizza = new System.Windows.Forms.ComboBox();
            this.cmxCrust = new System.Windows.Forms.ComboBox();
            this.cmxThickness = new System.Windows.Forms.ComboBox();
            this.cmxCount = new System.Windows.Forms.ComboBox();
            this.lbToppings = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmxSize = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTypeToppings = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPizzaCost = new System.Windows.Forms.Label();
            this.lboxCheckedTops = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Seçimi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kenar Seçimi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hamur Seçimi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ekstra Malzemeler";
            // 
            // cmxPizza
            // 
            this.cmxPizza.FormattingEnabled = true;
            this.cmxPizza.Location = new System.Drawing.Point(112, 52);
            this.cmxPizza.Name = "cmxPizza";
            this.cmxPizza.Size = new System.Drawing.Size(153, 21);
            this.cmxPizza.TabIndex = 5;
            this.cmxPizza.Text = "Seçiniz";
            this.cmxPizza.SelectedIndexChanged += new System.EventHandler(this.cmxPizza_SelectedIndexChanged);
            // 
            // cmxCrust
            // 
            this.cmxCrust.FormattingEnabled = true;
            this.cmxCrust.Location = new System.Drawing.Point(112, 132);
            this.cmxCrust.Name = "cmxCrust";
            this.cmxCrust.Size = new System.Drawing.Size(153, 21);
            this.cmxCrust.TabIndex = 6;
            this.cmxCrust.Text = "Seçiniz";
            this.cmxCrust.SelectedIndexChanged += new System.EventHandler(this.cmxCrust_SelectedIndexChanged);
            // 
            // cmxThickness
            // 
            this.cmxThickness.FormattingEnabled = true;
            this.cmxThickness.Location = new System.Drawing.Point(111, 172);
            this.cmxThickness.Name = "cmxThickness";
            this.cmxThickness.Size = new System.Drawing.Size(154, 21);
            this.cmxThickness.TabIndex = 7;
            this.cmxThickness.Text = "Seçiniz";
            this.cmxThickness.SelectedIndexChanged += new System.EventHandler(this.cmxThickness_SelectedIndexChanged);
            // 
            // cmxCount
            // 
            this.cmxCount.FormattingEnabled = true;
            this.cmxCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmxCount.Location = new System.Drawing.Point(111, 212);
            this.cmxCount.Name = "cmxCount";
            this.cmxCount.Size = new System.Drawing.Size(154, 21);
            this.cmxCount.TabIndex = 8;
            this.cmxCount.Text = "1";
            this.cmxCount.SelectedIndexChanged += new System.EventHandler(this.cmxCount_SelectedIndexChanged);
            // 
            // lbToppings
            // 
            this.lbToppings.CheckOnClick = true;
            this.lbToppings.FormattingEnabled = true;
            this.lbToppings.Location = new System.Drawing.Point(299, 77);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(351, 154);
            this.lbToppings.TabIndex = 9;
            this.lbToppings.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lbToppings_ItemCheck);
            this.lbToppings.Click += new System.EventHandler(this.lbToppings_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "PİZZALAR";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(364, 496);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(193, 50);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "SEPETE EKLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pizza Boyutu:";
            // 
            // cmxSize
            // 
            this.cmxSize.FormattingEnabled = true;
            this.cmxSize.Location = new System.Drawing.Point(111, 92);
            this.cmxSize.Name = "cmxSize";
            this.cmxSize.Size = new System.Drawing.Size(154, 21);
            this.cmxSize.TabIndex = 13;
            this.cmxSize.Text = "Seçiniz";
            this.cmxSize.SelectedIndexChanged += new System.EventHandler(this.cmxSize_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Seçili Pizza Malzemeleri:";
            // 
            // lbTypeToppings
            // 
            this.lbTypeToppings.CausesValidation = false;
            this.lbTypeToppings.CheckOnClick = true;
            this.lbTypeToppings.FormattingEnabled = true;
            this.lbTypeToppings.Location = new System.Drawing.Point(32, 272);
            this.lbTypeToppings.MultiColumn = true;
            this.lbTypeToppings.Name = "lbTypeToppings";
            this.lbTypeToppings.Size = new System.Drawing.Size(233, 274);
            this.lbTypeToppings.TabIndex = 15;
            this.lbTypeToppings.Click += new System.EventHandler(this.lbTypeToppings_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(361, 467);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "TUTAR:";
            // 
            // lblPizzaCost
            // 
            this.lblPizzaCost.AutoSize = true;
            this.lblPizzaCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPizzaCost.Location = new System.Drawing.Point(523, 467);
            this.lblPizzaCost.Name = "lblPizzaCost";
            this.lblPizzaCost.Size = new System.Drawing.Size(34, 16);
            this.lblPizzaCost.TabIndex = 17;
            this.lblPizzaCost.Text = "0 TL";
            // 
            // lboxCheckedTops
            // 
            this.lboxCheckedTops.FormattingEnabled = true;
            this.lboxCheckedTops.Location = new System.Drawing.Point(299, 272);
            this.lboxCheckedTops.MultiColumn = true;
            this.lboxCheckedTops.Name = "lboxCheckedTops";
            this.lboxCheckedTops.Size = new System.Drawing.Size(351, 173);
            this.lboxCheckedTops.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Seçili Ekstra Malzemeler:";
            // 
            // fPizza
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 565);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lboxCheckedTops);
            this.Controls.Add(this.lblPizzaCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbTypeToppings);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmxSize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbToppings);
            this.Controls.Add(this.cmxCount);
            this.Controls.Add(this.cmxThickness);
            this.Controls.Add(this.cmxCrust);
            this.Controls.Add(this.cmxPizza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fPizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Seçimi";
            this.Load += new System.EventHandler(this.fPizza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmxPizza;
        private System.Windows.Forms.ComboBox cmxCrust;
        private System.Windows.Forms.ComboBox cmxThickness;
        private System.Windows.Forms.ComboBox cmxCount;
        private System.Windows.Forms.CheckedListBox lbToppings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmxSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox lbTypeToppings;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPizzaCost;
        private System.Windows.Forms.ListBox lboxCheckedTops;
        private System.Windows.Forms.Label label10;
    }
}