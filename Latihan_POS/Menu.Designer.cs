namespace Latihan_POS
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BarangtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomertoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuppliertoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransaksitoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembeliantoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BarangtoolStripMenuItem,
            this.CustomertoolStripMenuItem,
            this.SuppliertoolStripMenuItem,
            this.TransaksitoolStripMenuItem,
            this.exitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // BarangtoolStripMenuItem
            // 
            this.BarangtoolStripMenuItem.Name = "BarangtoolStripMenuItem";
            this.BarangtoolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.BarangtoolStripMenuItem.Text = "Barang";
            this.BarangtoolStripMenuItem.Click += new System.EventHandler(this.BarangtoolStripMenuItem_Click);
            // 
            // CustomertoolStripMenuItem
            // 
            this.CustomertoolStripMenuItem.Name = "CustomertoolStripMenuItem";
            this.CustomertoolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.CustomertoolStripMenuItem.Text = "Customer";
            this.CustomertoolStripMenuItem.Click += new System.EventHandler(this.CustomertoolStripMenuItem_Click);
            // 
            // SuppliertoolStripMenuItem
            // 
            this.SuppliertoolStripMenuItem.Name = "SuppliertoolStripMenuItem";
            this.SuppliertoolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.SuppliertoolStripMenuItem.Text = "Supplier";
            this.SuppliertoolStripMenuItem.Click += new System.EventHandler(this.SuppliertoolStripMenuItem_Click);
            // 
            // TransaksitoolStripMenuItem
            // 
            this.TransaksitoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pembeliantoolStripMenuItem,
            this.penjualanToolStripMenuItem});
            this.TransaksitoolStripMenuItem.Name = "TransaksitoolStripMenuItem";
            this.TransaksitoolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.TransaksitoolStripMenuItem.Text = "Transaksi";
            // 
            // pembeliantoolStripMenuItem
            // 
            this.pembeliantoolStripMenuItem.Name = "pembeliantoolStripMenuItem";
            this.pembeliantoolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.pembeliantoolStripMenuItem.Text = "Pembelian";
            this.pembeliantoolStripMenuItem.Click += new System.EventHandler(this.pembeliantoolStripMenuItem_Click);
            // 
            // penjualanToolStripMenuItem
            // 
            this.penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
            this.penjualanToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.penjualanToolStripMenuItem.Text = "Penjualan";
            this.penjualanToolStripMenuItem.Click += new System.EventHandler(this.penjualanToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 684);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "POS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BarangtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomertoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SuppliertoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransaksitoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembeliantoolStripMenuItem;
    }
}

