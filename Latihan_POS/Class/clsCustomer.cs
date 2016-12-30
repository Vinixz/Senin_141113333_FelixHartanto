using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Latihan_POS.Class
{
    class clsCustomer
    {
        private static string nama_tabel = "customer";

        public int id { private set; get; }
        public string nama { private set; get; }
        public string alamat { private set; get; }
        public string zip_code { private set; get; }
        public string phone_number { private set; get; }
        public string email { private set; get; }
        public DateTime created_at { private set; get; }
        public DateTime updated_at { private set; get; }

        public clsCustomer()
        {

        }

        public clsCustomer(int id, string nama,string alamat, string zip_code,string phone_number, string email,DateTime created_at, DateTime updated_at)
        {
            this.id = id;
            this.nama = nama;
            this.alamat = alamat;
            this.zip_code = zip_code;
            this.phone_number = phone_number;
            this.email = email;
            this.created_at = created_at;
            this.updated_at = updated_at;
        }

        // EDIT
        public clsCustomer(int id, string nama,string alamat, string zip_code,string phone_number, string email, DateTime updated_at)
        {
            this.id = id;
            this.nama = nama;
            this.alamat = alamat;
            this.zip_code = zip_code;
            this.phone_number = phone_number;
            this.email = email;
           
            this.updated_at = updated_at;
        }

        // INSERT
        public clsCustomer(string nama,string alamat, string zip_code,string phone_number, string email,DateTime created_at, DateTime updated_at)
        {
           
            this.nama = nama;
            this.alamat = alamat;
            this.zip_code = zip_code;
            this.phone_number = phone_number;
            this.email = email;
            this.created_at = created_at;
            this.updated_at = updated_at;
        }

        // DELETE
        public clsCustomer(int id)
        {
            this.id = id;
        }

        public static clsCustomer Search(string id_search)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            string selectAll = "SELECT * FROM " + nama_tabel + " WHERE id = @id";

            MySqlCommand cmd;
            cmd = new MySqlCommand(selectAll, clsDatabase.con);
            cmd.Parameters.AddWithValue("@id", id_search);
            da.SelectCommand = cmd;
            try
            {
                clsDatabase.openCon();
                DataTable dtc = new DataTable();
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(dtc);
                clsDatabase.closeCon();

                if (dtc.Rows.Count == 1)
                {
                    clsCustomer cust = new clsCustomer(Convert.ToInt32(dtc.Rows[0][0].ToString()), dtc.Rows[0][1].ToString(), dtc.Rows[0][2].ToString(), dtc.Rows[0][3].ToString(), dtc.Rows[0][4].ToString(), dtc.Rows[0][5].ToString(), Convert.ToDateTime(dtc.Rows[0][6]), Convert.ToDateTime(dtc.Rows[0][7]));
                    return cust;
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
            string insertString = "INSERT INTO " + nama_tabel + " (name,address,zip_code,phone_number,email,created_at,updated_at)";
            insertString += " VALUES (@name,@address,@zip_code,@phone_number,@email,@created_at,@updated_at)";

            MySqlCommand cmd;
            cmd = new MySqlCommand(insertString, clsDatabase.con);
            cmd.Parameters.AddWithValue("@name", nama);
            cmd.Parameters.AddWithValue("@address", alamat);
            cmd.Parameters.AddWithValue("@zip_code", zip_code);
            cmd.Parameters.AddWithValue("@phone_number", phone_number);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@created_at", created_at);
            cmd.Parameters.AddWithValue("@updated_at", updated_at);

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
            string update = "UPDATE " + nama_tabel + " SET name = @name, address = @address, zip_code = @zip_code, ";
            update += "phone_number = @phone_number, email = @email, updated_at = @updated_at WHERE ID = @id";

            MySqlCommand cmd;
            cmd = new MySqlCommand(update, clsDatabase.con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", nama);
            cmd.Parameters.AddWithValue("@address", alamat);
            cmd.Parameters.AddWithValue("@zip_code", zip_code);
            cmd.Parameters.AddWithValue("@phone_number", phone_number);
            cmd.Parameters.AddWithValue("@email", email);
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
            string delete = "DELETE FROM " + nama_tabel + " WHERE ID = @id";

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
