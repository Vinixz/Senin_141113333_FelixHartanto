using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Daftar_Barang daftar_barang;

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            daftar_barang = new Daftar_Barang();
            daftar_barang.MdiParent = this;
            //f2 += new FormClosedEventArgs(f2_FormClosed);
           // f2.FormClosed += f2_FormClosed;
            daftar_barang.Show();
            
            /*if (f2Color != null)
            {
                daftar_barang.cbxBackgroundColor.Text = f2Color;
            }*/
        }
    }
}
