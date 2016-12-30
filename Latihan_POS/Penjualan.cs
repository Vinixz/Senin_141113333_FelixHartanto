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
    public partial class Penjualan : Form
    {
        
        DataTable dtList; 
        DataTable dtList_Detail;
        DataTable dtEditDetailList;
        
        clsBarang[] cart = new clsBarang[0];
        clsBarang cart_temp;
        clsCustomer cust_temp;
        decimal cart_price = 0;
        public Penjualan()
        {
            InitializeComponent();
        }

        private void tcPenjualan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tcPenjualan.SelectedTab == tpDaftar)
                {
                    dtList.Clear();
                    clsPenjualan.SelectAll().Fill(dtList);
                }
                //isCari(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Penjualan_Load(object sender, EventArgs e)
        {
            dtList = new DataTable();
            BindingSource bsMaster = new BindingSource();
            bsMaster.DataSource = dtList;
            dgvList.DataSource = bsMaster;

            dtList_Detail = new DataTable();
            BindingSource bsDetail = new BindingSource();
            bsDetail.DataSource = dtList_Detail;
            dgvList_Detail.DataSource = bsDetail;

            /*
            dtEditDetailList = new DataTable();
            BindingSource bsDetail_List = new BindingSource();
            bsDetail_List.DataSource = dtEditDetailList;
            dgvEditDetailList.DataSource = bsDetail_List;
            */

            dgvPenjualan.ColumnCount = 5;
            dgvPenjualan.Columns[0].Name = "ID";
            dgvPenjualan.Columns[1].Name = "Nama Barang";
            dgvPenjualan.Columns[2].Name = "Harga Barang";
            dgvPenjualan.Columns[3].Name = "Jumlah Barang";
            dgvPenjualan.Columns[4].Name = "Total";
            dgvPenjualan.Enabled = false;
            
            /*
            dgvPenjualan.ColumnCount = 3;
            dgvPenjualan.Columns[0].Name = "Product ID";
            dgvPenjualan.Columns[1].Name = "Product Name";
            dgvPenjualan.Columns[2].Name = "Product Price";

            string[] row = new string[] { "1", "Product 1", "1000" };
            dgvPenjualan.Rows.Add(row);
            row = new string[] { "2", "Product 2", "2000" };
            dgvPenjualan.Rows.Add(row);
            row = new string[] { "3", "Product 3", "3000" };
            dgvPenjualan.Rows.Add(row);
            row = new string[] { "4", "Product 4", "4000" };
            dgvPenjualan.Rows.Add(row);
            */        
        }

        private void btn_brg_Keluar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    txt_brg_Harga.Text = res.harga_jual.ToString();
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

        private void btn_brg_Reset_Click(object sender, EventArgs e)
        {
            foreach (Control i in tpJual.Controls)
            {
                if (i is TextBox)
                {
                    (i as TextBox).Clear();
                }
                else if (i is DataGridView)
                {
                    (i as DataGridView).Rows.Clear();
                }
            }
        }

        private void btn_brg_Tambah_Click(object sender, EventArgs e)
        {
            cart_temp = clsBarang.SearchKode(txt_brg_Kode.Text);

            if(cart_temp.jumlah > Convert.ToInt32(txt_brg_Jumlah.Text)){
                DataGridViewRow row = (DataGridViewRow)dgvPenjualan.Rows[0].Clone();
                row.Cells[0].Value = txt_brg_Kode.Text;
                row.Cells[1].Value = txt_brg_Nama.Text;
                row.Cells[2].Value = txt_brg_Harga.Text;
                row.Cells[3].Value = txt_brg_Jumlah.Text;
                row.Cells[4].Value = (Convert.ToDecimal(txt_brg_Harga.Text) * Convert.ToInt32(txt_brg_Jumlah.Text)).ToString();
             
                dgvPenjualan.Rows.Add(row);
                cart_price += Convert.ToDecimal(txt_brg_Harga.Text) * Convert.ToInt32(txt_brg_Jumlah.Text);
                txt_TotalHarga.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(cart_price.ToString()));

            
                if (cart_temp != null)
                {
                    Array.Resize<clsBarang>(ref cart, cart.Length + 1);
                    cart[cart.Length - 1] = cart_temp;
                }
            }
            else{
                MessageBox.Show("Barang tidak mencukupi","Error");
            }
        }

        private void btn_cust_Check_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cust_ID.Text.Trim().Length == 0)
                {
                    throw new Exception("Input field tidak boleh kosong");
                }
                clsCustomer res = clsCustomer.Search(txt_cust_ID.Text);
                if (res != null)
                {
                    txt_cust_Nama.Text = res.nama;
                }
                else
                {
                    MessageBox.Show("Customer tidak ditemukan", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btn_brg_add_Click(object sender, EventArgs e)
        {
            cust_temp = clsCustomer.Search(txt_cust_ID.Text);
            try
            {
                clsPenjualan jual_brg = new clsPenjualan(Convert.ToInt32(txt_brg_KodeJual.Text),cust_temp, Convert.ToDecimal(cart_price), DateTime.Now, DateTime.Now);

                int res = jual_brg.Insert();


                int[] qty = new int[0];
                decimal[] total_hrg_brg = new decimal[0];
                foreach (DataGridViewRow i in dgvPenjualan.Rows)
                {
                    Array.Resize(ref qty, qty.Length + 1);
                    qty[qty.Length - 1] = Convert.ToInt32(i.Cells[3].Value);

                    Array.Resize(ref total_hrg_brg, total_hrg_brg.Length + 1);
                    total_hrg_brg[total_hrg_brg.Length - 1] = Convert.ToDecimal(i.Cells[4].Value);
                }

                clsPenjualan_Detail jual_brg_detail = new clsPenjualan_Detail();
                int no = 0;
                int stok_baru;
                foreach(clsBarang i in cart){
                    jual_brg_detail = new clsPenjualan_Detail(jual_brg, i, qty[no], total_hrg_brg[no]);
                    res = jual_brg_detail.Insert();

                    stok_baru = i.jumlah - qty[no];
                    i.set_Jumlah(stok_baru);
                    i.Update();


                    no++;
                }
                MessageBox.Show(res + " produk barang telah berhasil dijual", "Saved");
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
                clsPenjualan_Detail.SelectByID(Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[1].Value)).Fill(dtList_Detail);
            }
            
        }

        
        

        
    }
}
