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
    public partial class Pembelian : Form
    {

        DataTable dtList;
        DataTable dtList_Detail;
        DataTable dtEditDetailList;



        clsBarang[] cart = new clsBarang[0];
        clsBarang cart_temp;
        clsSupplier supp_temp;
        decimal cart_price = 0;

        public Pembelian()
        {
            InitializeComponent();
        }

        private void tcPembelian_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tcPembelian.SelectedTab == tpDaftar)
                {
                    dtList.Clear();
                    clsPembelian.SelectAll().Fill(dtList);
                }
                //isCari(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Pembelian_Load(object sender, EventArgs e)
        {
            dtList = new DataTable();
            BindingSource bsMaster = new BindingSource();
            bsMaster.DataSource = dtList;
            dgvList.DataSource = bsMaster;

            dtList_Detail = new DataTable();
            BindingSource bsDetail = new BindingSource();
            bsDetail.DataSource = dtList_Detail;
            dgvList_Detail.DataSource = bsDetail;



            dgvPembelian.ColumnCount = 5;
            dgvPembelian.Columns[0].Name = "ID";
            dgvPembelian.Columns[1].Name = "Nama Barang";
            dgvPembelian.Columns[2].Name = "Harga Barang";
            dgvPembelian.Columns[3].Name = "Jumlah Barang";
            dgvPembelian.Columns[4].Name = "Total";
            dgvPembelian.Enabled = false;
        }

        private void btn_brg_Check_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_brg_Kode.Text.Trim().Length == 0)
                {
                    throw new Exception("Input field tidak boleh kosong");
                }
                clsBarang res = clsBarang.SearchKode(txt_brg_Kode.Text);
                if (res != null)
                {
                    txt_brg_Nama.Text = res.nama;
                    txt_brg_Harga.Text = res.harga_hpp.ToString();
                }
                else
                {
                    MessageBox.Show("Produk tidak ditemukan", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btn_cust_Check_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_supp_ID.Text.Trim().Length == 0)
                {
                    throw new Exception("Input field tidak boleh kosong");
                }
                clsSupplier res = clsSupplier.Search(txt_supp_ID.Text);
                if (res != null)
                {
                    txt_supp_Nama.Text = res.nama;
                }
                else
                {
                    MessageBox.Show("Supplier tidak ditemukan", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btn_brg_Tambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_brg_Jumlah.Text.Trim().Length == 0 || txt_brg_Nama.Text.Trim().Length == 0)
                {
                    throw new Exception("Input Nama dan Jumlah Barang tidak boleh kosong");
                }
                cart_temp = clsBarang.SearchKode(txt_brg_Kode.Text);

                if (cart_temp.jumlah > Convert.ToInt32(txt_brg_Jumlah.Text))
                {
                    DataGridViewRow row = (DataGridViewRow)dgvPembelian.Rows[0].Clone();
                    row.Cells[0].Value = txt_brg_Kode.Text;
                    row.Cells[1].Value = txt_brg_Nama.Text;
                    row.Cells[2].Value = txt_brg_Harga.Text;
                    row.Cells[3].Value = txt_brg_Jumlah.Text;
                    row.Cells[4].Value = (Convert.ToDecimal(txt_brg_Harga.Text) * Convert.ToInt32(txt_brg_Jumlah.Text)).ToString();

                    dgvPembelian.Rows.Add(row);
                    cart_price += Convert.ToDecimal(txt_brg_Harga.Text) * Convert.ToInt32(txt_brg_Jumlah.Text);
                    txt_TotalHarga.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(cart_price.ToString()));

                    cart_temp = clsBarang.SearchKode(txt_brg_Kode.Text);
                    if (cart_temp != null)
                    {
                        Array.Resize<clsBarang>(ref cart, cart.Length + 1);
                        cart[cart.Length - 1] = cart_temp;
                    }
                }
                else
                {
                    MessageBox.Show("Barang tidak mencukupi", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btn_brg_Reset_Click(object sender, EventArgs e)
        {
            foreach (Control i in tpBeli.Controls)
            {
                if(i is TextBox) {
                    (i as TextBox).Clear();
                }
                else if (i is DataGridView)
                {
                    (i as DataGridView).Rows.Clear();
                }
            }
        }

        private void btn_brg_Keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_brg_add_Click(object sender, EventArgs e)
        {
            supp_temp = clsSupplier.Search(txt_supp_ID.Text);
            try
            {
                if (txt_supp_Nama.Text.Trim().Length == 0 || txt_brg_KodeBeli.Text.Trim().Length == 0)
                {
                    throw new Exception("Input ID dan Nama Customer tidak boleh kosong");
                }
                clsPembelian beli_brg = new clsPembelian(Convert.ToInt32(txt_brg_KodeBeli.Text), supp_temp, Convert.ToDecimal(cart_price), DateTime.Now, DateTime.Now);

                int res = beli_brg.Insert();


                int[] qty = new int[0];
                decimal[] total_hrg_brg = new decimal[0];
                foreach (DataGridViewRow i in dgvPembelian.Rows)
                {
                    Array.Resize(ref qty, qty.Length + 1);
                    qty[qty.Length - 1] = Convert.ToInt32(i.Cells[3].Value);

                    Array.Resize(ref total_hrg_brg, total_hrg_brg.Length + 1);
                    total_hrg_brg[total_hrg_brg.Length - 1] = Convert.ToDecimal(i.Cells[4].Value);
                }

                clsPembelian_Detail beli_brg_detail = new clsPembelian_Detail();
                int no = 0;
                int stok_baru;
                foreach (clsBarang i in cart)
                {
                    beli_brg_detail = new clsPembelian_Detail(beli_brg, i, qty[no], total_hrg_brg[no]);
                    res = beli_brg_detail.Insert();

                    stok_baru = i.jumlah + qty[no];
                    i.set_Jumlah(stok_baru);
                    i.Update();
                    no++;

                }
                MessageBox.Show("produk barang telah berhasil dibeli", "Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvList.Rows[e.RowIndex].Cells[1].Value.ToString() != "")
            {
                dtList_Detail.Clear();
                clsPembelian_Detail.SelectByID(Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[1].Value)).Fill(dtList_Detail);
            }
        }

        private void txt_supp_ID_TextChanged(object sender, EventArgs e)
        {
            txt_supp_Nama.Text = "";
        }

        private void txt_brg_Kode_TextChanged(object sender, EventArgs e)
        {
            txt_brg_Nama.Text = "";
            txt_brg_Harga.Text = "";
            txt_brg_Jumlah.Text = "";
        }

        

        
    }
}
