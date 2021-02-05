using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K10U3_FahrzeugBewegen_MauriceR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonFahren.Enabled    = false;
            buttonLangsamer.Enabled = false;
            buttonSchneller.Enabled = false;
            this.Text = "Geschwindigkeit:" + pkw1.Speed;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            pkw1.Left = 0;
            pkw1.Speed = 0;
            this.Text = "Geschwindigkeit:" + pkw1.Speed;
            buttonFahren.Enabled    = true;
            buttonLangsamer.Enabled = true;
            buttonSchneller.Enabled = true;
        }

        private void buttonFahren_Click(object sender, EventArgs e)
        {
            pkw1.Fahren(panel1);
            buttonFahren.Enabled    = false;
            buttonLangsamer.Enabled = false;
            buttonSchneller.Enabled = false;
            pkw1.Speed = 0;
        }

        private void buttonLangsamer_Click(object sender, EventArgs e)
        {
          
            pkw1.Speed -= 10;
            this.Text = "Geschwindigkeit:" + pkw1.Speed;

        }

        private void buttonSchneller_Click(object sender, EventArgs e)
        {
            pkw1.Speed += 10;
            this.Text = "Geschwindigkeit:" + pkw1.Speed;

        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
