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
    class Cashier
    {
        Koneksi koneksi;
        
        public void Tambah(String noMeja, String nama, int jumlah, int harga, int total)
        {
            try
            {
                koneksi = new Koneksi();
                koneksi.cmd.CommandText = "insert into tblOrder values('','" + noMeja + "','" + nama + "', '" + jumlah + "', '" + harga + "', '" + total + "')";
                
                koneksi.conn.Open();
                koneksi.cmd.ExecuteNonQuery();
                koneksi.conn.Close();

                MessageBox.Show(string.Format("Pesanan anda telah disimpan"), "Özil Cafe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}", ex.Message), "Özil Cafe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void HitungJumlah(ref TextBox txtJumlah, ref TextBox txtTotal, String noMeja)
        {
            try
            {
                koneksi = new Koneksi();
                koneksi.cmd = koneksi.conn.CreateCommand();
                koneksi.cmd.CommandText = "select jumlah, total from tblOrder where noMeja = '" + noMeja + "'";
                koneksi.dt = new DataTable("tblOrder");

                koneksi.conn.Open();
                koneksi.dt.Load(koneksi.cmd.ExecuteReader());
                koneksi.conn.Close();

                int jumlah = 0, total=0;
                foreach (DataRow i in koneksi.dt.Rows)
                {
                    jumlah += (int)i["jumlah"];
                    total += (int)i["total"];
                }

                txtJumlah.Text = jumlah.ToString();
                txtTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}", ex.Message), "Özil Cafe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Hapus(String noMeja)
        {
            try
            {
                koneksi = new Koneksi();
                koneksi.cmd = koneksi.conn.CreateCommand();
                koneksi.cmd.CommandText = "delete from tblOrder where noMeja = '" + noMeja + "'";

                koneksi.conn.Open();
                koneksi.cmd.ExecuteNonQuery();
                koneksi.conn.Close();

                MessageBox.Show(string.Format("Pesanan anda telah dihapus"), "Özil Cafe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}", ex.Message), "Özil Cafe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void TampilGrid(ref DataGridView dtgOrder, String noMeja)
        {
            try
            {
                koneksi = new Koneksi();
                koneksi.cmd = koneksi.conn.CreateCommand();
                koneksi.cmd.CommandText = "select menu, jumlah, harga, total from tblOrder where noMeja = '" + noMeja + "'";

                koneksi.conn.Open();
                koneksi.da = new MySqlDataAdapter(koneksi.cmd);
                koneksi.conn.Close();

                koneksi.ds = new DataSet();
                koneksi.da.Fill(koneksi.ds, "tblOrder");
                dtgOrder.DataSource = koneksi.ds;
                dtgOrder.DataMember = "tblOrder";

                dtgOrder.Columns[0].HeaderText = "Menu";
                dtgOrder.Columns[1].HeaderText = "Jumlah";
                dtgOrder.Columns[2].HeaderText = "Harga";
                dtgOrder.Columns[3].HeaderText = "Total";
                dtgOrder.Columns[0].Width = 110;
                dtgOrder.Columns[1].Width = 60;
                dtgOrder.Columns[2].Width = 60;
                dtgOrder.Columns[3].Width = 60;
                dtgOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}", ex.Message), "Özil Cafe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
