
namespace Pizza_Order_Automation
{
    partial class fUpdateProduct
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
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.btnAddPizza = new System.Windows.Forms.Button();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.btnAddSauce = new System.Windows.Forms.Button();
            this.btnAddExtra = new System.Windows.Forms.Button();
            this.btnAddPizzaCrust = new System.Windows.Forms.Button();
            this.btnAddPizzaThick = new System.Windows.Forms.Button();
            this.btnAddPizzaTopping = new System.Windows.Forms.Button();
            this.btnUpdateName = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnUpdateCost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClearSearchText = new System.Windows.Forms.Button();
            this.btnAllProducts = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(20, 437);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(154, 63);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "SEÇİLİ ÜRÜNÜ SİL";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // dgProducts
            // 
            this.dgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Location = new System.Drawing.Point(12, 91);
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.Size = new System.Drawing.Size(719, 329);
            this.dgProducts.TabIndex = 6;
            this.dgProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProducts_CellClick);
            this.dgProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAddPizza
            // 
            this.btnAddPizza.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddPizza.Location = new System.Drawing.Point(756, 91);
            this.btnAddPizza.Name = "btnAddPizza";
            this.btnAddPizza.Size = new System.Drawing.Size(106, 30);
            this.btnAddPizza.TabIndex = 7;
            this.btnAddPizza.Text = "PİZZA EKLE";
            this.btnAddPizza.UseVisualStyleBackColor = true;
            this.btnAddPizza.Click += new System.EventHandler(this.btnAddPizza_Click);
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddDrink.Location = new System.Drawing.Point(756, 318);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(106, 30);
            this.btnAddDrink.TabIndex = 8;
            this.btnAddDrink.Text = "İÇECEK EKLE";
            this.btnAddDrink.UseVisualStyleBackColor = true;
            this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click);
            // 
            // btnAddSauce
            // 
            this.btnAddSauce.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddSauce.Location = new System.Drawing.Point(756, 354);
            this.btnAddSauce.Name = "btnAddSauce";
            this.btnAddSauce.Size = new System.Drawing.Size(106, 30);
            this.btnAddSauce.TabIndex = 9;
            this.btnAddSauce.Text = "SOS EKLE";
            this.btnAddSauce.UseVisualStyleBackColor = true;
            this.btnAddSauce.Click += new System.EventHandler(this.btnAddSauce_Click);
            // 
            // btnAddExtra
            // 
            this.btnAddExtra.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddExtra.Location = new System.Drawing.Point(756, 390);
            this.btnAddExtra.Name = "btnAddExtra";
            this.btnAddExtra.Size = new System.Drawing.Size(106, 30);
            this.btnAddExtra.TabIndex = 10;
            this.btnAddExtra.Text = "EKSTRA EKLE";
            this.btnAddExtra.UseVisualStyleBackColor = true;
            this.btnAddExtra.Click += new System.EventHandler(this.btnAddExtra_Click);
            // 
            // btnAddPizzaCrust
            // 
            this.btnAddPizzaCrust.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddPizzaCrust.Location = new System.Drawing.Point(756, 141);
            this.btnAddPizzaCrust.Name = "btnAddPizzaCrust";
            this.btnAddPizzaCrust.Size = new System.Drawing.Size(106, 44);
            this.btnAddPizzaCrust.TabIndex = 11;
            this.btnAddPizzaCrust.Text = "Pizza Kenarı Ekle";
            this.btnAddPizzaCrust.UseVisualStyleBackColor = true;
            this.btnAddPizzaCrust.Click += new System.EventHandler(this.btnAddPizzaCrust_Click);
            // 
            // btnAddPizzaThick
            // 
            this.btnAddPizzaThick.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddPizzaThick.Location = new System.Drawing.Point(756, 191);
            this.btnAddPizzaThick.Name = "btnAddPizzaThick";
            this.btnAddPizzaThick.Size = new System.Drawing.Size(106, 44);
            this.btnAddPizzaThick.TabIndex = 14;
            this.btnAddPizzaThick.Text = "Pizza Hamuru Ekle";
            this.btnAddPizzaThick.UseVisualStyleBackColor = true;
            this.btnAddPizzaThick.Click += new System.EventHandler(this.btnAddPizzaThick_Click);
            // 
            // btnAddPizzaTopping
            // 
            this.btnAddPizzaTopping.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddPizzaTopping.Location = new System.Drawing.Point(756, 241);
            this.btnAddPizzaTopping.Name = "btnAddPizzaTopping";
            this.btnAddPizzaTopping.Size = new System.Drawing.Size(106, 44);
            this.btnAddPizzaTopping.TabIndex = 15;
            this.btnAddPizzaTopping.Text = "Malzeme Ekle";
            this.btnAddPizzaTopping.UseVisualStyleBackColor = true;
            this.btnAddPizzaTopping.Click += new System.EventHandler(this.btnAddPizzaTopping_Click);
            // 
            // btnUpdateName
            // 
            this.btnUpdateName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateName.Location = new System.Drawing.Point(194, 437);
            this.btnUpdateName.Name = "btnUpdateName";
            this.btnUpdateName.Size = new System.Drawing.Size(252, 30);
            this.btnUpdateName.TabIndex = 16;
            this.btnUpdateName.Text = "Seçili Ürün Adını Güncelle";
            this.btnUpdateName.UseVisualStyleBackColor = true;
            this.btnUpdateName.Click += new System.EventHandler(this.btnUpdateName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(285, 480);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(583, 480);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(122, 20);
            this.txtCost.TabIndex = 5;
            // 
            // btnUpdateCost
            // 
            this.btnUpdateCost.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCost.Location = new System.Drawing.Point(479, 437);
            this.btnUpdateCost.Name = "btnUpdateCost";
            this.btnUpdateCost.Size = new System.Drawing.Size(252, 30);
            this.btnUpdateCost.TabIndex = 20;
            this.btnUpdateCost.Text = "Seçili Ürün Ücretini Güncelle";
            this.btnUpdateCost.UseVisualStyleBackColor = true;
            this.btnUpdateCost.Click += new System.EventHandler(this.btnUpdateCost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(194, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Yeni Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(476, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Yeni Ürün Ücreti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(711, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "TL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 23);
            this.label4.TabIndex = 52;
            this.label4.Text = "GÜNCEL ÜRÜN LİSTESİ";
            // 
            // btnClearSearchText
            // 
            this.btnClearSearchText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClearSearchText.Location = new System.Drawing.Point(542, 55);
            this.btnClearSearchText.Name = "btnClearSearchText";
            this.btnClearSearchText.Size = new System.Drawing.Size(68, 26);
            this.btnClearSearchText.TabIndex = 63;
            this.btnClearSearchText.Text = "TEMİZLE";
            this.btnClearSearchText.UseVisualStyleBackColor = true;
            this.btnClearSearchText.Click += new System.EventHandler(this.btnClearSearchText_Click);
            // 
            // btnAllProducts
            // 
            this.btnAllProducts.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAllProducts.Location = new System.Drawing.Point(616, 55);
            this.btnAllProducts.Name = "btnAllProducts";
            this.btnAllProducts.Size = new System.Drawing.Size(115, 26);
            this.btnAllProducts.TabIndex = 55;
            this.btnAllProducts.Text = "TÜM ÜRÜNLER";
            this.btnAllProducts.UseVisualStyleBackColor = true;
            this.btnAllProducts.Click += new System.EventHandler(this.btnAllProducts_Click);
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSearch.Location = new System.Drawing.Point(468, 55);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(68, 26);
            this.bSearch.TabIndex = 3;
            this.bSearch.Text = "ARA";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 14);
            this.label5.TabIndex = 62;
            this.label5.Text = "Ürün Adı:";
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(73, 59);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(170, 20);
            this.txtSName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(249, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 14);
            this.label8.TabIndex = 57;
            this.label8.Text = "Ürün Türü:";
            // 
            // txtSType
            // 
            this.txtSType.Location = new System.Drawing.Point(322, 59);
            this.txtSType.Name = "txtSType";
            this.txtSType.Size = new System.Drawing.Size(140, 20);
            this.txtSType.TabIndex = 2;
            // 
            // fUpdateProduct
            // 
            this.AcceptButton = this.bSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 517);
            this.Controls.Add(this.btnClearSearchText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAllProducts);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.txtSType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateCost);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnUpdateName);
            this.Controls.Add(this.btnAddPizzaTopping);
            this.Controls.Add(this.btnAddPizzaThick);
            this.Controls.Add(this.btnAddPizzaCrust);
            this.Controls.Add(this.btnAddExtra);
            this.Controls.Add(this.btnAddSauce);
            this.Controls.Add(this.btnAddDrink);
            this.Controls.Add(this.btnAddPizza);
            this.Controls.Add(this.dgProducts);
            this.Controls.Add(this.btnDeleteProduct);
            this.MaximizeBox = false;
            this.Name = "fUpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Güncelle";
            this.Activated += new System.EventHandler(this.fUpdateProduct_Activated);
            this.Load += new System.EventHandler(this.fUpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.Button btnAddPizza;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.Button btnAddSauce;
        private System.Windows.Forms.Button btnAddExtra;
        private System.Windows.Forms.Button btnAddPizzaCrust;
        private System.Windows.Forms.Button btnAddPizzaThick;
        private System.Windows.Forms.Button btnAddPizzaTopping;
        private System.Windows.Forms.Button btnUpdateName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnUpdateCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearSearchText;
        private System.Windows.Forms.Button btnAllProducts;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSType;
    }
}