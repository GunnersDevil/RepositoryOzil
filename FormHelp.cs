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
    public partial class FormHelp : Form
    {
        FormChoice choice;
        FormCostumer costumer;
        FormAbout about;

        public FormHelp()
        {
            InitializeComponent();
            pboBackground.Controls.Add(grbProses);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 770;
            this.Height = 655;
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            if (choice == null || !choice.IsHandleCreated)
                choice = new FormChoice();
            choice.Show();
            this.Hide();
        }

        private void btnCostumer_Click(object sender, EventArgs e)
        {
            if (costumer == null || !costumer.IsHandleCreated)
                costumer = new FormCostumer();
            costumer.Show();
            this.Hide();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (about == null || !about.IsHandleCreated)
                about = new FormAbout();
            about.Show();
            this.Hide();
        }
    }
}
