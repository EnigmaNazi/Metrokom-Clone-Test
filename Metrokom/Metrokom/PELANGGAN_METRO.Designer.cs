﻿namespace Metrokom
{
    partial class PELANGGAN_METRO
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
            this.btn_delete_plg = new System.Windows.Forms.Button();
            this.btn_edit_plg = new System.Windows.Forms.Button();
            this.btn_new_plg = new System.Windows.Forms.Button();
            this.dg_pelanggan = new System.Windows.Forms.DataGridView();
            this.txt_cari_plg = new System.Windows.Forms.TextBox();
            this.search_plg = new System.Windows.Forms.Button();
            this.btn_close_plg = new System.Windows.Forms.Button();
            this.btn_save_plg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_alamat_plg = new System.Windows.Forms.TextBox();
            this.txt_notelp_plg = new System.Windows.Forms.TextBox();
            this.txt_nama_plg = new System.Windows.Forms.TextBox();
            this.txt_kode_plg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pelanggan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_delete_plg
            // 
            this.btn_delete_plg.Location = new System.Drawing.Point(228, 220);
            this.btn_delete_plg.Name = "btn_delete_plg";
            this.btn_delete_plg.Size = new System.Drawing.Size(69, 32);
            this.btn_delete_plg.TabIndex = 55;
            this.btn_delete_plg.Text = "Delete";
            this.btn_delete_plg.UseVisualStyleBackColor = true;
            this.btn_delete_plg.Click += new System.EventHandler(this.btn_delete_plg_Click);
            // 
            // btn_edit_plg
            // 
            this.btn_edit_plg.Location = new System.Drawing.Point(153, 220);
            this.btn_edit_plg.Name = "btn_edit_plg";
            this.btn_edit_plg.Size = new System.Drawing.Size(69, 32);
            this.btn_edit_plg.TabIndex = 54;
            this.btn_edit_plg.Text = "Edit";
            this.btn_edit_plg.UseVisualStyleBackColor = true;
            this.btn_edit_plg.Click += new System.EventHandler(this.btn_edit_plg_Click);
            // 
            // btn_new_plg
            // 
            this.btn_new_plg.Location = new System.Drawing.Point(3, 220);
            this.btn_new_plg.Name = "btn_new_plg";
            this.btn_new_plg.Size = new System.Drawing.Size(69, 32);
            this.btn_new_plg.TabIndex = 53;
            this.btn_new_plg.Text = "New";
            this.btn_new_plg.UseVisualStyleBackColor = true;
            this.btn_new_plg.Click += new System.EventHandler(this.btn_new_plg_Click);
            // 
            // dg_pelanggan
            // 
            this.dg_pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_pelanggan.Location = new System.Drawing.Point(3, 284);
            this.dg_pelanggan.Name = "dg_pelanggan";
            this.dg_pelanggan.Size = new System.Drawing.Size(369, 180);
            this.dg_pelanggan.TabIndex = 52;
            this.dg_pelanggan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_pelanggan_CellContentClick);
            // 
            // txt_cari_plg
            // 
            this.txt_cari_plg.Location = new System.Drawing.Point(3, 258);
            this.txt_cari_plg.Name = "txt_cari_plg";
            this.txt_cari_plg.Size = new System.Drawing.Size(307, 20);
            this.txt_cari_plg.TabIndex = 51;
            // 
            // search_plg
            // 
            this.search_plg.Location = new System.Drawing.Point(316, 254);
            this.search_plg.Name = "search_plg";
            this.search_plg.Size = new System.Drawing.Size(56, 27);
            this.search_plg.TabIndex = 50;
            this.search_plg.Text = "Search";
            this.search_plg.UseVisualStyleBackColor = true;
            // 
            // btn_close_plg
            // 
            this.btn_close_plg.Location = new System.Drawing.Point(303, 220);
            this.btn_close_plg.Name = "btn_close_plg";
            this.btn_close_plg.Size = new System.Drawing.Size(69, 32);
            this.btn_close_plg.TabIndex = 49;
            this.btn_close_plg.Text = "Close";
            this.btn_close_plg.UseVisualStyleBackColor = true;
            this.btn_close_plg.Click += new System.EventHandler(this.btn_close_plg_Click);
            // 
            // btn_save_plg
            // 
            this.btn_save_plg.Location = new System.Drawing.Point(78, 220);
            this.btn_save_plg.Name = "btn_save_plg";
            this.btn_save_plg.Size = new System.Drawing.Size(69, 32);
            this.btn_save_plg.TabIndex = 48;
            this.btn_save_plg.Text = "Save";
            this.btn_save_plg.UseVisualStyleBackColor = true;
            this.btn_save_plg.Click += new System.EventHandler(this.btn_save_plg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nama Pelanggan";
            // 
            // txt_alamat_plg
            // 
            this.txt_alamat_plg.Location = new System.Drawing.Point(134, 126);
            this.txt_alamat_plg.Multiline = true;
            this.txt_alamat_plg.Name = "txt_alamat_plg";
            this.txt_alamat_plg.Size = new System.Drawing.Size(226, 50);
            this.txt_alamat_plg.TabIndex = 46;
            // 
            // txt_notelp_plg
            // 
            this.txt_notelp_plg.Location = new System.Drawing.Point(133, 94);
            this.txt_notelp_plg.Name = "txt_notelp_plg";
            this.txt_notelp_plg.Size = new System.Drawing.Size(227, 20);
            this.txt_notelp_plg.TabIndex = 45;
            // 
            // txt_nama_plg
            // 
            this.txt_nama_plg.Location = new System.Drawing.Point(133, 58);
            this.txt_nama_plg.Name = "txt_nama_plg";
            this.txt_nama_plg.Size = new System.Drawing.Size(227, 20);
            this.txt_nama_plg.TabIndex = 44;
            // 
            // txt_kode_plg
            // 
            this.txt_kode_plg.Location = new System.Drawing.Point(133, 25);
            this.txt_kode_plg.Name = "txt_kode_plg";
            this.txt_kode_plg.Size = new System.Drawing.Size(227, 20);
            this.txt_kode_plg.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "No Telp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Alamat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Kode Pelanggan";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.txt_alamat_plg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_kode_plg);
            this.groupBox1.Controls.Add(this.txt_nama_plg);
            this.groupBox1.Controls.Add(this.txt_notelp_plg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 205);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pelanggan";
            // 
            // PELANGGAN_METRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 465);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_delete_plg);
            this.Controls.Add(this.btn_edit_plg);
            this.Controls.Add(this.btn_new_plg);
            this.Controls.Add(this.dg_pelanggan);
            this.Controls.Add(this.txt_cari_plg);
            this.Controls.Add(this.search_plg);
            this.Controls.Add(this.btn_close_plg);
            this.Controls.Add(this.btn_save_plg);
            this.Name = "PELANGGAN_METRO";
            this.Text = "PELANGGAN_METRO";
            ((System.ComponentModel.ISupportInitialize)(this.dg_pelanggan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete_plg;
        private System.Windows.Forms.Button btn_edit_plg;
        private System.Windows.Forms.Button btn_new_plg;
        private System.Windows.Forms.DataGridView dg_pelanggan;
        private System.Windows.Forms.TextBox txt_cari_plg;
        private System.Windows.Forms.Button search_plg;
        private System.Windows.Forms.Button btn_close_plg;
        private System.Windows.Forms.Button btn_save_plg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_alamat_plg;
        private System.Windows.Forms.TextBox txt_notelp_plg;
        private System.Windows.Forms.TextBox txt_nama_plg;
        private System.Windows.Forms.TextBox txt_kode_plg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}