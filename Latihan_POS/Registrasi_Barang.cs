using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

using System.Collections;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    public partial class Registrasi_Barang : Form
    {
        public Registrasi_Barang()
        {
            InitializeComponent();
        }

        private void Daftar_Barang_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_Kode.Text = "";
            txt_Nama.Text = "";
            txt_Jlhawal.Text = "";
            txt_HargaHPP.Text = "";
            txt_HargaJual.Text = "";

            txt_Kode.Focus();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            String str = "Server=localhost;Database=latihan_pos;Uid=root;Pwd=;";
            MySqlConnection con = new MySqlConnection(str);
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Insert into latihan_pos.barang (Kode, Nama, JumlahAwal, HargaHPP, HargaJual, created_at, updated_at) values (@Kode, @Nama, @JumlahAwal, @HargaHPP, @HargaJual, @created_at, @updated_at)";
            cmd.Parameters.AddWithValue("@Kode", txt_Kode.Text);
            cmd.Parameters.AddWithValue("@Nama", txt_Nama.Text);
            cmd.Parameters.AddWithValue("@JumlahAwal", Convert.ToInt32(txt_Jlhawal.Text));
            cmd.Parameters.AddWithValue("@HargaHPP", Convert.ToDecimal(txt_HargaHPP.Text));
            cmd.Parameters.AddWithValue("@HargaJual", Convert.ToDecimal(txt_HargaJual.Text));
            cmd.Parameters.AddWithValue("@created_at", dt);
            cmd.Parameters.AddWithValue("@updated_at", dt);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                //con.Close();
                MessageBox.Show("Saved");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}