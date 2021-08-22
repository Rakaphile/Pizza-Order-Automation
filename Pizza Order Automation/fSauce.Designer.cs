
namespace Pizza_Order_Automation
{
    partial class fSauce
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
            this.cmxSauce = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmxCount = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSauceCost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmxSauce
            // 
            this.cmxSauce.FormattingEnabled = true;
            this.cmxSauce.Location = new System.Drawing.Point(118, 85);
            this.cmxSauce.Name = "cmxSauce";
            this.cmxSauce.Size = new System.Drawing.Size(153, 21);
            this.cmxSauce.TabIndex = 22;
            this.cmxSauce.Text = "Seçiniz";
            this.cmxSauce.SelectedIndexChanged += new System.EventHandler(this.cmxSauce_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sos Seçimi:";
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
            this.cmxCount.Location = new System.Drawing.Point(118, 130);
            this.cmxCount.Name = "cmxCount";
            this.cmxCount.Size = new System.Drawing.Size(56, 21);
            this.cmxCount.TabIndex = 24;
            this.cmxCount.Text = "1";
            this.cmxCount.SelectedIndexChanged += new System.EventHandler(this.cmxCount_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Adet:";
            // 
            // lblSauceCost
            // 
            this.lblSauceCost.AutoSize = true;
            this.lblSauceCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSauceCost.Location = new System.Drawing.Point(159, 188);
            this.lblSauceCost.Name = "lblSauceCost";
            this.lblSauceCost.Size = new System.Drawing.Size(34, 16);
            this.lblSauceCost.TabIndex = 30;
            this.lblSauceCost.Text = "0 TL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(92, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "TUTAR:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(79, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 42);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "SEPETE EKLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(19, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "SOSLAR";
            // 
            // fSauce
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 294);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSauceCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmxCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmxSauce);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fSauce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sos Seçimi";
            this.Load += new System.EventHandler(this.fSauce_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmxSauce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmxCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSauceCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
    }
}