using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Latihan_POS.Class
{
    class clsBarang
    {
        private static string nama_tabel = "barang";

        public int id { private set; get; }
        public string kode { private set; get; }
        public string nama { private set; get; }
        public int jumlah { private set; get; }
        public decimal harga_hpp { private set; get; }
        public decimal harga_jual { private set; get; }
        public DateTime created_at { private set; get; }
        public DateTime updated_at { private set; get; }

        public clsBarang()
        {

        }

        public clsBarang(int id, string kode, string nama, int jumlah, decimal hargaHpp, decimal hargajual, DateTime createdat, DateTime updatedad)
        {
            this.id = id;
            this.kode = kode;
            this.nama = nama;
            this.jumlah = jumlah;
            this.harga_hpp = hargaHpp;
            this.harga_jual = hargajual;
            this.created_at = createdat;
            this.updated_at = updatedad;
        }

        // EDIT
        public clsBarang(int id, string kode, string nama, int jumlah, decimal hargaHpp, decimal hargajual, DateTime updatedad)
        {
            this.id = id;
            this.kode = kode;
            this.nama = nama;
            this.jumlah = jumlah;
            this.harga_hpp = hargaHpp;
            this.harga_jual = hargajual;
         
            this.updated_at = updatedad;
        }

        // INSERT
        public clsBarang(string kode, string nama, int jumlah, decimal hargaHpp, decimal hargajual, DateTime createdat, DateTime updatedad)
        {

            this.kode = kode;
            this.nama = nama;
            this.jumlah = jumlah;
            this.harga_hpp = hargaHpp;
            this.harga_jual = hargajual;
            this.created_at = createdat;
            this.updated_at = updatedad;
        }

        // DELETE
        public clsBarang(int id)
        {
            this.id = id;
        }

        public void set_Jumlah(int jumlah){
            this.jumlah = jumlah;
        }

        public static clsBarang Search(string id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string selectKode = "SELECT * FROM " + nama_tabel + " WHERE id = @id";

            MySqlCommand cmd;
            cmd = new MySqlCommand(selectKode, clsDatabase.con);
            cmd.Parameters.AddWithValue("@id", id);
            da.SelectCommand = cmd;
            try
            {
                clsDatabase.openCon();
                DataTable dt = new DataTable();
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(dt);
                clsDatabase.closeCon();

                
                if (dt.Rows.Count > 0)
                {
                    clsBarang barang = new clsBarang(Convert.ToInt32(dt.Rows[0][0]), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), Convert.ToInt32(dt.Rows[0][3]), Convert.ToDecimal(dt.Rows[0][4]), Convert.ToDecimal(dt.Rows[0][5]), Convert.ToDateTime(dt.Rows[0][6]), Convert.ToDateTime(dt.Rows[0][7]));   
                    return barang;
                }
                return null;
            }
            catch (Exception ex)
            {
                clsDatabase.closeCon();
                throw new Exception(ex.Message);
            }
        }

        public static clsBarang SearchKode(string kode)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string selectKode = "SELECT * FROM " + nama_tabel + " WHERE Kode = @kode";

            MySqlCommand cmd;
            cmd = new MySqlCommand(selectKode, clsDatabase.con);
            cmd.Parameters.AddWithValue("@kode", kode);
            da.SelectCommand = cmd;
            try
            {
                clsDatabase.openCon();
                DataTable dt = new DataTable();
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(dt);
                clsDatabase.closeCon();

                if (dt.Rows.Count > 0)
                {
                    clsBarang barang = new clsBarang(Convert.ToInt32(dt.Rows[0][0]), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), Convert.ToInt32(dt.Rows[0][3]), Convert.ToDecimal(dt.Rows[0][4]), Convert.ToDecimal(dt.Rows[0][5]), Convert.ToDateTime(dt.Rows[0][6]), Convert.ToDateTime(dt.Rows[0][7]));
                    return barang;
                }
                return null;
            }
            catch (Exception ex)
            {
                clsDatabase.closeCon();
                throw new Exception(ex.Message);
            }
        }

        public static MySqlDataAdapter SelectAll()
        {
            MySqlDataAdapter da;
            string selectString = "SELECT * FROM " + nama_tabel;
            da = new MySqlDataAdapter(selectString, clsDatabase.con);
            try
            {
                clsDatabase.openCon();
                da.SelectCommand.ExecuteScalar();
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
            int res;

            MySqlDataAdapter da = new MySqlDataAdapter();
            string insertString = "INSERT INTO " + nama_tabel + " (Kode,Nama,JumlahAwal,HargaHPP,HargaJual,created_at,updated_at)";
            insertString += " VALUES (@kode,@nama,@jumlahAwal,@hargaHPP,@hargaJual,@createdAt,@updatedAt)";

            MySqlCommand cmd;
            cmd = new MySqlCommand(insertString, clsDatabase.con);
            cmd.Parameters.AddWithValue("@kode", kode);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@jumlahAwal", jumlah);
            cmd.Parameters.AddWithValue("@hargaHPP", harga_hpp);
            cmd.Parameters.AddWithValue("@hargaJual", harga_jual);
            cmd.Parameters.AddWithValue("@createdAt", created_at);
            cmd.Parameters.AddWithValue("@updatedAt", updated_at);

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

        public int Update()
        {
            int res;

            MySqlDataAdapter da = new MySqlDataAdapter();
            string update = "UPDATE " + nama_tabel + " SET Kode = @kode, Nama = @nama, JumlahAwal = @jumlahAwal, HargaHPP = @hargaHPP, ";
            update += "HargaJual = @hargaJual, updated_at = @updatedAt WHERE ID = @id";

            MySqlCommand cmd;
            cmd = new MySqlCommand(update, clsDatabase.con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@kode", kode);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@jumlahAwal", jumlah);
            cmd.Parameters.AddWithValue("@hargaHPP", harga_hpp);
            cmd.Parameters.AddWithValue("@hargaJual", harga_jual);
            cmd.Parameters.AddWithValue("@updatedAt", updated_at);
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

        public int Delete()
        {
            int res;

            MySqlDataAdapter da = new MySqlDataAdapter();
            string delete = "DELETE FROM barang WHERE ID = @id";

            MySqlCommand cmd;
            cmd = new MySqlCommand(delete, clsDatabase.con);
            cmd.Parameters.AddWithValue("@id", id);
            da.DeleteCommand = cmd;
            try
            {
                clsDatabase.openCon();
                res = da.DeleteCommand.ExecuteNonQuery();
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
