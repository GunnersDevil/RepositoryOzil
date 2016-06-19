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
    public partial class FormCostumer : Form
    {
        Costumer costumer = new Costumer();
        FormHelp help;
        DateTime waktu;
        String noMeja, nama;
        int harga, jumlah, total;

        public FormCostumer()
        {
            InitializeComponent();
            pboBackground.Controls.Add(grbAngka);
            pboBackground.Controls.Add(grbDrink);
            pboBackground.Controls.Add(grbFood);
            pboBackground.Controls.Add(grbHeader);
            pboBackground.Controls.Add(grbJumlah);
            pboBackground.Controls.Add(grbSoftDrink);
            pboBackground.Controls.Add(grbTabel);
            pboBackground.Controls.Add(grbTombol);
        }

        private void FormCostumer_Load(object sender, EventArgs e)
        {
            waktu = DateTime.Now;
            tmrJam.Enabled = true;
            lblTanggal.Text = waktu.Date.ToString("dddd, dd MMMM yyyy");
            this.Width = 770;
            this.Height = 655;
            NomorMeja();
            KondisiAwal();
            costumer.TampilGrid(ref dtgOrder, "M 000");
        }

        public void KondisiAwal()
        {
            MenuClear();
            errorMeja.Clear();
            errorJumlah.Clear();
            btnRice.Focus();

            this.noMeja = "";
            this.nama = "";
            this.jumlah = 0;
            this.harga = 0;
            this.total = 0;

            txtJumlah.Text = "";
            txtJumlah.Enabled = false;

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
            btnOrder.Enabled = false;

            grbSoftDrink.Visible = false;
        }

        public void Aktif()
        {
            txtJumlah.Focus();
            txtJumlah.Enabled = true;
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
            btnOrder.Enabled = true;
        }

        public void MenuAwal(ref Button btn)
        {
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.DarkGray;
        }

        public void MenuClear()
        {
            MenuAwal(ref btnCocaCola);
            MenuAwal(ref btnFanta);
            MenuAwal(ref btnSprite);
            MenuAwal(ref btnBintang);
            MenuAwal(ref btnHeineken);
            MenuAwal(ref btnCarlsberg);
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

        private void cmbNoMeja_TextChanged(object sender, EventArgs e)
        {
            cmbNoMeja.Enabled = false;
            this.noMeja = cmbNoMeja.Text;
            costumer.TampilGrid(ref dtgOrder, this.noMeja);
        }

        private void btnSoftDrink_Click(object sender, EventArgs e)
        {
            grbSoftDrink.Visible = true;
            btnSoftDrink.BackColor = Color.SteelBlue;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Button btnMenu = (sender as Button);
            if (btnMenu.Name == "btnCocaCola")
            {
                this.nama = "Coca Cola";
                this.harga = 10000;
            }
            else if (btnMenu.Name == "btnFanta")
            {
                this.nama = "Fanta";
                this.harga = 10000;
            }
            else if (btnMenu.Name == "btnSprite")
            {
                this.nama = "Sprite";
                this.harga = 10000;
            }
            else if (btnMenu.Name == "btnBintang")
            {
                this.nama = "Bir Bintang";
                this.harga = 20000;
            }
            else if (btnMenu.Name == "btnCarlsberg")
            {
                this.nama = "Carlsberg";
                this.harga = 25000;
            }
            else if (btnMenu.Name == "btnHeineken")
            {
                this.nama = "Heineken";
                this.harga = 30000;
            }
            MenuClear();
            Aktif();
            btnMenu.FlatAppearance.BorderSize = 3;
            btnMenu.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            txtJumlah.Text = "";
        }

        private void btnTombol_Click(object sender, EventArgs e)
        {
            Button btnTombol = (sender as Button);
            if (btnTombol.Text == "0")
            {
                if (txtJumlah.Text != "")
                    txtJumlah.Text += btnTombol.Text;
            }
            else if (btnTombol.Text == "C")
            {
                String text = txtJumlah.Text;
                if (text.Length > 0)
                    txtJumlah.Text = text.Substring(0, text.Length - 1);
            }
            else if (btnTombol.Text == "CE")
                txtJumlah.Text = "";
            else
                txtJumlah.Text += btnTombol.Text;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cmbNoMeja.Text == "")
                errorMeja.SetError(cmbNoMeja, "Isikan Nomor Meja");
            else
            {
                noMeja = cmbNoMeja.Text;
                errorMeja.Clear();
            }

            if (txtJumlah.Text == "" || txtJumlah.Text == "0")
                errorJumlah.SetError(txtJumlah, "Isikan Jumlah");
            else if (txtJumlah.Text.Length > 2)
                errorJumlah.SetError(txtJumlah, "Melebihi Kapasitas");
            else
            {
                this.jumlah = Convert.ToInt32(txtJumlah.Text);
                errorJumlah.Clear();
            }

            this.total = this.jumlah * this.harga;
            if (this.noMeja != "" && this.nama != "" && this.jumlah != 0 && this.harga != 0 && this.total != 0)
            {
                errorMeja.Clear();
                costumer.Tambah(this.noMeja, this.nama, this.jumlah, this.harga, this.total);
                costumer.TampilGrid(ref dtgOrder, this.noMeja);
                KondisiAwal();
            }
            else
                this.jumlah = 0;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (help == null || !help.IsHandleCreated)
                help = new FormHelp();
            help.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}