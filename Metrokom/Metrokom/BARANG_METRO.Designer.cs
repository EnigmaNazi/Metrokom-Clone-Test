﻿namespace Metrokom
{
    partial class BARANG_METRO
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
            this.btn_delete_brg = new System.Windows.Forms.Button();
            this.btn_edit_brg = new System.Windows.Forms.Button();
            this.btn_new_brg = new System.Windows.Forms.Button();
            this.dg_barang = new System.Windows.Forms.DataGridView();
            this.txt_cari_barang = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_close_brg = new System.Windows.Forms.Button();
            this.btn_save_brg = new System.Windows.Forms.Button();
            this.cmb_satuan_barang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_stock_barang = new System.Windows.Forms.TextBox();
            this.txt_harga_barang = new System.Windows.Forms.TextBox();
            this.txt_nama_barang = new System.Windows.Forms.TextBox();
            this.txt_kode_barang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_barang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_delete_brg
            // 
            this.btn_delete_brg.Location = new System.Drawing.Point(228, 220);
            this.btn_delete_brg.Name = "btn_delete_brg";
            this.btn_delete_brg.Size = new System.Drawing.Size(69, 32);
            this.btn_delete_brg.TabIndex = 39;
            this.btn_delete_brg.Text = "Delete";
            this.btn_delete_brg.UseVisualStyleBackColor = true;
            this.btn_delete_brg.Click += new System.EventHandler(this.btn_delete_brg_Click);
            // 
            // btn_edit_brg
            // 
            this.btn_edit_brg.Location = new System.Drawing.Point(153, 220);
            this.btn_edit_brg.Name = "btn_edit_brg";
            this.btn_edit_brg.Size = new System.Drawing.Size(69, 32);
            this.btn_edit_brg.TabIndex = 38;
            this.btn_edit_brg.Text = "Edit";
            this.btn_edit_brg.UseVisualStyleBackColor = true;
            this.btn_edit_brg.Click += new System.EventHandler(this.btn_edit_brg_Click);
            // 
            // btn_new_brg
            // 
            this.btn_new_brg.Location = new System.Drawing.Point(3, 220);
            this.btn_new_brg.Name = "btn_new_brg";
            this.btn_new_brg.Size = new System.Drawing.Size(69, 32);
            this.btn_new_brg.TabIndex = 37;
            this.btn_new_brg.Text = "New";
            this.btn_new_brg.UseVisualStyleBackColor = true;
            this.btn_new_brg.Click += new System.EventHandler(this.btn_new_brg_Click);
            // 
            // dg_barang
            // 
            this.dg_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_barang.Location = new System.Drawing.Point(3, 284);
            this.dg_barang.Name = "dg_barang";
            this.dg_barang.Size = new System.Drawing.Size(369, 180);
            this.dg_barang.TabIndex = 36;
            this.dg_barang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_barang_CellContentClick);
            // 
            // txt_cari_barang
            // 
            this.txt_cari_barang.Location = new System.Drawing.Point(3, 258);
            this.txt_cari_barang.Name = "txt_cari_barang";
            this.txt_cari_barang.Size = new System.Drawing.Size(307, 20);
            this.txt_cari_barang.TabIndex = 35;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(316, 254);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 27);
            this.button6.TabIndex = 34;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btn_close_brg
            // 
            this.btn_close_brg.Location = new System.Drawing.Point(303, 220);
            this.btn_close_brg.Name = "btn_close_brg";
            this.btn_close_brg.Size = new System.Drawing.Size(69, 32);
            this.btn_close_brg.TabIndex = 33;
            this.btn_close_brg.Text = "Close";
            this.btn_close_brg.UseVisualStyleBackColor = true;
            this.btn_close_brg.Click += new System.EventHandler(this.btn_close_brg_Click);
            // 
            // btn_save_brg
            // 
            this.btn_save_brg.Location = new System.Drawing.Point(78, 220);
            this.btn_save_brg.Name = "btn_save_brg";
            this.btn_save_brg.Size = new System.Drawing.Size(69, 32);
            this.btn_save_brg.TabIndex = 32;
            this.btn_save_brg.Text = "Save";
            this.btn_save_brg.UseVisualStyleBackColor = true;
            this.btn_save_brg.Click += new System.EventHandler(this.btn_save_brg_Click);
            // 
            // cmb_satuan_barang
            // 
            this.cmb_satuan_barang.FormattingEnabled = true;
            this.cmb_satuan_barang.Items.AddRange(new object[] {
            "Buah",
            "Kotak",
            "Lusin",
            "PCS"});
            this.cmb_satuan_barang.Location = new System.Drawing.Point(129, 96);
            this.cmb_satuan_barang.Name = "cmb_satuan_barang";
            this.cmb_satuan_barang.Size = new System.Drawing.Size(231, 21);
            this.cmb_satuan_barang.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nama Barang";
            // 
            // txt_stock_barang
            // 
            this.txt_stock_barang.Location = new System.Drawing.Point(129, 171);
            this.txt_stock_barang.Name = "txt_stock_barang";
            this.txt_stock_barang.Size = new System.Drawing.Size(100, 20);
            this.txt_stock_barang.TabIndex = 29;
            // 
            // txt_harga_barang
            // 
            this.txt_harga_barang.Location = new System.Drawing.Point(129, 134);
            this.txt_harga_barang.Name = "txt_harga_barang";
            this.txt_harga_barang.Size = new System.Drawing.Size(231, 20);
            this.txt_harga_barang.TabIndex = 28;
            // 
            // txt_nama_barang
            // 
            this.txt_nama_barang.Location = new System.Drawing.Point(129, 60);
            this.txt_nama_barang.Name = "txt_nama_barang";
            this.txt_nama_barang.Size = new System.Drawing.Size(231, 20);
            this.txt_nama_barang.TabIndex = 27;
            // 
            // txt_kode_barang
            // 
            this.txt_kode_barang.Location = new System.Drawing.Point(129, 23);
            this.txt_kode_barang.Name = "txt_kode_barang";
            this.txt_kode_barang.Size = new System.Drawing.Size(231, 20);
            this.txt_kode_barang.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Satuan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kode Barang";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.txt_kode_barang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_nama_barang);
            this.groupBox1.Controls.Add(this.txt_harga_barang);
            this.groupBox1.Controls.Add(this.txt_stock_barang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_satuan_barang);
            this.groupBox1.Location = new System.Drawing.Point(3, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 205);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Barang";
            // 
            // BARANG_METRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 465);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_delete_brg);
            this.Controls.Add(this.btn_edit_brg);
            this.Controls.Add(this.btn_new_brg);
            this.Controls.Add(this.dg_barang);
            this.Controls.Add(this.txt_cari_barang);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_close_brg);
            this.Controls.Add(this.btn_save_brg);
            this.Name = "BARANG_METRO";
            this.Text = "BARANG_METRO";
            ((System.ComponentModel.ISupportInitialize)(this.dg_barang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete_brg;
        private System.Windows.Forms.Button btn_edit_brg;
        private System.Windows.Forms.Button btn_new_brg;
        private System.Windows.Forms.DataGridView dg_barang;
        private System.Windows.Forms.TextBox txt_cari_barang;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_close_brg;
        private System.Windows.Forms.Button btn_save_brg;
        private System.Windows.Forms.ComboBox cmb_satuan_barang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_stock_barang;
        private System.Windows.Forms.TextBox txt_harga_barang;
        private System.Windows.Forms.TextBox txt_nama_barang;
        private System.Windows.Forms.TextBox txt_kode_barang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}