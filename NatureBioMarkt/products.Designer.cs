
namespace NatureBioMarkt
{
    partial class products
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
            this.textBox_ProductName = new System.Windows.Forms.TextBox();
            this.textBox_ProduktMarke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ProductPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_ProduktCategorie = new System.Windows.Forms.ComboBox();
            this.btnProductSave = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.btnProductDelet = new System.Windows.Forms.Button();
            this.productsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBox_ProductName
            // 
            this.textBox_ProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBox_ProductName.ForeColor = System.Drawing.Color.White;
            this.textBox_ProductName.Location = new System.Drawing.Point(93, 12);
            this.textBox_ProductName.Name = "textBox_ProductName";
            this.textBox_ProductName.Size = new System.Drawing.Size(119, 20);
            this.textBox_ProductName.TabIndex = 1;
            // 
            // textBox_ProduktMarke
            // 
            this.textBox_ProduktMarke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBox_ProduktMarke.ForeColor = System.Drawing.Color.White;
            this.textBox_ProduktMarke.Location = new System.Drawing.Point(93, 38);
            this.textBox_ProduktMarke.Name = "textBox_ProduktMarke";
            this.textBox_ProduktMarke.Size = new System.Drawing.Size(119, 20);
            this.textBox_ProduktMarke.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategorie";
            // 
            // textBox_ProductPrice
            // 
            this.textBox_ProductPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBox_ProductPrice.ForeColor = System.Drawing.Color.White;
            this.textBox_ProductPrice.Location = new System.Drawing.Point(93, 91);
            this.textBox_ProductPrice.Name = "textBox_ProductPrice";
            this.textBox_ProductPrice.Size = new System.Drawing.Size(119, 20);
            this.textBox_ProductPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(17, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "preis";
            // 
            // comboBox_ProduktCategorie
            // 
            this.comboBox_ProduktCategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.comboBox_ProduktCategorie.ForeColor = System.Drawing.Color.White;
            this.comboBox_ProduktCategorie.FormattingEnabled = true;
            this.comboBox_ProduktCategorie.Items.AddRange(new object[] {
            "Obst",
            "Gemüse",
            "Fleisch",
            "Fisch",
            "Drogerie",
            "Getränke"});
            this.comboBox_ProduktCategorie.Location = new System.Drawing.Point(93, 64);
            this.comboBox_ProduktCategorie.Name = "comboBox_ProduktCategorie";
            this.comboBox_ProduktCategorie.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ProduktCategorie.TabIndex = 8;
            // 
            // btnProductSave
            // 
            this.btnProductSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnProductSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSave.ForeColor = System.Drawing.Color.White;
            this.btnProductSave.Location = new System.Drawing.Point(93, 117);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.Size = new System.Drawing.Size(75, 23);
            this.btnProductSave.TabIndex = 9;
            this.btnProductSave.Text = "Speichern";
            this.btnProductSave.UseVisualStyleBackColor = false;
            this.btnProductSave.Click += new System.EventHandler(this.btnProductSave_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.Location = new System.Drawing.Point(255, 117);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(75, 23);
            this.btnEditProduct.TabIndex = 10;
            this.btnEditProduct.Text = "Bearbeiten";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpty.ForeColor = System.Drawing.Color.White;
            this.btnEmpty.Location = new System.Drawing.Point(174, 117);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(75, 23);
            this.btnEmpty.TabIndex = 11;
            this.btnEmpty.Text = "felder leeren";
            this.btnEmpty.UseVisualStyleBackColor = false;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // btnProductDelet
            // 
            this.btnProductDelet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnProductDelet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductDelet.ForeColor = System.Drawing.Color.White;
            this.btnProductDelet.Location = new System.Drawing.Point(336, 117);
            this.btnProductDelet.Name = "btnProductDelet";
            this.btnProductDelet.Size = new System.Drawing.Size(75, 23);
            this.btnProductDelet.TabIndex = 12;
            this.btnProductDelet.Text = "löschen";
            this.btnProductDelet.UseVisualStyleBackColor = false;
            this.btnProductDelet.Click += new System.EventHandler(this.btnProductDelet_Click);
            // 
            // productsDGV
            // 
            this.productsDGV.AllowDrop = true;
            this.productsDGV.AllowUserToDeleteRows = false;
            this.productsDGV.AllowUserToResizeColumns = false;
            this.productsDGV.AllowUserToResizeRows = false;
            this.productsDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.productsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDGV.GridColor = System.Drawing.Color.White;
            this.productsDGV.Location = new System.Drawing.Point(16, 146);
            this.productsDGV.MultiSelect = false;
            this.productsDGV.Name = "productsDGV";
            this.productsDGV.ReadOnly = true;
            this.productsDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.productsDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.productsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.productsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.productsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDGV.Size = new System.Drawing.Size(771, 299);
            this.productsDGV.TabIndex = 13;
            this.productsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDGV_CellContentClick);
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NatureBioMarkt.Properties.Resources.ImgBgProducts;
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.productsDGV);
            this.Controls.Add(this.btnProductDelet);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnProductSave);
            this.Controls.Add(this.comboBox_ProduktCategorie);
            this.Controls.Add(this.textBox_ProductPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ProduktMarke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ProductName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "products";
            this.Load += new System.EventHandler(this.products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ProductName;
        private System.Windows.Forms.TextBox textBox_ProduktMarke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ProductPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_ProduktCategorie;
        private System.Windows.Forms.Button btnProductSave;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Button btnProductDelet;
        private System.Windows.Forms.DataGridView productsDGV;
    }
}