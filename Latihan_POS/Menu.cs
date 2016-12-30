using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Latihan_POS.Class;

namespace Latihan_POS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Registrasi_Barang daftar_barang;
        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
                        //daftar_barang = new Registrasi_Barang();
                        //daftar_barang.MdiParent = this;
            //f2 += new FormClosedEventArgs(f2_FormClosed);
           // f2.FormClosed += f2_FormClosed;
                        //daftar_barang.Show();
            
            /*if (f2Color != null)
            {
                daftar_barang.cbxBackgroundColor.Text = f2Color;
            }*/
       
        }

        Barang barang;
        private void BarangtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            barang = new Barang();
            barang.MdiParent = this;
            barang.Show();
        }

        Customer customer;
        private void CustomertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer = new Customer();
            customer.MdiParent = this;
            customer.Show();
        }

        Supplier supplier;
        private void SuppliertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplier = new Supplier();
            supplier.MdiParent = this;
            supplier.Show();
        }

        Penjualan penjualan;
        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            penjualan = new Penjualan();
            penjualan.MdiParent = this;
            penjualan.Show();
        }

        Pembelian pembelian;
        private void pembeliantoolStripMenuItem_Click(object sender, EventArgs e)
        {
            pembelian = new Pembelian();
            pembelian.MdiParent = this;
            pembelian.Show();
        }

    }
}
