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
    public partial class Customer : Form
    {
        DataTable dtCustomer; 
        clsCustomer cust_temp;
        bool isEdit = false;
        bool isDelete = false;

        public Customer()
        {
            InitializeComponent();
        }

        public void isCari(bool a)
        {
            isEdit = a;
            isDelete = a;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            dtCustomer = new DataTable();
            BindingSource bsCustomer = new BindingSource();
            bsCustomer.DataSource = dtCustomer;
            dgvCustomer.DataSource = bsCustomer;
        }

        private void tcCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tcCustomer.SelectedTab == tpDaftar)
                {
                    dtCustomer.Clear();
                    clsCustomer.SelectAll().Fill(dtCustomer);
                }
                isCari(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        
        //REGISTRASI=========================================================================================
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

                clsCustomer customerBaru = new clsCustomer(reg_txt_Nama.Text, reg_txt_Alamat.Text, reg_txt_ZipCode.Text, reg_txt_NoHP.Text, reg_txt_Email.Text, DateTime.Now, DateTime.Now);

                int res = customerBaru.Insert();
                MessageBox.Show("customer telah berhasil ditambahkan", "Saved");
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


        //EDIT=========================================================================================
        private void edit_btn_Cari_Click(object sender, EventArgs e)
        {
            tcCustomer.SelectedTab = tpDaftar;
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
                clsCustomer res = clsCustomer.Search(edit_txt_ID.Text);
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
                    MessageBox.Show("Customer tidak ditemukan", "Error");
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
                clsCustomer customerUpdate = new clsCustomer(Convert.ToInt32(edit_txt_ID.Text), edit_txt_Nama.Text, edit_txt_Alamat.Text, edit_txt_ZipCode.Text, edit_txt_NoHP.Text, edit_txt_Email.Text, DateTime.Now);

                res = customerUpdate.Update();
                if (res == 1)
                {
                    MessageBox.Show("customer telah berhasil diubah", "Edited");
                }
                else if (res == 0)
                {
                    MessageBox.Show("Customer tidak ditemukan", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        //=========================================================================================


        //DELETE=========================================================================================
        private void del_btn_Cari_Click(object sender, EventArgs e)
        {
            tcCustomer.SelectedTab = tpDaftar;
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
                clsCustomer res = clsCustomer.Search(del_txt_ID.Text);
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
                    MessageBox.Show("Customer tidak ditemukan", "Error");
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
                    clsCustomer customerRemove = new clsCustomer(Convert.ToInt32(del_txt_ID.Text));
                    res = customerRemove.Delete();
                    MessageBox.Show(res + " customer telah berhasil dihapus", "Deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        //=========================================================================================


        //=========================================================================================
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isEdit)
            {
                tcCustomer.SelectedTab = tpEdit;

                edit_txt_ID.Text = dgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                edit_txt_Nama.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                edit_txt_Alamat.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                edit_txt_ZipCode.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                edit_txt_NoHP.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                edit_txt_Email.Text = dgvCustomer.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            else if (isDelete)
            {
                tcCustomer.SelectedTab = tpDelete;

                del_txt_ID.Text = dgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                del_txt_Nama.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                del_txt_Alamat.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                del_txt_ZipCode.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                del_txt_NoHP.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                del_txt_Email.Text = dgvCustomer.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
        //=========================================================================================
        
    }
}
