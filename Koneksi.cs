using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ozil_Cafe
{
    class Koneksi
    {
        public MySqlConnection conn;
        public MySqlDataAdapter da;
        public MySqlDataReader dr;
        public DataSet ds;
        public DataTable dt;
        public MySqlCommand cmd;

        public Koneksi()
        {
            try
            {
                String strCon = "server=localhost; user id=root; password=; database=dbOzilCafe;";
                conn = new MySqlConnection();
                conn.ConnectionString = strCon;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}", ex.Message), "Ozil Cafe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
