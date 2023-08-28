using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebTechInscription
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            AccueilUC uc = new AccueilUC();
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(uc);
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            ApprenantUC uc = new ApprenantUC();
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AccueilUC uc = new AccueilUC();
            pnlShow.Controls.Add(uc);
        }

        private void btnPaiement_Click(object sender, EventArgs e)
        {
            PaiementUC uc = new PaiementUC();
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(uc);
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            ModuleUC uc = new ModuleUC();
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(uc);
            //btnModule.BackColor = Color.Red;
        }
    }
}
