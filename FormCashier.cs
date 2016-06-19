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
    public partial class FormCashier : Form
    {
        Cashier cashier = new Cashier();
        DateTime waktu;
        String noMeja;

        public FormCashier()
        {
            InitializeComponent();
            pboBackground.Controls.Add(grbTombol);
            pboBackground.Controls.Add(grbCari);
            pboBackground.Controls.Add(grbHeader);
            pboBackground.Controls.Add(grbKasir);
            pboBackground.Controls.Add(grbTabel);
            pboBackground.Controls.Add(grbProses);
            pboBackground.Controls.Add(grbTransaksi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 770;
            this.Height = 655;
            NomorMeja();
            KondisiAwal();

            waktu = DateTime.Now;
            tmrJam.Enabled = true;
            lblTanggal.Text = waktu.Date.ToString("dddd, dd MMMM yyyy");

            cashier.TampilGrid(ref dtgOrder, "M 000");
        }

        public void KondisiAwal()
        {
            errorPayment.Clear();
            cmbNoMeja.Focus();

            this.noMeja = "";

            txtItem.Text = "";
            txtTotal.Text = "";
            txtBayar.Text = "";
            txtKembali.Text = "";
            txtItem.Enabled = false;
            txtTotal.Enabled = false;
            txtBayar.Enabled = false;
            txtKembali.Enabled = false;

            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnCE.Enabled = false;
            btnC.Enabled = false;
            btnCount.Enabled = false;
            btnAdd.Enabled = false;
            btnPrint.Enabled = false;
        }

        public void Aktif()
        {
            txtBayar.Focus();
            txtItem.Enabled = true;
            txtTotal.Enabled = true;
            txtBayar.Enabled = true;
            txtKembali.Enabled = true;
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnCE.Enabled = true;
            btnC.Enabled = true;
            btnCount.Enabled = true;
            btnAdd.Enabled = true;
            btnPrint.Enabled = true;
        }

        public void NomorMeja()
        {
            cmbNoMeja.Items.Add("M 001");
            cmbNoMeja.Items.Add("M 002");
            cmbNoMeja.Items.Add("M 003");
            cmbNoMeja.Items.Add("M 004");
            cmbNoMeja.Items.Add("M 005");
            cmbNoMeja.Items.Add("M 006");
            cmbNoMeja.Items.Add("M 007");
            cmbNoMeja.Items.Add("M 008");
            cmbNoMeja.Items.Add("M 009");
            cmbNoMeja.Items.Add("M 010");
        }

        private void tmrJam_Tick(object sender, EventArgs e)
        {
            waktu = DateTime.Now;
            lblJam.Text = waktu.Hour.ToString("00");
            lblMenit.Text = waktu.Minute.ToString("00");
            lblDetik.Text = waktu.Second.ToString("00");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.noMeja = cmbNoMeja.Text;
            cashier.TampilGrid(ref dtgOrder, this.noMeja);
            cashier.HitungJumlah(ref txtItem, ref txtTotal, this.noMeja);

            Aktif();
        }

        private void btnTombol_Click(object sender, EventArgs e)
        {
            Button btnTombol = (sender as Button);
            if (btnTombol.Text == "0")
            {
                if (txtBayar.Text != "")
                    txtBayar.Text += btnTombol.Text;
            }
            else if (btnTombol.Text == "C")
            {
                String text = txtBayar.Text;
                if (text.Length > 0)
                    txtBayar.Text = text.Substring(0, text.Length - 1);
            }
            else if (btnTombol.Text == "CE")
                txtBayar.Text = "";
            else if (btnTombol.Text == "COUNT")
                txtKembali.Text = (Convert.ToInt32(txtBayar.Text) - Convert.ToInt32(txtTotal.Text)).ToString();
            else
                txtBayar.Text += btnTombol.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}