using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Latihan_POS.Class
{
    class clsPenjualan
    {
        private static string nama_tabel = "penjualan";

        public int id { private set; get; }
        public int kode { private set; get; }
        public clsCustomer customer { private set; get; }
        public decimal total_harga { private set; get; }
        public DateTime created_at { private set; get; }
        public DateTime updated_at { private set; get; }

        public clsPenjualan() 
        { }

        public clsPenjualan(int id, int kode, clsCustomer customer, decimal total_harga, DateTime created_at, DateTime updated_at)
        {
            this.id = id;
            this.kode = kode;
            this.id = id;
            this.customer = customer;
            this.created_at = created_at;
            this.updated_at = updated_at;
            this.total_harga = total_harga;
        }

        public clsPenjualan(int kode, clsCustomer customer, decimal total_harga, DateTime created_at, DateTime updated_at)
        {
            this.kode = kode;
            this.id = id;
            this.customer = customer;
            this.created_at = created_at;
            this.updated_at = updated_at;
            this.total_harga = total_harga;
        }

        public clsPenjualan(int kode)
        {
            this.kode = kode;
        }

        public bool isDuplicate()
        {
            bool res = false;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string selectAll = "SELECT * FROM " + nama_tabel + " WHERE id = @id";

            MySqlCommand cmd;
            cmd = new MySqlCommand(selectAll, clsDatabase.con);
            cmd.Parameters.AddWithValue("@id", id);
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

        public static clsPenjualan SearchOneById(string id)
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
                    clsPenjualan penjualan = new clsPenjualan(Convert.ToInt32(dt.Rows[0][0]), Convert.ToInt32(dt.Rows[0][1]), clsCustomer.Search(dt.Rows[0][2].ToString()), Convert.ToDecimal(dt.Rows[0][3]), Convert.ToDateTime(dt.Rows[0][4]), Convert.ToDateTime(dt.Rows[0][5]));

                    return penjualan;
                }
                return null;
            }
            catch (Exception ex)
            {
                clsDatabase.closeCon();
                throw new Exception(ex.Message);
            }
        }

        
        public static clsPenjualan SearchOneByKode(int kode)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string selectKode = "SELECT * FROM " + nama_tabel + " WHERE kode = @kode";

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
                    clsPenjualan penjualan = new clsPenjualan(Convert.ToInt32(dt.Rows[0][0]), Convert.ToInt32(dt.Rows[0][1]), clsCustomer.Search(dt.Rows[0][2].ToString()), Convert.ToDecimal(dt.Rows[0][3]), Convert.ToDateTime(dt.Rows[0][4]), Convert.ToDateTime(dt.Rows[0][5]));

                    return penjualan;
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
            MySqlDataAdapter da = new MySqlDataAdapter();
            string selectAll = "SELECT * FROM " + nama_tabel;

            MySqlCommand cmd;
            cmd = new MySqlCommand(selectAll, clsDatabase.con);
            da.SelectCommand = cmd;
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
            int res = 0;

            MySqlDataAdapter da = new MySqlDataAdapter();
            string insert = "INSERT INTO " + nama_tabel + " (kode, id_customer, created_at, updated_at, total_harga)";
            insert += " VALUES (@kode, @id_customer, @created_at, @updated_at, @total_harga)";

            MySqlCommand cmd;
            cmd = new MySqlCommand(insert, clsDatabase.con);
            cmd.Parameters.AddWithValue("@kode", kode);
            cmd.Parameters.AddWithValue("@id_customer", customer.id);
            cmd.Parameters.AddWithValue("@created_at", created_at);
            cmd.Parameters.AddWithValue("@updated_at", updated_at);
            cmd.Parameters.AddWithValue("@total_harga", total_harga);
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

        public int Update(decimal total_hrg_brg)
        {
            int res;

            MySqlDataAdapter da = new MySqlDataAdapter();
            string update = "UPDATE " + nama_tabel + " SET id_customer = @id_customer, total_harga = @total_harga, updated_at = @updated_at";
            update += " WHERE id = @id";

            MySqlCommand cmd;
            cmd = new MySqlCommand(update, clsDatabase.con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@kode", kode);
            cmd.Parameters.AddWithValue("@id_customer", customer.id);
            cmd.Parameters.AddWithValue("@total_harga", total_hrg_brg);
            cmd.Parameters.AddWithValue("@updated_at", updated_at);
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
            string delete = "DELETE FROM " + nama_tabel + " WHERE id = @id";
            delete += " WHERE id = @id";

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
