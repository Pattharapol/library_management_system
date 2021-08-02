using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Code
{
    public class DataAccessLayer
    {
        private static MySqlConnection conn;

        private static MySqlConnection ConnOpen()
        {
            if (conn == null)
            {
                conn = new MySqlConnection("server=localhost;userid=root;password=;database=library;port=3306;");
            }
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public static void Execute(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, ConnOpen());
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable Retreiving(string sql)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, ConnOpen());
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static void ControlValidation(TextBox textBox, string msg, ErrorProvider ep)
        {
            if (textBox.Text.Trim().Length == 0)
            {
                ep.SetError(textBox, msg);
                textBox.Focus();
                return;
            }
        }
    }
}