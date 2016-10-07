using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Calendar1.SetCalendarDimensions(2,2);
            Calendar1.ScrollChange = 4;
            NumUpDown1.Maximum = 31;
            NumUpDown1.Minimum = 1;

            DomUpDown1.Items.Add("Januari");
            DomUpDown1.Items.Add("Februari");
            DomUpDown1.Items.Add("Maret");
            DomUpDown1.Items.Add("April");
            DomUpDown1.Items.Add("May");
            DomUpDown1.Items.Add("Juni");
            DomUpDown1.Items.Add("Juli");
            DomUpDown1.Items.Add("Agustus");
            DomUpDown1.Items.Add("September");
            DomUpDown1.Items.Add("Oktober");
            DomUpDown1.Items.Add("November");
            DomUpDown1.Items.Add("Desember");

           
            DateTime libur = new DateTime(2016, 1, 1);
            DateTime tglLahir = new DateTime(2016, 5, 18);
            while (libur.Year == 2016)
            {
                if (libur.DayOfWeek == DayOfWeek.Saturday)
                {
                    Calendar1.AddBoldedDate(libur);
                    libur = libur.AddDays(1);
                }
                else if (libur.DayOfWeek == DayOfWeek.Sunday)
                {
                    Calendar1.AddBoldedDate(libur);
                    libur = libur.AddDays(6);
                }
                else
                {
                    libur = libur.AddDays(1);
                }
            }
            Calendar1.AddAnnuallyBoldedDate(tglLahir);
            Calendar1.UpdateBoldedDates();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            int tgl, bln;
            tgl = Convert.ToInt32(NumUpDown1.Value);
            bln = Convert.ToInt32(DomUpDown1.SelectedIndex) + 1;

            if(((bln == 4 || bln == 6 || bln == 9 || bln == 11) && tgl > 30 ) || (bln == 2 && tgl > 29))
            {
                MessageBox.Show("Invalid Date", "ERROR");
            }
            else{
                DateTime tanggal = new DateTime(2016, bln, tgl);
                Calendar1.AddAnnuallyBoldedDate(tanggal);
                Calendar1.SetDate(tanggal);
                Calendar1.UpdateBoldedDates();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DateTime selecttgl = Calendar1.SelectionRange.Start.Date;
            Calendar1.RemoveAnnuallyBoldedDate(selecttgl);
            Calendar1.UpdateBoldedDates();
        }
    }
}
