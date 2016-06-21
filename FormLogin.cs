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
    public partial class FormLogin: Form
    {
        DateTime waktu;
        Login login = new Login();
        FormCashier cashier;
        bool cek;

        public FormLogin()
        {
            InitializeComponent();
            pboBackground.Controls.Add(grbTombol);
            pboBackground.Controls.Add(grbHeader);
            pboBackground.Controls.Add(grbTransaksi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 770;
            this.Height = 655;

            waktu = DateTime.Now;
            tmrJam.Enabled = true;
            lblTanggal.Text = waktu.Date.ToString("dddd, dd MMMM yyyy");
            txtPassword.PasswordChar = '*';
        }

        public void KondisiAwal()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";

            errorUser.Clear();
            errorPass.Clear();
        }

        private void tmrJam_Tick(object sender, EventArgs e)
        {
            waktu = DateTime.Now;
            lblJam.Text = waktu.Hour.ToString("00");
            lblMenit.Text = waktu.Minute.ToString("00");
            lblDetik.Text = waktu.Second.ToString("00");
        }

        private void btnTombol_Click(object sender, EventArgs e)
        {
            Button btnTombol = (sender as Button);
            TextBox txtInput = (sender as TextBox);

            if (txtUsername.Focus())
                txtInput = txtUsername;
            else if (txtPassword.Focus())
                txtInput = txtPassword;

            if (btnTombol.Text == "Backspace")
            {
                String text = txtUsername.Text;
                if (text.Length > 0)
                    txtInput.Text = text.Substring(0, text.Length - 1);
            }
            else if (btnTombol.Text == "Tab")
            {
                txtPassword.Focus();
            }
            else
                txtInput.Text += btnTombol.Text;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                if (txtUsername.Text == "")
                    errorUser.SetError(txtUsername, "Username tidak boleh kosong");
                else
                    errorUser.Clear();

                if (txtPassword.Text == "")
                    errorPass.SetError(txtPassword, "Password tidak boleh kosong");
                else
                    errorPass.Clear();
            }
            else
            {
                login.Masuk(txtUsername.Text.ToString(), txtPassword.Text.ToString(), ref cek);
                if (cek)
                {
                    if (cashier == null || !cashier.IsHandleCreated)
                        cashier = new FormCashier();
                    cashier.Show();
                    this.Hide();
                }
                else
                {
                    KondisiAwal();
                    MessageBox.Show(string.Format("Username atau Password anda salah !!!"), "Özil Cafe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
