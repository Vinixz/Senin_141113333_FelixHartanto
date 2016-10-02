using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vsbarmin_Scroll(object sender, ScrollEventArgs e)
        {
            if (vsbarmin.Value < vsbarmax.Value)
                vsbarmax.Value = vsbarmin.Value;

            int min, max;
            min = vsbarmin.Maximum - vsbarmin.Value;
            max = vsbarmax.Maximum - vsbarmax.Value;
            DateTime tahun = DateTime.Now;

            lmin.Text = (min).ToString();
            lmax.Text = (max).ToString();


            if (tahun.AddYears(-max) <= dtptanggal.MaxDate)
            {
                dtptanggal.MinDate = tahun.AddYears(-max);
            }
            
            dtptanggal.MaxDate = tahun.AddYears(-min);
            
        }

        private void vsbarmax_Scroll(object sender, ScrollEventArgs e)
        {
            if (vsbarmin.Value < vsbarmax.Value)
                vsbarmin.Value = vsbarmax.Value;

            int min, max;
            min = vsbarmin.Maximum - vsbarmin.Value;
            max = vsbarmax.Maximum - vsbarmax.Value;
            DateTime tahun = DateTime.Now;
            
            lmin.Text = (min).ToString();
            lmax.Text = (max).ToString();

            dtptanggal.MaxDate = tahun.AddYears(-min);
            dtptanggal.MinDate = tahun.AddYears(-max);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int min, max;
            min = vsbarmin.Maximum - vsbarmin.Value;
            max = vsbarmax.Maximum - vsbarmax.Value;
            DateTime tahun = DateTime.Now;
            lmin.Text = (min).ToString();
            lmax.Text = (max).ToString();
            dtptanggal.MaxDate = tahun.AddYears(-min);
            dtptanggal.MinDate = tahun.AddYears(-max);

            tabControl1.SelectedIndex = 1;
        }

        
    }
}
