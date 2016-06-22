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
    public partial class FormMenu : Form
    {
        FormCostumer costumer;
        FormHelp help;

        public FormMenu()
        {
            InitializeComponent();
            pboWelcome.Controls.Add(linkCostumer);
            pboWelcome.Controls.Add(linkHelp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 500;
            this.Height = 530;
        }

        private void linkMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (costumer == null || !costumer.IsHandleCreated)
                costumer = new FormCostumer();
            costumer.Show();
            this.Hide();
        }

        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (help == null || !help.IsHandleCreated)
                help = new FormHelp();
            help.Show();
            this.Hide();
        }
    }
}
