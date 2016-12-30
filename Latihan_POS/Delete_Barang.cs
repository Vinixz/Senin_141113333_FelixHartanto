using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    public partial class Delete_Barang : Form
    {
        public Delete_Barang()
        {
            InitializeComponent();
        }

        private void Delete_Barang_Load(object sender, EventArgs e)
        {
            txt_Nama.Enabled = false;
            txt_Jlhawal.Enabled = false;
            txt_HargaHPP.Enabled = false;
            txt_HargaJual.Enabled = false;
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            String str = "Server=localhost;Database=latihan_pos;Uid=root;Pwd=;";
            MySqlConnection con = new MySqlConnection(str);

            try
            {
                string query = "SELECT Kode, Nama, JumlahAwal, HargaHPP, HargaJual FROM barang where Kode = " + txt_Kode.Text;
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, con);
                //Create a data reader and Execute the command
                con.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    txt_Nama.Text = dataReader["Nama"].ToString();
                    txt_Jlhawal.Text = dataReader["JumlahAwal"].ToString();
                    txt_HargaHPP.Text = dataReader["HargaHPP"].ToString();
                    txt_HargaJual.Text = dataReader["HargaJual"].ToString();
                }

                //close Data Reader
                //dataReader.Close();

                //close Connection
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

    }
}
