
namespace Pizza_Order_Automation
{
    partial class fDrink
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
            this.lblDrinkCost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmxCount = new System.Windows.Forms.ComboBox();
            this.cmxDrink = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDrinkCost
            // 
            this.lblDrinkCost.AutoSize = true;
            this.lblDrinkCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDrinkCost.Location = new System.Drawing.Point(167, 158);
            this.lblDrinkCost.Name = "lblDrinkCost";
            this.lblDrinkCost.Size = new System.Drawing.Size(34, 16);
            this.lblDrinkCost.TabIndex = 27;
            this.lblDrinkCost.Text = "0 TL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(103, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "TUTAR:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(85, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 42);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "SEPETE EKLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(21, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "İÇECEKLER";
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
            this.cmxCount.Location = new System.Drawing.Point(95, 113);
            this.cmxCount.Name = "cmxCount";
            this.cmxCount.Size = new System.Drawing.Size(55, 21);
            this.cmxCount.TabIndex = 21;
            this.cmxCount.Text = "1";
            this.cmxCount.SelectedIndexChanged += new System.EventHandler(this.cmxCount_SelectedIndexChanged);
            // 
            // cmxDrink
            // 
            this.cmxDrink.FormattingEnabled = true;
            this.cmxDrink.Location = new System.Drawing.Point(95, 64);
            this.cmxDrink.Name = "cmxDrink";
            this.cmxDrink.Size = new System.Drawing.Size(219, 21);
            this.cmxDrink.TabIndex = 20;
            this.cmxDrink.Text = "Seçiniz";
            this.cmxDrink.SelectedIndexChanged += new System.EventHandler(this.CmxPizza_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Adet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "İçecek Seçimi:";
            // 
            // fDrink
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 263);
            this.Controls.Add(this.lblDrinkCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmxCount);
            this.Controls.Add(this.cmxDrink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fDrink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İçecek Seçimi";
            this.Load += new System.EventHandler(this.fDrink_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDrinkCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmxCount;
        private System.Windows.Forms.ComboBox cmxDrink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}