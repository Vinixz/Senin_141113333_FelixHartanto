using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Latihan_POS.Class
{
    class clsPenjualan_Detail
    {
        private static string nama_tabel = "penjualan_detail";

        public int id { private set; get; }
        public clsPenjualan penjualan { private set; get; }
        public clsBarang barang { private set; get; }
        public int kuantitas { private set; get; }
        public decimal total_hrg_brg { private set; get; }

        public clsPenjualan_Detail()
        {    }

        public clsPenjualan_Detail(int id, clsPenjualan penjualan, clsBarang barang, int kuantitas, decimal total_hrg_brg)
        {
            this.id = id;
            this.penjualan = penjualan;
            this.barang = barang;
            this.kuantitas = kuantitas;
            this.total_hrg_brg = total_hrg_brg;
        }

        public clsPenjualan_Detail(clsPenjualan penjualan, clsBarang barang, int kuantitas, decimal total_hrg_brg)
        {
            this.penjualan = penjualan;
            this.barang = barang;
            this.kuantitas = kuantitas;
            this.total_hrg_brg = total_hrg_brg;
        }
       
       
        public bool isDuplicate()
        {
            bool res = false;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string selectAll = "SELECT * FROM " + nama_tabel + " WHERE id_penjualan = @id_penjualan AND id_barang = @id_barang";

            MySqlCommand cmd;
            cmd = new MySqlCommand(selectAll, clsDatabase.con);
            cmd.Parameters.AddWithValue("@id_penjualan", penjualan.id);
            cmd.Parameters.AddWithValue("@id_barang", barang.id);
            da.SelectCommand = cmd;
            try
            {
                clsDatabase.openCon();
                DataTable dt = new DataTable();
                da.SelectCommand.ExecuteNonQuery();
                clsDatabase.closeCon();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                clsDatabase.closeCon();
                throw new Exception(ex.Message);
            }
            return res;
        }

        public static clsPenjualan_Detail SearchOneByIdPenjualan(int id_penjualan)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string selectbycode = "SELECT * FROM " + nama_tabel + " WHERE id_penjualan = @id_penjualan";

            MySqlCommand cmd;
            cmd = new MySqlCommand(selectbycode, clsDatabase.con);
            cmd.Parameters.AddWithValue("@id_penjualan", id_penjualan);
            da.SelectCommand = cmd;
            try
            {
                clsDatabase.openCon();
                da.SelectCommand.ExecuteNonQuery();
                clsDatabase.closeCon();

                DataTable dt = new DataTable();
                da.Fill(dt);

                
                if (dt.Rows.Count > 0)
                {
                    clsPenjualan_Detail penjualanDetail = new clsPenjualan_Detail(Convert.ToInt32(dt.Rows[0][0]), clsPenjualan.SearchOneByKode(Convert.ToInt32(dt.Rows[0][1])), clsBarang.Search(dt.Rows[0][2].ToString()), Convert.ToInt32(dt.Rows[0][4]), Convert.ToDecimal(dt.Rows[0][5]));

                    return penjualanDetail;
                }
                return null;
            }
            catch (Exception ex)
            {
                clsDatabase.closeCon();
                throw new Exception(ex.Message);
            }
        }

        public static MySqlDataAdapter SelectByID(int id_penj)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string selectbycode = "SELECT * FROM " + nama_tabel + " WHERE id_penjualan = @id";

            MySqlCommand cmd;
            cmd = new MySqlCommand(selectbycode, clsDatabase.con);
            cmd.Parameters.AddWithValue("@id", id_penj);
            da.SelectCommand = cmd;
            try
            {
                clsDatabase.openCon();
                da.SelectCommand.ExecuteNonQuery();
                clsDatabase.closeCon();
            }
            catch (Exception ex)
            {
                clsDatabase.closeCon();
                throw new Exception(ex.Message);
            }
            return da;
        }

        public int Insert()
        {
            int res = 0;

            MySqlDataAdapter da = new MySqlDataAdapter();
            string insert = "INSERT INTO " + nama_tabel + " (id_penjualan, id_barang, harga_barang, kuantitas, total_hrg_brg)";
            insert += " VALUES (@id_penjualan, @id_barang, @harga_barang, @kuantitas, @total_hrg_brg)";

            MySqlCommand cmd;
            cmd = new MySqlCommand(insert, clsDatabase.con);
            cmd.Parameters.AddWithValue("@id_penjualan", penjualan.kode);
            cmd.Parameters.AddWithValue("@id_barang", barang.id);
            cmd.Parameters.AddWithValue("@harga_barang", barang.harga_jual);
            cmd.Parameters.AddWithValue("@kuantitas", kuantitas);
            cmd.Parameters.AddWithValue("@total_hrg_brg", total_hrg_brg);
            da.InsertCommand = cmd;
            try
            {
                clsDatabase.openCon();
                res = da.InsertCommand.ExecuteNonQuery();
                clsDatabase.closeCon();
            }
            catch (Exception ex)
            {
                clsDatabase.closeCon();
                throw new Exception(ex.Message);
            }
            return res;
        }

        public int Update(int kuantitas, decimal total_hrg_brg)
        {
            int res = 0;

            MySqlDataAdapter da = new MySqlDataAdapter();
            string update = "UPDATE " + nama_tabel + " SET harga_barang = @harga_barang, kuantitas = @kuantitas, total_hrg_brg = @total_hrg_brg";
            update += " WHERE id_penjualan = @id_penjualan AND id_barang = @id_barang";

            MySqlCommand cmd;
            cmd = new MySqlCommand(update, clsDatabase.con);
            cmd.Parameters.AddWithValue("@id_penjualan", penjualan.kode);
            cmd.Parameters.AddWithValue("@id_barang", barang.id);
            cmd.Parameters.AddWithValue("@harga_barang", barang.harga_jual);
            cmd.Parameters.AddWithValue("@kuantitas", kuantitas);
            cmd.Parameters.AddWithValue("@total_hrg_brg", total_hrg_brg);

            da.UpdateCommand = cmd;
            try
            {
                clsDatabase.openCon();
                res = da.UpdateCommand.ExecuteNonQuery();
                clsDatabase.closeCon();
            }
            catch (Exception ex)
            {
                clsDatabase.closeCon();
                throw new Exception(ex.Message);
            }
            return res;
        }
    }
}
