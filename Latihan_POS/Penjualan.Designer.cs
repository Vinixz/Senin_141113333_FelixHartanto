namespace Latihan_POS
{
    partial class Penjualan
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
            this.tpDaftar = new System.Windows.Forms.TabPage();
            this.dgvList_Detail = new System.Windows.Forms.DataGridView();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.tpJual = new System.Windows.Forms.TabPage();
            this.txt_brg_KodeJual = new System.Windows.Forms.TextBox();
            this.txt_TotalHarga = new System.Windows.Forms.TextBox();
            this.txt_cust_Nama = new System.Windows.Forms.TextBox();
            this.txt_brg_Kode = new System.Windows.Forms.TextBox();
            this.txt_brg_Nama = new System.Windows.Forms.TextBox();
            this.txt_brg_Harga = new System.Windows.Forms.TextBox();
            this.txt_brg_Jumlah = new System.Windows.Forms.TextBox();
            this.txt_cust_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_brg_add = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvPenjualan = new System.Windows.Forms.DataGridView();
            this.btn_cust_Check = new System.Windows.Forms.Button();
            this.btn_brg_Check = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_brg_Keluar = new System.Windows.Forms.Button();
            this.btn_brg_Reset = new System.Windows.Forms.Button();
            this.btn_brg_Tambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tcPenjualan = new System.Windows.Forms.TabControl();
            this.tpDaftar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList_Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.tpJual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualan)).BeginInit();
            this.tcPenjualan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpDaftar
            // 
            this.tpDaftar.Controls.Add(this.dgvList_Detail);
            this.tpDaftar.Controls.Add(this.dgvList);
            this.tpDaftar.Location = new System.Drawing.Point(4, 25);
            this.tpDaftar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDaftar.Name = "tpDaftar";
            this.tpDaftar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDaftar.Size = new System.Drawing.Size(815, 549);
            this.tpDaftar.TabIndex = 1;
            this.tpDaftar.Text = "Daftar";
            this.tpDaftar.UseVisualStyleBackColor = true;
            // 
            // dgvList_Detail
            // 
            this.dgvList_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList_Detail.Location = new System.Drawing.Point(8, 250);
            this.dgvList_Detail.Name = "dgvList_Detail";
            this.dgvList_Detail.Size = new System.Drawing.Size(801, 248);
            this.dgvList_Detail.TabIndex = 1;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(8, 5);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(801, 216);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // tpJual
            // 
            this.tpJual.Controls.Add(this.txt_brg_KodeJual);
            this.tpJual.Controls.Add(this.txt_TotalHarga);
            this.tpJual.Controls.Add(this.txt_cust_Nama);
            this.tpJual.Controls.Add(this.txt_brg_Kode);
            this.tpJual.Controls.Add(this.txt_brg_Nama);
            this.tpJual.Controls.Add(this.txt_brg_Harga);
            this.tpJual.Controls.Add(this.txt_brg_Jumlah);
            this.tpJual.Controls.Add(this.txt_cust_ID);
            this.tpJual.Controls.Add(this.label2);
            this.tpJual.Controls.Add(this.btn_brg_add);
            this.tpJual.Controls.Add(this.label16);
            this.tpJual.Controls.Add(this.dgvPenjualan);
            this.tpJual.Controls.Add(this.btn_cust_Check);
            this.tpJual.Controls.Add(this.btn_brg_Check);
            this.tpJual.Controls.Add(this.label9);
            this.tpJual.Controls.Add(this.label10);
            this.tpJual.Controls.Add(this.label11);
            this.tpJual.Controls.Add(this.label12);
            this.tpJual.Controls.Add(this.btn_brg_Keluar);
            this.tpJual.Controls.Add(this.btn_brg_Reset);
            this.tpJual.Controls.Add(this.btn_brg_Tambah);
            this.tpJual.Controls.Add(this.label1);
            this.tpJual.Controls.Add(this.label8);
            this.tpJual.Location = new System.Drawing.Point(4, 25);
            this.tpJual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpJual.Name = "tpJual";
            this.tpJual.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpJual.Size = new System.Drawing.Size(815, 549);
            this.tpJual.TabIndex = 0;
            this.tpJual.Text = "Jual";
            this.tpJual.UseVisualStyleBackColor = true;
            // 
            // txt_brg_KodeJual
            // 
            this.txt_brg_KodeJual.Location = new System.Drawing.Point(79, 515);
            this.txt_brg_KodeJual.Name = "txt_brg_KodeJual";
            this.txt_brg_KodeJual.Size = new System.Drawing.Size(100, 22);
            this.txt_brg_KodeJual.TabIndex = 46;
            // 
            // txt_TotalHarga
            // 
            this.txt_TotalHarga.Enabled = false;
            this.txt_TotalHarga.Location = new System.Drawing.Point(658, 511);
            this.txt_TotalHarga.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TotalHarga.Name = "txt_TotalHarga";
            this.txt_TotalHarga.Size = new System.Drawing.Size(132, 22);
            this.txt_TotalHarga.TabIndex = 43;
            // 
            // txt_cust_Nama
            // 
            this.txt_cust_Nama.Enabled = false;
            this.txt_cust_Nama.Location = new System.Drawing.Point(77, 75);
            this.txt_cust_Nama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cust_Nama.Name = "txt_cust_Nama";
            this.txt_cust_Nama.Size = new System.Drawing.Size(132, 22);
            this.txt_cust_Nama.TabIndex = 39;
            // 
            // txt_brg_Kode
            // 
            this.txt_brg_Kode.Location = new System.Drawing.Point(434, 30);
            this.txt_brg_Kode.Margin = new System.Windows.Forms.Padding(4);
            this.txt_brg_Kode.Name = "txt_brg_Kode";
            this.txt_brg_Kode.Size = new System.Drawing.Size(132, 22);
            this.txt_brg_Kode.TabIndex = 29;
            // 
            // txt_brg_Nama
            // 
            this.txt_brg_Nama.Enabled = false;
            this.txt_brg_Nama.Location = new System.Drawing.Point(434, 74);
            this.txt_brg_Nama.Margin = new System.Windows.Forms.Padding(4);
            this.txt_brg_Nama.Name = "txt_brg_Nama";
            this.txt_brg_Nama.Size = new System.Drawing.Size(132, 22);
            this.txt_brg_Nama.TabIndex = 30;
            // 
            // txt_brg_Harga
            // 
            this.txt_brg_Harga.Enabled = false;
            this.txt_brg_Harga.Location = new System.Drawing.Point(434, 119);
            this.txt_brg_Harga.Margin = new System.Windows.Forms.Padding(4);
            this.txt_brg_Harga.Name = "txt_brg_Harga";
            this.txt_brg_Harga.Size = new System.Drawing.Size(132, 22);
            this.txt_brg_Harga.TabIndex = 31;
            // 
            // txt_brg_Jumlah
            // 
            this.txt_brg_Jumlah.Location = new System.Drawing.Point(434, 164);
            this.txt_brg_Jumlah.Margin = new System.Windows.Forms.Padding(4);
            this.txt_brg_Jumlah.Name = "txt_brg_Jumlah";
            this.txt_brg_Jumlah.Size = new System.Drawing.Size(132, 22);
            this.txt_brg_Jumlah.TabIndex = 32;
            // 
            // txt_cust_ID
            // 
            this.txt_cust_ID.Location = new System.Drawing.Point(77, 32);
            this.txt_cust_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cust_ID.Name = "txt_cust_ID";
            this.txt_cust_ID.Size = new System.Drawing.Size(132, 22);
            this.txt_cust_ID.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Kode";
            // 
            // btn_brg_add
            // 
            this.btn_brg_add.Location = new System.Drawing.Point(214, 511);
            this.btn_brg_add.Name = "btn_brg_add";
            this.btn_brg_add.Size = new System.Drawing.Size(75, 30);
            this.btn_brg_add.TabIndex = 44;
            this.btn_brg_add.Text = "Add";
            this.btn_brg_add.UseVisualStyleBackColor = true;
            this.btn_brg_add.Click += new System.EventHandler(this.btn_brg_add_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(553, 514);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 16);
            this.label16.TabIndex = 42;
            this.label16.Text = "Total Harga";
            // 
            // dgvPenjualan
            // 
            this.dgvPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenjualan.Location = new System.Drawing.Point(22, 247);
            this.dgvPenjualan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPenjualan.Name = "dgvPenjualan";
            this.dgvPenjualan.Size = new System.Drawing.Size(767, 258);
            this.dgvPenjualan.TabIndex = 14;
            // 
            // btn_cust_Check
            // 
            this.btn_cust_Check.Location = new System.Drawing.Point(238, 28);
            this.btn_cust_Check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cust_Check.Name = "btn_cust_Check";
            this.btn_cust_Check.Size = new System.Drawing.Size(76, 29);
            this.btn_cust_Check.TabIndex = 41;
            this.btn_cust_Check.Text = "Check";
            this.btn_cust_Check.UseVisualStyleBackColor = true;
            this.btn_cust_Check.Click += new System.EventHandler(this.btn_cust_Check_Click);
            // 
            // btn_brg_Check
            // 
            this.btn_brg_Check.Location = new System.Drawing.Point(604, 26);
            this.btn_brg_Check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_brg_Check.Name = "btn_brg_Check";
            this.btn_brg_Check.Size = new System.Drawing.Size(76, 29);
            this.btn_brg_Check.TabIndex = 38;
            this.btn_brg_Check.Text = "Check";
            this.btn_brg_Check.UseVisualStyleBackColor = true;
            this.btn_brg_Check.Click += new System.EventHandler(this.btn_brg_Check_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Kode";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(430, 144);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Jumlah";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(430, 99);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Harga";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(430, 54);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Nama Barang";
            // 
            // btn_brg_Keluar
            // 
            this.btn_brg_Keluar.Location = new System.Drawing.Point(604, 205);
            this.btn_brg_Keluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_brg_Keluar.Name = "btn_brg_Keluar";
            this.btn_brg_Keluar.Size = new System.Drawing.Size(76, 29);
            this.btn_brg_Keluar.TabIndex = 36;
            this.btn_brg_Keluar.Text = "Keluar";
            this.btn_brg_Keluar.UseVisualStyleBackColor = true;
            this.btn_brg_Keluar.Click += new System.EventHandler(this.btn_brg_Keluar_Click);
            // 
            // btn_brg_Reset
            // 
            this.btn_brg_Reset.Location = new System.Drawing.Point(604, 160);
            this.btn_brg_Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_brg_Reset.Name = "btn_brg_Reset";
            this.btn_brg_Reset.Size = new System.Drawing.Size(76, 29);
            this.btn_brg_Reset.TabIndex = 35;
            this.btn_brg_Reset.Text = "Reset";
            this.btn_brg_Reset.UseVisualStyleBackColor = true;
            this.btn_brg_Reset.Click += new System.EventHandler(this.btn_brg_Reset_Click);
            // 
            // btn_brg_Tambah
            // 
            this.btn_brg_Tambah.Location = new System.Drawing.Point(604, 115);
            this.btn_brg_Tambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_brg_Tambah.Name = "btn_brg_Tambah";
            this.btn_brg_Tambah.Size = new System.Drawing.Size(76, 29);
            this.btn_brg_Tambah.TabIndex = 34;
            this.btn_brg_Tambah.Text = "Tambah";
            this.btn_brg_Tambah.UseVisualStyleBackColor = true;
            this.btn_brg_Tambah.Click += new System.EventHandler(this.btn_brg_Tambah_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nama Customer";
            // 
            // tcPenjualan
            // 
            this.tcPenjualan.Controls.Add(this.tpJual);
            this.tcPenjualan.Controls.Add(this.tpDaftar);
            this.tcPenjualan.Location = new System.Drawing.Point(0, 1);
            this.tcPenjualan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcPenjualan.Name = "tcPenjualan";
            this.tcPenjualan.SelectedIndex = 0;
            this.tcPenjualan.Size = new System.Drawing.Size(823, 578);
            this.tcPenjualan.TabIndex = 24;
            this.tcPenjualan.SelectedIndexChanged += new System.EventHandler(this.tcPenjualan_SelectedIndexChanged);
            // 
            // Penjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 588);
            this.Controls.Add(this.tcPenjualan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Penjualan";
            this.Text = "Penjualan";
            this.Load += new System.EventHandler(this.Penjualan_Load);
            this.tpDaftar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList_Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.tpJual.ResumeLayout(false);
            this.tpJual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualan)).EndInit();
            this.tcPenjualan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpDaftar;
        private System.Windows.Forms.DataGridView dgvList_Detail;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.TabPage tpJual;
        private System.Windows.Forms.TextBox txt_brg_KodeJual;
        private System.Windows.Forms.TextBox txt_TotalHarga;
        private System.Windows.Forms.TextBox txt_cust_Nama;
        private System.Windows.Forms.TextBox txt_brg_Kode;
        private System.Windows.Forms.TextBox txt_brg_Nama;
        private System.Windows.Forms.TextBox txt_brg_Harga;
        private System.Windows.Forms.TextBox txt_brg_Jumlah;
        private System.Windows.Forms.TextBox txt_cust_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_brg_add;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvPenjualan;
        private System.Windows.Forms.Button btn_cust_Check;
        private System.Windows.Forms.Button btn_brg_Check;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_brg_Keluar;
        private System.Windows.Forms.Button btn_brg_Reset;
        private System.Windows.Forms.Button btn_brg_Tambah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tcPenjualan;

    }
}