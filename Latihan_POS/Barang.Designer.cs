namespace Latihan_POS
{
    partial class Barang
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
            this.tcBarang = new System.Windows.Forms.TabControl();
            this.tpRegistrasi = new System.Windows.Forms.TabPage();
            this.reg_btn_keluar = new System.Windows.Forms.Button();
            this.reg_btn_cancel = new System.Windows.Forms.Button();
            this.reg_btn_simpan = new System.Windows.Forms.Button();
            this.reg_txt_HargaJual = new System.Windows.Forms.TextBox();
            this.reg_txt_HargaHPP = new System.Windows.Forms.TextBox();
            this.reg_txt_Jlhawal = new System.Windows.Forms.TextBox();
            this.reg_txt_Nama = new System.Windows.Forms.TextBox();
            this.reg_txt_Kode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpEdit = new System.Windows.Forms.TabPage();
            this.edit_btn_Check = new System.Windows.Forms.Button();
            this.edit_btn_Cari = new System.Windows.Forms.Button();
            this.edit_btn_Keluar = new System.Windows.Forms.Button();
            this.edit_btn_Cancel = new System.Windows.Forms.Button();
            this.edit_btn_Simpan = new System.Windows.Forms.Button();
            this.edit_txt_HargaJual = new System.Windows.Forms.TextBox();
            this.edit_txt_HargaHPP = new System.Windows.Forms.TextBox();
            this.edit_txt_Jlhawal = new System.Windows.Forms.TextBox();
            this.edit_txt_Nama = new System.Windows.Forms.TextBox();
            this.edit_txt_Kode = new System.Windows.Forms.TextBox();
            this.edit_txt_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tpDelete = new System.Windows.Forms.TabPage();
            this.del_btn_Check = new System.Windows.Forms.Button();
            this.del_btn_Cari = new System.Windows.Forms.Button();
            this.del_btn_Keluar = new System.Windows.Forms.Button();
            this.del_btn_Cancel = new System.Windows.Forms.Button();
            this.del_btn_Delete = new System.Windows.Forms.Button();
            this.del_txt_HargaJual = new System.Windows.Forms.TextBox();
            this.del_txt_HargaHPP = new System.Windows.Forms.TextBox();
            this.del_txt_Jlhawal = new System.Windows.Forms.TextBox();
            this.del_txt_Nama = new System.Windows.Forms.TextBox();
            this.del_txt_Kode = new System.Windows.Forms.TextBox();
            this.del_txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tpDaftar = new System.Windows.Forms.TabPage();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.tcBarang.SuspendLayout();
            this.tpRegistrasi.SuspendLayout();
            this.tpEdit.SuspendLayout();
            this.tpDelete.SuspendLayout();
            this.tpDaftar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // tcBarang
            // 
            this.tcBarang.Controls.Add(this.tpRegistrasi);
            this.tcBarang.Controls.Add(this.tpEdit);
            this.tcBarang.Controls.Add(this.tpDelete);
            this.tcBarang.Controls.Add(this.tpDaftar);
            this.tcBarang.Location = new System.Drawing.Point(0, 0);
            this.tcBarang.Name = "tcBarang";
            this.tcBarang.SelectedIndex = 0;
            this.tcBarang.Size = new System.Drawing.Size(884, 246);
            this.tcBarang.TabIndex = 0;
            this.tcBarang.SelectedIndexChanged += new System.EventHandler(this.tcBarang_SelectedIndexChanged);
            // 
            // tpRegistrasi
            // 
            this.tpRegistrasi.Controls.Add(this.reg_btn_keluar);
            this.tpRegistrasi.Controls.Add(this.reg_btn_cancel);
            this.tpRegistrasi.Controls.Add(this.reg_btn_simpan);
            this.tpRegistrasi.Controls.Add(this.reg_txt_HargaJual);
            this.tpRegistrasi.Controls.Add(this.reg_txt_HargaHPP);
            this.tpRegistrasi.Controls.Add(this.reg_txt_Jlhawal);
            this.tpRegistrasi.Controls.Add(this.reg_txt_Nama);
            this.tpRegistrasi.Controls.Add(this.reg_txt_Kode);
            this.tpRegistrasi.Controls.Add(this.label6);
            this.tpRegistrasi.Controls.Add(this.label5);
            this.tpRegistrasi.Controls.Add(this.label4);
            this.tpRegistrasi.Controls.Add(this.label3);
            this.tpRegistrasi.Controls.Add(this.label2);
            this.tpRegistrasi.Location = new System.Drawing.Point(4, 22);
            this.tpRegistrasi.Name = "tpRegistrasi";
            this.tpRegistrasi.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistrasi.Size = new System.Drawing.Size(876, 220);
            this.tpRegistrasi.TabIndex = 0;
            this.tpRegistrasi.Text = "Registrasi";
            this.tpRegistrasi.UseVisualStyleBackColor = true;
            // 
            // reg_btn_keluar
            // 
            this.reg_btn_keluar.Location = new System.Drawing.Point(513, 81);
            this.reg_btn_keluar.Name = "reg_btn_keluar";
            this.reg_btn_keluar.Size = new System.Drawing.Size(75, 23);
            this.reg_btn_keluar.TabIndex = 71;
            this.reg_btn_keluar.Text = "Keluar";
            this.reg_btn_keluar.UseVisualStyleBackColor = true;
            this.reg_btn_keluar.Click += new System.EventHandler(this.reg_btn_keluar_Click);
            // 
            // reg_btn_cancel
            // 
            this.reg_btn_cancel.Location = new System.Drawing.Point(513, 55);
            this.reg_btn_cancel.Name = "reg_btn_cancel";
            this.reg_btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.reg_btn_cancel.TabIndex = 70;
            this.reg_btn_cancel.Text = "Cancel";
            this.reg_btn_cancel.UseVisualStyleBackColor = true;
            this.reg_btn_cancel.Click += new System.EventHandler(this.reg_btn_cancel_Click);
            // 
            // reg_btn_simpan
            // 
            this.reg_btn_simpan.Location = new System.Drawing.Point(513, 29);
            this.reg_btn_simpan.Name = "reg_btn_simpan";
            this.reg_btn_simpan.Size = new System.Drawing.Size(75, 23);
            this.reg_btn_simpan.TabIndex = 69;
            this.reg_btn_simpan.Text = "Simpan";
            this.reg_btn_simpan.UseVisualStyleBackColor = true;
            this.reg_btn_simpan.Click += new System.EventHandler(this.reg_btn_simpan_Click);
            // 
            // reg_txt_HargaJual
            // 
            this.reg_txt_HargaJual.Location = new System.Drawing.Point(375, 133);
            this.reg_txt_HargaJual.Name = "reg_txt_HargaJual";
            this.reg_txt_HargaJual.Size = new System.Drawing.Size(100, 20);
            this.reg_txt_HargaJual.TabIndex = 68;
            // 
            // reg_txt_HargaHPP
            // 
            this.reg_txt_HargaHPP.Location = new System.Drawing.Point(375, 107);
            this.reg_txt_HargaHPP.Name = "reg_txt_HargaHPP";
            this.reg_txt_HargaHPP.Size = new System.Drawing.Size(100, 20);
            this.reg_txt_HargaHPP.TabIndex = 67;
            // 
            // reg_txt_Jlhawal
            // 
            this.reg_txt_Jlhawal.Location = new System.Drawing.Point(375, 81);
            this.reg_txt_Jlhawal.Name = "reg_txt_Jlhawal";
            this.reg_txt_Jlhawal.Size = new System.Drawing.Size(100, 20);
            this.reg_txt_Jlhawal.TabIndex = 66;
            // 
            // reg_txt_Nama
            // 
            this.reg_txt_Nama.Location = new System.Drawing.Point(375, 55);
            this.reg_txt_Nama.Name = "reg_txt_Nama";
            this.reg_txt_Nama.Size = new System.Drawing.Size(100, 20);
            this.reg_txt_Nama.TabIndex = 65;
            // 
            // reg_txt_Kode
            // 
            this.reg_txt_Kode.Location = new System.Drawing.Point(375, 29);
            this.reg_txt_Kode.Name = "reg_txt_Kode";
            this.reg_txt_Kode.Size = new System.Drawing.Size(100, 20);
            this.reg_txt_Kode.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Harga Jual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Harga HPP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Jlh awal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Kode";
            // 
            // tpEdit
            // 
            this.tpEdit.Controls.Add(this.edit_btn_Check);
            this.tpEdit.Controls.Add(this.edit_btn_Cari);
            this.tpEdit.Controls.Add(this.edit_btn_Keluar);
            this.tpEdit.Controls.Add(this.edit_btn_Cancel);
            this.tpEdit.Controls.Add(this.edit_btn_Simpan);
            this.tpEdit.Controls.Add(this.edit_txt_HargaJual);
            this.tpEdit.Controls.Add(this.edit_txt_HargaHPP);
            this.tpEdit.Controls.Add(this.edit_txt_Jlhawal);
            this.tpEdit.Controls.Add(this.edit_txt_Nama);
            this.tpEdit.Controls.Add(this.edit_txt_Kode);
            this.tpEdit.Controls.Add(this.edit_txt_ID);
            this.tpEdit.Controls.Add(this.label7);
            this.tpEdit.Controls.Add(this.label8);
            this.tpEdit.Controls.Add(this.label9);
            this.tpEdit.Controls.Add(this.label10);
            this.tpEdit.Controls.Add(this.label11);
            this.tpEdit.Controls.Add(this.label12);
            this.tpEdit.Location = new System.Drawing.Point(4, 22);
            this.tpEdit.Name = "tpEdit";
            this.tpEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpEdit.Size = new System.Drawing.Size(876, 220);
            this.tpEdit.TabIndex = 1;
            this.tpEdit.Text = "Edit";
            this.tpEdit.UseVisualStyleBackColor = true;
            // 
            // edit_btn_Check
            // 
            this.edit_btn_Check.Location = new System.Drawing.Point(517, 61);
            this.edit_btn_Check.Name = "edit_btn_Check";
            this.edit_btn_Check.Size = new System.Drawing.Size(75, 23);
            this.edit_btn_Check.TabIndex = 62;
            this.edit_btn_Check.Text = "Check";
            this.edit_btn_Check.UseVisualStyleBackColor = true;
            this.edit_btn_Check.Click += new System.EventHandler(this.edit_btn_Check_Click);
            // 
            // edit_btn_Cari
            // 
            this.edit_btn_Cari.Location = new System.Drawing.Point(517, 35);
            this.edit_btn_Cari.Name = "edit_btn_Cari";
            this.edit_btn_Cari.Size = new System.Drawing.Size(75, 23);
            this.edit_btn_Cari.TabIndex = 61;
            this.edit_btn_Cari.Text = "Cari";
            this.edit_btn_Cari.UseVisualStyleBackColor = true;
            this.edit_btn_Cari.Click += new System.EventHandler(this.edit_btn_Cari_Click);
            // 
            // edit_btn_Keluar
            // 
            this.edit_btn_Keluar.Location = new System.Drawing.Point(517, 139);
            this.edit_btn_Keluar.Name = "edit_btn_Keluar";
            this.edit_btn_Keluar.Size = new System.Drawing.Size(75, 23);
            this.edit_btn_Keluar.TabIndex = 60;
            this.edit_btn_Keluar.Text = "Keluar";
            this.edit_btn_Keluar.UseVisualStyleBackColor = true;
            this.edit_btn_Keluar.Click += new System.EventHandler(this.reg_btn_keluar_Click);
            // 
            // edit_btn_Cancel
            // 
            this.edit_btn_Cancel.Location = new System.Drawing.Point(517, 113);
            this.edit_btn_Cancel.Name = "edit_btn_Cancel";
            this.edit_btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.edit_btn_Cancel.TabIndex = 59;
            this.edit_btn_Cancel.Text = "Cancel";
            this.edit_btn_Cancel.UseVisualStyleBackColor = true;
            this.edit_btn_Cancel.Click += new System.EventHandler(this.reg_btn_cancel_Click);
            // 
            // edit_btn_Simpan
            // 
            this.edit_btn_Simpan.Location = new System.Drawing.Point(517, 87);
            this.edit_btn_Simpan.Name = "edit_btn_Simpan";
            this.edit_btn_Simpan.Size = new System.Drawing.Size(75, 23);
            this.edit_btn_Simpan.TabIndex = 58;
            this.edit_btn_Simpan.Text = "Simpan";
            this.edit_btn_Simpan.UseVisualStyleBackColor = true;
            this.edit_btn_Simpan.Click += new System.EventHandler(this.edit_btn_Simpan_Click);
            // 
            // edit_txt_HargaJual
            // 
            this.edit_txt_HargaJual.Location = new System.Drawing.Point(372, 165);
            this.edit_txt_HargaJual.Name = "edit_txt_HargaJual";
            this.edit_txt_HargaJual.Size = new System.Drawing.Size(100, 20);
            this.edit_txt_HargaJual.TabIndex = 57;
            // 
            // edit_txt_HargaHPP
            // 
            this.edit_txt_HargaHPP.Location = new System.Drawing.Point(372, 139);
            this.edit_txt_HargaHPP.Name = "edit_txt_HargaHPP";
            this.edit_txt_HargaHPP.Size = new System.Drawing.Size(100, 20);
            this.edit_txt_HargaHPP.TabIndex = 56;
            // 
            // edit_txt_Jlhawal
            // 
            this.edit_txt_Jlhawal.Location = new System.Drawing.Point(372, 113);
            this.edit_txt_Jlhawal.Name = "edit_txt_Jlhawal";
            this.edit_txt_Jlhawal.Size = new System.Drawing.Size(100, 20);
            this.edit_txt_Jlhawal.TabIndex = 55;
            // 
            // edit_txt_Nama
            // 
            this.edit_txt_Nama.Location = new System.Drawing.Point(372, 87);
            this.edit_txt_Nama.Name = "edit_txt_Nama";
            this.edit_txt_Nama.Size = new System.Drawing.Size(100, 20);
            this.edit_txt_Nama.TabIndex = 54;
            // 
            // edit_txt_Kode
            // 
            this.edit_txt_Kode.Location = new System.Drawing.Point(372, 61);
            this.edit_txt_Kode.Name = "edit_txt_Kode";
            this.edit_txt_Kode.Size = new System.Drawing.Size(100, 20);
            this.edit_txt_Kode.TabIndex = 53;
            // 
            // edit_txt_ID
            // 
            this.edit_txt_ID.Location = new System.Drawing.Point(372, 35);
            this.edit_txt_ID.Name = "edit_txt_ID";
            this.edit_txt_ID.Size = new System.Drawing.Size(100, 20);
            this.edit_txt_ID.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Harga Jual";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Harga HPP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Jlh awal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Nama";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Kode";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(284, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "ID";
            // 
            // tpDelete
            // 
            this.tpDelete.Controls.Add(this.del_btn_Check);
            this.tpDelete.Controls.Add(this.del_btn_Cari);
            this.tpDelete.Controls.Add(this.del_btn_Keluar);
            this.tpDelete.Controls.Add(this.del_btn_Cancel);
            this.tpDelete.Controls.Add(this.del_btn_Delete);
            this.tpDelete.Controls.Add(this.del_txt_HargaJual);
            this.tpDelete.Controls.Add(this.del_txt_HargaHPP);
            this.tpDelete.Controls.Add(this.del_txt_Jlhawal);
            this.tpDelete.Controls.Add(this.del_txt_Nama);
            this.tpDelete.Controls.Add(this.del_txt_Kode);
            this.tpDelete.Controls.Add(this.del_txt_ID);
            this.tpDelete.Controls.Add(this.label1);
            this.tpDelete.Controls.Add(this.label13);
            this.tpDelete.Controls.Add(this.label14);
            this.tpDelete.Controls.Add(this.label15);
            this.tpDelete.Controls.Add(this.label16);
            this.tpDelete.Controls.Add(this.label17);
            this.tpDelete.Location = new System.Drawing.Point(4, 22);
            this.tpDelete.Name = "tpDelete";
            this.tpDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tpDelete.Size = new System.Drawing.Size(876, 220);
            this.tpDelete.TabIndex = 2;
            this.tpDelete.Text = "Delete";
            this.tpDelete.UseVisualStyleBackColor = true;
            // 
            // del_btn_Check
            // 
            this.del_btn_Check.Location = new System.Drawing.Point(517, 61);
            this.del_btn_Check.Name = "del_btn_Check";
            this.del_btn_Check.Size = new System.Drawing.Size(75, 23);
            this.del_btn_Check.TabIndex = 78;
            this.del_btn_Check.Text = "Check";
            this.del_btn_Check.UseVisualStyleBackColor = true;
            this.del_btn_Check.Click += new System.EventHandler(this.del_btn_Check_Click);
            // 
            // del_btn_Cari
            // 
            this.del_btn_Cari.Location = new System.Drawing.Point(517, 35);
            this.del_btn_Cari.Name = "del_btn_Cari";
            this.del_btn_Cari.Size = new System.Drawing.Size(75, 23);
            this.del_btn_Cari.TabIndex = 77;
            this.del_btn_Cari.Text = "Cari";
            this.del_btn_Cari.UseVisualStyleBackColor = true;
            this.del_btn_Cari.Click += new System.EventHandler(this.del_btn_Cari_Click);
            // 
            // del_btn_Keluar
            // 
            this.del_btn_Keluar.Location = new System.Drawing.Point(517, 139);
            this.del_btn_Keluar.Name = "del_btn_Keluar";
            this.del_btn_Keluar.Size = new System.Drawing.Size(75, 23);
            this.del_btn_Keluar.TabIndex = 76;
            this.del_btn_Keluar.Text = "Keluar";
            this.del_btn_Keluar.UseVisualStyleBackColor = true;
            this.del_btn_Keluar.Click += new System.EventHandler(this.reg_btn_keluar_Click);
            // 
            // del_btn_Cancel
            // 
            this.del_btn_Cancel.Location = new System.Drawing.Point(517, 113);
            this.del_btn_Cancel.Name = "del_btn_Cancel";
            this.del_btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.del_btn_Cancel.TabIndex = 75;
            this.del_btn_Cancel.Text = "Cancel";
            this.del_btn_Cancel.UseVisualStyleBackColor = true;
            this.del_btn_Cancel.Click += new System.EventHandler(this.reg_btn_cancel_Click);
            // 
            // del_btn_Delete
            // 
            this.del_btn_Delete.Location = new System.Drawing.Point(517, 87);
            this.del_btn_Delete.Name = "del_btn_Delete";
            this.del_btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.del_btn_Delete.TabIndex = 74;
            this.del_btn_Delete.Text = "Delete";
            this.del_btn_Delete.UseVisualStyleBackColor = true;
            this.del_btn_Delete.Click += new System.EventHandler(this.del_btn_Delete_Click);
            // 
            // del_txt_HargaJual
            // 
            this.del_txt_HargaJual.Enabled = false;
            this.del_txt_HargaJual.Location = new System.Drawing.Point(372, 165);
            this.del_txt_HargaJual.Name = "del_txt_HargaJual";
            this.del_txt_HargaJual.Size = new System.Drawing.Size(100, 20);
            this.del_txt_HargaJual.TabIndex = 73;
            // 
            // del_txt_HargaHPP
            // 
            this.del_txt_HargaHPP.Enabled = false;
            this.del_txt_HargaHPP.Location = new System.Drawing.Point(372, 139);
            this.del_txt_HargaHPP.Name = "del_txt_HargaHPP";
            this.del_txt_HargaHPP.Size = new System.Drawing.Size(100, 20);
            this.del_txt_HargaHPP.TabIndex = 72;
            // 
            // del_txt_Jlhawal
            // 
            this.del_txt_Jlhawal.Enabled = false;
            this.del_txt_Jlhawal.Location = new System.Drawing.Point(372, 113);
            this.del_txt_Jlhawal.Name = "del_txt_Jlhawal";
            this.del_txt_Jlhawal.Size = new System.Drawing.Size(100, 20);
            this.del_txt_Jlhawal.TabIndex = 71;
            // 
            // del_txt_Nama
            // 
            this.del_txt_Nama.Enabled = false;
            this.del_txt_Nama.Location = new System.Drawing.Point(372, 87);
            this.del_txt_Nama.Name = "del_txt_Nama";
            this.del_txt_Nama.Size = new System.Drawing.Size(100, 20);
            this.del_txt_Nama.TabIndex = 70;
            // 
            // del_txt_Kode
            // 
            this.del_txt_Kode.Enabled = false;
            this.del_txt_Kode.Location = new System.Drawing.Point(372, 61);
            this.del_txt_Kode.Name = "del_txt_Kode";
            this.del_txt_Kode.Size = new System.Drawing.Size(100, 20);
            this.del_txt_Kode.TabIndex = 69;
            // 
            // del_txt_ID
            // 
            this.del_txt_ID.Location = new System.Drawing.Point(372, 35);
            this.del_txt_ID.Name = "del_txt_ID";
            this.del_txt_ID.Size = new System.Drawing.Size(100, 20);
            this.del_txt_ID.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Harga Jual";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(284, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 66;
            this.label13.Text = "Harga HPP";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(284, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 65;
            this.label14.Text = "Jlh awal";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(284, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 64;
            this.label15.Text = "Nama";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(284, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 63;
            this.label16.Text = "Kode";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(284, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 13);
            this.label17.TabIndex = 62;
            this.label17.Text = "ID";
            // 
            // tpDaftar
            // 
            this.tpDaftar.Controls.Add(this.dgvBarang);
            this.tpDaftar.Location = new System.Drawing.Point(4, 22);
            this.tpDaftar.Name = "tpDaftar";
            this.tpDaftar.Padding = new System.Windows.Forms.Padding(3);
            this.tpDaftar.Size = new System.Drawing.Size(876, 220);
            this.tpDaftar.TabIndex = 3;
            this.tpDaftar.Text = "Daftar";
            this.tpDaftar.UseVisualStyleBackColor = true;
            // 
            // dgvBarang
            // 
            this.dgvBarang.AllowUserToAddRows = false;
            this.dgvBarang.AllowUserToDeleteRows = false;
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Location = new System.Drawing.Point(0, 0);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.ReadOnly = true;
            this.dgvBarang.Size = new System.Drawing.Size(880, 220);
            this.dgvBarang.TabIndex = 0;
            this.dgvBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarang_CellClick);
            // 
            // Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 258);
            this.Controls.Add(this.tcBarang);
            this.Name = "Barang";
            this.Text = "Barang";
            this.Load += new System.EventHandler(this.Barang_Load);
            this.tcBarang.ResumeLayout(false);
            this.tpRegistrasi.ResumeLayout(false);
            this.tpRegistrasi.PerformLayout();
            this.tpEdit.ResumeLayout(false);
            this.tpEdit.PerformLayout();
            this.tpDelete.ResumeLayout(false);
            this.tpDelete.PerformLayout();
            this.tpDaftar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcBarang;
        private System.Windows.Forms.TabPage tpRegistrasi;
        private System.Windows.Forms.TabPage tpEdit;
        private System.Windows.Forms.TabPage tpDelete;
        private System.Windows.Forms.TabPage tpDaftar;
        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.Button reg_btn_keluar;
        private System.Windows.Forms.Button reg_btn_cancel;
        private System.Windows.Forms.Button reg_btn_simpan;
        private System.Windows.Forms.TextBox reg_txt_HargaJual;
        private System.Windows.Forms.TextBox reg_txt_HargaHPP;
        private System.Windows.Forms.TextBox reg_txt_Jlhawal;
        private System.Windows.Forms.TextBox reg_txt_Nama;
        private System.Windows.Forms.TextBox reg_txt_Kode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button edit_btn_Cari;
        private System.Windows.Forms.Button edit_btn_Keluar;
        private System.Windows.Forms.Button edit_btn_Cancel;
        private System.Windows.Forms.Button edit_btn_Simpan;
        private System.Windows.Forms.TextBox edit_txt_HargaJual;
        private System.Windows.Forms.TextBox edit_txt_HargaHPP;
        private System.Windows.Forms.TextBox edit_txt_Jlhawal;
        private System.Windows.Forms.TextBox edit_txt_Nama;
        private System.Windows.Forms.TextBox edit_txt_Kode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button del_btn_Cari;
        private System.Windows.Forms.Button del_btn_Keluar;
        private System.Windows.Forms.Button del_btn_Cancel;
        private System.Windows.Forms.Button del_btn_Delete;
        private System.Windows.Forms.TextBox del_txt_HargaJual;
        private System.Windows.Forms.TextBox del_txt_HargaHPP;
        private System.Windows.Forms.TextBox del_txt_Jlhawal;
        private System.Windows.Forms.TextBox del_txt_Nama;
        private System.Windows.Forms.TextBox del_txt_Kode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button edit_btn_Check;
        private System.Windows.Forms.Button del_btn_Check;
        private System.Windows.Forms.TextBox edit_txt_ID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox del_txt_ID;
        private System.Windows.Forms.Label label17;
    }
}