
namespace NatureBioMarkt
{
    partial class Rechnungs
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_emp = new System.Windows.Forms.TextBox();
            this.textBox1_preis = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_empty = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SaddleBrown;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rechnung Empfänger";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SaddleBrown;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inhalt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SaddleBrown;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gesamt Pries";
            // 
            // textBox1_emp
            // 
            this.textBox1_emp.Location = new System.Drawing.Point(141, 54);
            this.textBox1_emp.Name = "textBox1_emp";
            this.textBox1_emp.Size = new System.Drawing.Size(127, 20);
            this.textBox1_emp.TabIndex = 5;
            this.textBox1_emp.TextChanged += new System.EventHandler(this.textBox1_emp_TextChanged);
            // 
            // textBox1_preis
            // 
            this.textBox1_preis.Location = new System.Drawing.Point(139, 112);
            this.textBox1_preis.Name = "textBox1_preis";
            this.textBox1_preis.Size = new System.Drawing.Size(129, 20);
            this.textBox1_preis.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "obst",
            "gemüse",
            "Dragorie",
            "beauty"});
            this.comboBox1.Location = new System.Drawing.Point(141, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_save
            // 
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Image = global::NatureBioMarkt.Properties.Resources.BtnImgBill;
            this.btn_save.Location = new System.Drawing.Point(82, 170);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_empty
            // 
            this.btn_empty.ForeColor = System.Drawing.Color.White;
            this.btn_empty.Image = global::NatureBioMarkt.Properties.Resources.BtnImgBill;
            this.btn_empty.Location = new System.Drawing.Point(193, 170);
            this.btn_empty.Name = "btn_empty";
            this.btn_empty.Size = new System.Drawing.Size(75, 23);
            this.btn_empty.TabIndex = 9;
            this.btn_empty.Text = "leeren";
            this.btn_empty.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Image = global::NatureBioMarkt.Properties.Resources.BtnImgBill;
            this.btn_edit.Location = new System.Drawing.Point(305, 170);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGrid.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(48, 213);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(570, 210);
            this.dataGrid.TabIndex = 11;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // Rechnungs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NatureBioMarkt.Properties.Resources.BtnImgBill;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_empty);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1_preis);
            this.Controls.Add(this.textBox1_emp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Rechnungs";
            this.Text = "Rechnungs";
            this.Load += new System.EventHandler(this.Rechnungs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1_emp;
        private System.Windows.Forms.TextBox textBox1_preis;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_empty;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}