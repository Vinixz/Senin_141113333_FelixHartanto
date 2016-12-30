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
    public partial class Barang : Form
    {
        DataTable dtBarang;
        clsBarang brg_temp;
        bool isEdit = false;
        bool isDelete = false;

        public Barang()
        {
            InitializeComponent();
        }

        private void Barang_Load(object sender, EventArgs e)
        {
            dtBarang = new DataTable();
            BindingSource bsBarang = new BindingSource();
            bsBarang.DataSource = dtBarang;
            dgvBarang.DataSource = bsBarang;
        }

        public void isCari(bool a)
        {
            isEdit = a;
            isDelete = a;
        }

        private void tcBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tcBarang.SelectedTab == tpDaftar)
                {
                    dtBarang.Clear();
                    clsBarang.SelectAll().Fill(dtBarang);
                }
                isCari(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }


        //====BARANG_REGISTRASI===============================================================================
        private void reg_btn_simpan_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control i in tpRegistrasi.Controls)
                {
                    if (i is TextBox && ((i as TextBox).Text).Trim().Length == 0)
                    {
                        throw new Exception("Input field tidak boleh kosong");
                    }
                }
                clsBarang barangBaru = new clsBarang(reg_txt_Kode.Text, reg_txt_Nama.Text, Convert.ToInt32(reg_txt_Jlhawal.Text), Convert.ToDecimal(reg_txt_HargaHPP.Text), Convert.ToDecimal(reg_txt_HargaJual.Text), DateTime.Now, DateTime.Now);
                int res = barangBaru.Insert();
                MessageBox.Show("barang telah berhasil ditambahkan", "Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void reg_btn_cancel_Click(object sender, EventArgs e)
        {
            foreach (Control i in (sender as Button).Parent.Controls)
            {
                if (i is TextBox)
                {
                    (i as TextBox).Clear();
                }
            }
           
        }

        private void reg_btn_keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //==============================================================================================
      
        //====BARANG_EDIT===============================================================================
        private void edit_btn_Cari_Click(object sender, EventArgs e)
        {
            tcBarang.SelectedTab = tpDaftar;
            isEdit = true;
        }

        private void edit_btn_Check_Click(object sender, EventArgs e)
        {
            try
            {
                if (edit_txt_ID.Text.Trim().Length == 0)
                {
                    throw new Exception("Input ID tidak boleh kosong");
                }
                clsBarang res = clsBarang.Search(edit_txt_ID.Text);
                if (res != null)
                {
                    edit_txt_Kode.Text = res.kode;
                    edit_txt_Nama.Text = res.nama;
                    edit_txt_Jlhawal.Text = res.jumlah.ToString();
                    edit_txt_HargaHPP.Text = res.harga_hpp.ToString();
                    edit_txt_HargaJual.Text = res.harga_jual.ToString();
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

        private void edit_btn_Simpan_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control i in tpEdit.Controls)
                {
                    if (i is TextBox && ((i as TextBox).Text).Trim().Length == 0)
                    {
                        throw new Exception("Input field tidak boleh kosong");
                    }
                }

                int res;
                clsBarang barangUpdate = new clsBarang(Convert.ToInt32(edit_txt_ID.Text), edit_txt_Kode.Text, edit_txt_Nama.Text, Convert.ToInt32(edit_txt_Jlhawal.Text), Convert.ToDecimal(edit_txt_HargaHPP.Text), Convert.ToDecimal(edit_txt_HargaJual.Text), DateTime.Now);
                

                res = barangUpdate.Update();
                if (res == 1)
                {
                    MessageBox.Show("barang telah berhasil diubah", "Edited");
                }
                else if (res == 0)
                {
                    MessageBox.Show("Produk tidak ditemukan", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
     
        //=================================================================================================

        //====BARANG_DELETE===============================================================================
        private void del_btn_Cari_Click(object sender, EventArgs e)
        {
            tcBarang.SelectedTab = tpDaftar;
            isDelete = true;
        }

        private void del_btn_Check_Click(object sender, EventArgs e)
        {
            try
            {
                if (del_txt_ID.Text.Trim().Length == 0)
                {
                    throw new Exception("Input ID tidak boleh kosong");
                }
                clsBarang res = clsBarang.Search(del_txt_ID.Text);
                if (res != null)
                {
                    del_txt_Kode.Text = res.kode;
                    del_txt_Nama.Text = res.nama;
                    del_txt_Jlhawal.Text = res.jumlah.ToString();
                    del_txt_HargaHPP.Text = res.harga_hpp.ToString();
                    del_txt_HargaJual.Text = res.harga_jual.ToString();
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

        private void del_btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int res;

                DialogResult rslt;
                rslt = MessageBox.Show("Apakah Anda yakin ?", "Yakin?", MessageBoxButtons.YesNo);

                if (rslt == DialogResult.Yes)
                {
                    clsBarang barangRemove = new clsBarang(Convert.ToInt32(del_txt_ID.Text), del_txt_Kode.Text, del_txt_Nama.Text, Convert.ToInt32(del_txt_Jlhawal.Text), Convert.ToDecimal(del_txt_HargaHPP.Text), Convert.ToDecimal(del_txt_HargaJual.Text), DateTime.Now);
                    res = barangRemove.Delete();
                    MessageBox.Show("barang telah berhasil dihapus", "Deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        //=================================================================================================

        private void dgvBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isEdit)
            {
                tcBarang.SelectedTab = tpEdit;
                edit_txt_ID.Text = dgvBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
                edit_txt_Kode.Text = dgvBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
                edit_txt_Nama.Text = dgvBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
                edit_txt_Jlhawal.Text = dgvBarang.Rows[e.RowIndex].Cells[3].Value.ToString();
                edit_txt_HargaHPP.Text = dgvBarang.Rows[e.RowIndex].Cells[4].Value.ToString();
                edit_txt_HargaJual.Text = dgvBarang.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            else if (isDelete)
            {
                tcBarang.SelectedTab = tpDelete;

                del_txt_ID.Text = dgvBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
                del_txt_Kode.Text = dgvBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
                del_txt_Nama.Text = dgvBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
                del_txt_Jlhawal.Text = dgvBarang.Rows[e.RowIndex].Cells[3].Value.ToString();
                del_txt_HargaHPP.Text = dgvBarang.Rows[e.RowIndex].Cells[4].Value.ToString();
                del_txt_HargaJual.Text = dgvBarang.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
        //=================================================================================================
        

        

        


        
    }
}
