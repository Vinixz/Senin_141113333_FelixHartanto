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
    public partial class Supplier : Form
    {
        DataTable dtSupplier;
        clsSupplier supp_temp;
        bool isEdit = false;
        bool isDelete = false;

        public Supplier()
        {
            InitializeComponent();
        }

        public void isCari(bool a)
        {
            isEdit = a;
            isDelete = a;
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            dtSupplier = new DataTable();
            BindingSource bsSupplier = new BindingSource();
            bsSupplier.DataSource = dtSupplier;
            dgvSupplier.DataSource = bsSupplier;
        }

        private void tcSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tcSupplier.SelectedTab == tpDaftar)
                {
                    dtSupplier.Clear();
                    clsSupplier.SelectAll().Fill(dtSupplier);
                }
                isCari(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        //=========================================================================================
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

                clsSupplier supplierBaru = new clsSupplier(reg_txt_Nama.Text, reg_txt_Alamat.Text, reg_txt_ZipCode.Text, reg_txt_NoHP.Text, reg_txt_Email.Text, DateTime.Now, DateTime.Now);

                int res = supplierBaru.Insert();
                MessageBox.Show("supplier telah berhasil ditambahkan", "Saved");
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
        //=========================================================================================


        //=========================================================================================
        private void edit_btn_Cari_Click(object sender, EventArgs e)
        {
            tcSupplier.SelectedTab = tpDaftar;
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
                clsSupplier res = clsSupplier.Search(edit_txt_ID.Text);
                if (res != null)
                {
                    edit_txt_Nama.Text = res.nama;
                    edit_txt_Alamat.Text = res.alamat;
                    edit_txt_ZipCode.Text = res.zip_code;
                    edit_txt_NoHP.Text = res.phone_number;
                    edit_txt_Email.Text = res.email;
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
                clsSupplier supplierUpdate = new clsSupplier(Convert.ToInt32(edit_txt_ID.Text), edit_txt_Nama.Text, edit_txt_Alamat.Text, edit_txt_ZipCode.Text, edit_txt_NoHP.Text, edit_txt_Email.Text, DateTime.Now);

                res = supplierUpdate.Update();
                if (res == 1)
                {
                    MessageBox.Show("supplier telah berhasil diubah", "Edited");
                }
                else if (res == 0)
                {
                    MessageBox.Show("Supplier tidak ditemukan", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        //=========================================================================================


        //=========================================================================================
        private void del_btn_Cari_Click(object sender, EventArgs e)
        {
            tcSupplier.SelectedTab = tpDaftar;
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
                clsSupplier res = clsSupplier.Search(del_txt_ID.Text);
                if (res != null)
                {
                    del_txt_Nama.Text = res.nama;
                    del_txt_Alamat.Text = res.alamat;
                    del_txt_ZipCode.Text = res.zip_code;
                    del_txt_NoHP.Text = res.phone_number;
                    del_txt_Email.Text = res.email;
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

        private void del_btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int res;

                DialogResult rslt;
                rslt = MessageBox.Show("Apakah Anda yakin ?", "Yakin?", MessageBoxButtons.YesNo);

                if (rslt == DialogResult.Yes)
                {
                    clsSupplier supplierRemove = new clsSupplier(Convert.ToInt32(del_txt_ID.Text));
                    res = supplierRemove.Delete();
                    MessageBox.Show(res + " supplier telah berhasil dihapus", "Deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        //=========================================================================================


        //=========================================================================================
        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isEdit)
            {
                tcSupplier.SelectedTab = tpEdit;

                edit_txt_ID.Text = dgvSupplier.Rows[e.RowIndex].Cells[0].Value.ToString();
                edit_txt_Nama.Text = dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
                edit_txt_Alamat.Text = dgvSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
                edit_txt_ZipCode.Text = dgvSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
                edit_txt_NoHP.Text = dgvSupplier.Rows[e.RowIndex].Cells[4].Value.ToString();
                edit_txt_Email.Text = dgvSupplier.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            else if (isDelete)
            {
                tcSupplier.SelectedTab = tpDelete;

                del_txt_ID.Text = dgvSupplier.Rows[e.RowIndex].Cells[0].Value.ToString();
                del_txt_Nama.Text = dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
                del_txt_Alamat.Text = dgvSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
                del_txt_ZipCode.Text = dgvSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
                del_txt_NoHP.Text = dgvSupplier.Rows[e.RowIndex].Cells[4].Value.ToString();
                del_txt_Email.Text = dgvSupplier.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
        //=========================================================================================




    }
}
