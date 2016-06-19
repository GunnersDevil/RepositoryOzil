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
    public partial class FormAbout : Form
    {
        DateTime waktu;
        FormMenu menu;

        public FormAbout()
        {
            InitializeComponent();
            pboBackground.Controls.Add(grbAbout);
            pboBackground.Controls.Add(grbHeader);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 770;
            this.Height = 655;

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (menu == null || !menu.IsHandleCreated)
                menu = new FormMenu();
            menu.Show();
            this.Hide();
        }
    }
}
