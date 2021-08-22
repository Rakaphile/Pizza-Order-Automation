
namespace Pizza_Order_Automation
{
    partial class fEmployeeScreen
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
            this.bOrderCreate = new System.Windows.Forms.Button();
            this.bProductUpdate = new System.Windows.Forms.Button();
            this.bInformationUpdate = new System.Windows.Forms.Button();
            this.bPasswordChange = new System.Windows.Forms.Button();
            this.bEmployeeUpdate = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.cbxDelivered = new System.Windows.Forms.CheckBox();
            this.cbxPaid = new System.Windows.Forms.CheckBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.btnCurrent = new System.Windows.Forms.Button();
            this.lbxOrder = new System.Windows.Forms.ListBox();
            this.lbxOrderProducts = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxPreparing = new System.Windows.Forms.CheckBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearSearchText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // bOrderCreate
            // 
            this.bOrderCreate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bOrderCreate.Location = new System.Drawing.Point(1006, 164);
            this.bOrderCreate.Name = "bOrderCreate";
            this.bOrderCreate.Size = new System.Drawing.Size(244, 67);
            this.bOrderCreate.TabIndex = 2;
            this.bOrderCreate.Text = "SİPARİŞ OLUŞTUR";
            this.bOrderCreate.UseVisualStyleBackColor = true;
            this.bOrderCreate.Click += new System.EventHandler(this.bOrderCreate_Click);
            // 
            // bProductUpdate
            // 
            this.bProductUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bProductUpdate.Location = new System.Drawing.Point(1006, 263);
            this.bProductUpdate.Name = "bProductUpdate";
            this.bProductUpdate.Size = new System.Drawing.Size(119, 67);
            this.bProductUpdate.TabIndex = 3;
            this.bProductUpdate.Text = "ÜRÜN GÜNCELLE";
            this.bProductUpdate.UseVisualStyleBackColor = true;
            this.bProductUpdate.Click += new System.EventHandler(this.bProductUpdate_Click);
            // 
            // bInformationUpdate
            // 
            this.bInformationUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bInformationUpdate.Location = new System.Drawing.Point(1131, 263);
            this.bInformationUpdate.Name = "bInformationUpdate";
            this.bInformationUpdate.Size = new System.Drawing.Size(119, 67);
            this.bInformationUpdate.TabIndex = 4;
            this.bInformationUpdate.Text = "BİLGİLERİMİ GÜNCELLE";
            this.bInformationUpdate.UseVisualStyleBackColor = true;
            this.bInformationUpdate.Click += new System.EventHandler(this.bInformationUpdate_Click);
            // 
            // bPasswordChange
            // 
            this.bPasswordChange.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bPasswordChange.Location = new System.Drawing.Point(1006, 336);
            this.bPasswordChange.Name = "bPasswordChange";
            this.bPasswordChange.Size = new System.Drawing.Size(119, 67);
            this.bPasswordChange.TabIndex = 5;
            this.bPasswordChange.Text = "ŞİFRE DEĞİŞTİR";
            this.bPasswordChange.UseVisualStyleBackColor = true;
            this.bPasswordChange.Click += new System.EventHandler(this.bPasswordChange_Click);
            // 
            // bEmployeeUpdate
            // 
            this.bEmployeeUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEmployeeUpdate.Location = new System.Drawing.Point(1131, 336);
            this.bEmployeeUpdate.Name = "bEmployeeUpdate";
            this.bEmployeeUpdate.Size = new System.Drawing.Size(119, 67);
            this.bEmployeeUpdate.TabIndex = 6;
            this.bEmployeeUpdate.Text = "PERSONEL EKLE / SİL";
            this.bEmployeeUpdate.UseVisualStyleBackColor = true;
            this.bEmployeeUpdate.Click += new System.EventHandler(this.bEmployeeUpdate_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogOut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.Location = new System.Drawing.Point(1133, 7);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(119, 33);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "ÇIKIŞ YAP";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "SİPARİŞ KAYITLARI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "SİPARİŞ DETAYLARI:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 20);
            this.txtName.TabIndex = 2;
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSearch.Location = new System.Drawing.Point(753, 51);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(114, 27);
            this.bSearch.TabIndex = 5;
            this.bSearch.Text = "ARA";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1000, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "SİPARİŞ DURUMUNU GÜNCELLE";
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bCancel.Location = new System.Drawing.Point(1006, 603);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(242, 44);
            this.bCancel.TabIndex = 15;
            this.bCancel.Text = "SİPARİŞİ İPTAL ET";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSave.Location = new System.Drawing.Point(1006, 553);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(242, 44);
            this.bSave.TabIndex = 16;
            this.bSave.Text = "KAYDET";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // cbxDelivered
            // 
            this.cbxDelivered.AutoSize = true;
            this.cbxDelivered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxDelivered.Location = new System.Drawing.Point(1033, 516);
            this.cbxDelivered.Name = "cbxDelivered";
            this.cbxDelivered.Size = new System.Drawing.Size(91, 18);
            this.cbxDelivered.TabIndex = 18;
            this.cbxDelivered.Text = "Teslim Edildi";
            this.cbxDelivered.UseVisualStyleBackColor = true;
            this.cbxDelivered.Click += new System.EventHandler(this.cbxDelivered_Click);
            // 
            // cbxPaid
            // 
            this.cbxPaid.AutoSize = true;
            this.cbxPaid.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxPaid.Location = new System.Drawing.Point(1154, 516);
            this.cbxPaid.Name = "cbxPaid";
            this.cbxPaid.Size = new System.Drawing.Size(65, 18);
            this.cbxPaid.TabIndex = 19;
            this.cbxPaid.Text = "Ödendi";
            this.cbxPaid.UseVisualStyleBackColor = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.Location = new System.Drawing.Point(1142, 124);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(77, 18);
            this.lblUserName.TabIndex = 20;
            this.lblUserName.Text = "UserName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1038, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "OTURUM BİLGİLERİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1030, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // dgOrders
            // 
            this.dgOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrders.Location = new System.Drawing.Point(12, 115);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.Size = new System.Drawing.Size(978, 288);
            this.dgOrders.TabIndex = 23;
            this.dgOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrders_CellClick);
            // 
            // btnCurrent
            // 
            this.btnCurrent.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCurrent.Location = new System.Drawing.Point(753, 81);
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.Size = new System.Drawing.Size(233, 27);
            this.btnCurrent.TabIndex = 24;
            this.btnCurrent.Text = "GÜNCEL SİPARİŞLER";
            this.btnCurrent.UseVisualStyleBackColor = true;
            this.btnCurrent.Click += new System.EventHandler(this.btnCurrent_Click);
            // 
            // lbxOrder
            // 
            this.lbxOrder.FormattingEnabled = true;
            this.lbxOrder.HorizontalScrollbar = true;
            this.lbxOrder.Location = new System.Drawing.Point(12, 440);
            this.lbxOrder.Name = "lbxOrder";
            this.lbxOrder.Size = new System.Drawing.Size(318, 225);
            this.lbxOrder.TabIndex = 25;
            // 
            // lbxOrderProducts
            // 
            this.lbxOrderProducts.FormattingEnabled = true;
            this.lbxOrderProducts.HorizontalScrollbar = true;
            this.lbxOrderProducts.Location = new System.Drawing.Point(336, 440);
            this.lbxOrderProducts.Name = "lbxOrderProducts";
            this.lbxOrderProducts.Size = new System.Drawing.Size(654, 225);
            this.lbxOrderProducts.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(333, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "SİPARİŞ İÇERİĞİ:";
            // 
            // cbxPreparing
            // 
            this.cbxPreparing.AutoSize = true;
            this.cbxPreparing.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxPreparing.Location = new System.Drawing.Point(1033, 479);
            this.cbxPreparing.Name = "cbxPreparing";
            this.cbxPreparing.Size = new System.Drawing.Size(85, 18);
            this.cbxPreparing.TabIndex = 28;
            this.cbxPreparing.Text = "Hazırlanıyor";
            this.cbxPreparing.UseVisualStyleBackColor = true;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(354, 84);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(164, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 14);
            this.label8.TabIndex = 30;
            this.label8.Text = "Müşteri Adı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(259, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 14);
            this.label9.TabIndex = 31;
            this.label9.Text = "Müşteri Soyadı:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(89, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(658, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(524, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 14);
            this.label10.TabIndex = 34;
            this.label10.Text = "Telefon:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(583, 84);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(164, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 35;
            this.label1.Text = "Sipariş İçeriği:";
            // 
            // btnClearSearchText
            // 
            this.btnClearSearchText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClearSearchText.Location = new System.Drawing.Point(873, 51);
            this.btnClearSearchText.Name = "btnClearSearchText";
            this.btnClearSearchText.Size = new System.Drawing.Size(113, 27);
            this.btnClearSearchText.TabIndex = 36;
            this.btnClearSearchText.Text = "TEMİZLE";
            this.btnClearSearchText.UseVisualStyleBackColor = true;
            this.btnClearSearchText.Click += new System.EventHandler(this.btnClearSearchText_Click);
            // 
            // fEmployeeScreen
            // 
            this.AcceptButton = this.bSearch;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLogOut;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnClearSearchText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.cbxPreparing);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbxOrderProducts);
            this.Controls.Add(this.lbxOrder);
            this.Controls.Add(this.btnCurrent);
            this.Controls.Add(this.dgOrders);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.cbxPaid);
            this.Controls.Add(this.cbxDelivered);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.bEmployeeUpdate);
            this.Controls.Add(this.bPasswordChange);
            this.Controls.Add(this.bInformationUpdate);
            this.Controls.Add(this.bProductUpdate);
            this.Controls.Add(this.bOrderCreate);
            this.MaximizeBox = false;
            this.Name = "fEmployeeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Sipariş Otomasyonu - Personel Ekranı";
            this.Activated += new System.EventHandler(this.fEmployeeScreen_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fExit);
            this.Load += new System.EventHandler(this.fEmployeeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bOrderCreate;
        private System.Windows.Forms.Button bProductUpdate;
        private System.Windows.Forms.Button bInformationUpdate;
        private System.Windows.Forms.Button bPasswordChange;
        private System.Windows.Forms.Button bEmployeeUpdate;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.CheckBox cbxDelivered;
        private System.Windows.Forms.CheckBox cbxPaid;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.ListBox lbxOrder;
        private System.Windows.Forms.ListBox lbxOrderProducts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbxPreparing;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearSearchText;
    }
}