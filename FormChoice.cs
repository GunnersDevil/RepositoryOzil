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
    public partial class FormChoice : Form
    {
        DateTime waktu;
        FormMenu menu;
        FormLogin login;

        public FormChoice()
        {
            InitializeComponent();
            pboBackground.Controls.Add(grbHeader);
            pboBackground.Controls.Add(grbProses);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 770;
            this.Height = 410;

            waktu = DateTime.Now;
            tmrJam.Enabled = true;
            lblTanggal.Text = waktu.Date.ToString("dddd, dd MMMM yyyy");
        }

        private void tmrJam_Tick(object sender, EventArgs e)
        {
            waktu = DateTime.Now;
            lblJam.Text = waktu.Hour.ToString("00");
            lblMenit.Text = waktu.Minute.ToString("00");
            lblDetik.Text = waktu.Second.ToString("00");
        }

        private void btnCostumer_Click(object sender, EventArgs e)
        {
            if (menu == null || !menu.IsHandleCreated)
                menu = new FormMenu();
            menu.Show();
            this.Hide();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            if (login == null || !login.IsHandleCreated)
                login = new FormLogin();
            login.Show();
            this.Hide();
        }
    }
}
