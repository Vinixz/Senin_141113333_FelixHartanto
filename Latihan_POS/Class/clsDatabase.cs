using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Latihan_POS.Class
{
    class clsDatabase
    {
        private static string conString = "Server=localhost;Database=latihan_pos;Uid=root;Pwd=;";
        public static MySqlConnection con = new MySqlConnection();

        public static void openCon()
        {
            try
            {
                con.ConnectionString = conString;
                con.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void closeCon()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }
    }
}
