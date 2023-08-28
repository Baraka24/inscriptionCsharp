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

namespace WebTechInscription
{
    public partial class InscriptionForm : Form
    {
        public InscriptionForm()
        {
            InitializeComponent();
        }
        double montant;
        private bool ChampOk()
        {
            if (double.TryParse(txtMontant.Text, out montant) && txtAdresse.Text != "" && txtCode.Text != "" && txtNom.Text != "" && txtPostNom.Text != "" && txtPrenom.Text != "" && txtNumTel.Text != "" && cbxGenre.SelectedIndex != -1)
            {
                return true;
            }
            return false;
        }
        private void NotifierErreur()
        {
            if (txtCode.Text == "")
            {
                errorProvider1.SetError(txtCode, "Veillez entrez le code svp!");
            }
            else
            {
                errorProvider1.SetError(txtCode, "");
            }
            if (txtAdresse.Text == "")
            {
                errorProvider1.SetError(txtAdresse, "Veillez entrez l'adresse!");
            }
            else
            {
                errorProvider1.SetError(txtAdresse, "");
            }
            if (txtNom.Text == "")
            {
                errorProvider1.SetError(txtNom, "Veillez entrez le nom svp!");
            }
            else
            {
                errorProvider1.SetError(txtNom, "");
            }
            if (txtPostNom.Text == "")
            {
                errorProvider1.SetError(txtPostNom, "Veillez entrez le postnom svp!");
            }
            else
            {
                errorProvider1.SetError(txtPostNom, "");
            }
            if (txtPrenom.Text == "")
            {
                errorProvider1.SetError(txtPrenom, "Veillez entrez le prenom svp!");
            }
            else
            {
                errorProvider1.SetError(txtPrenom, "");
            }
            if (cbxGenre.SelectedIndex==-1)
            {
                errorProvider1.SetError(cbxGenre, "Veillez sélectionner le genre svp!");
            }
            else
            {
                errorProvider1.SetError(cbxGenre, "");
            }
            if (txtMontant.Text!=double.TryParse(txtMontant.Text,out montant).ToString())
            {
                errorProvider1.SetError(txtMontant, "Veillez entrer un montant correct svp!");
            }
            else
            {
                errorProvider1.SetError(txtMontant, "");
            }
            if (txtNumTel.Text == "")
            {
                errorProvider1.SetError(txtNumTel, "Le numero est requis!");
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ChampOk())
            {
                NotifierErreur();
                return;
            }
            MySqlConnection maConnection = new MySqlConnection();
            maConnection.ConnectionString = "server='localhost';database='webtech';uid='root';pwd=''";
            MySqlCommand maCommande = new MySqlCommand();
            maCommande.CommandText = "insert into apprenant(codeApp,nom,postnom,prenom,genre,numeroTel,quartierEtCell,dateInscription,montant) values(@codeApp,@nom,@postnom,@prenom,@genre,@numeroTel,@quartierEtCell,@dateInscription,@montant)";
            maCommande.Connection = maConnection;
            maCommande.Parameters.Add("codeApp", MySqlDbType.VarChar).Value = txtCode.Text;
            maCommande.Parameters.Add("nom", MySqlDbType.VarChar).Value = txtNom.Text;
            maCommande.Parameters.Add("postnom", MySqlDbType.VarChar).Value = txtPostNom.Text;
            maCommande.Parameters.Add("prenom", MySqlDbType.VarChar).Value = txtPrenom.Text;
            maCommande.Parameters.Add("genre", MySqlDbType.VarChar).Value = cbxGenre.Text;
            maCommande.Parameters.Add("numeroTel", MySqlDbType.VarChar).Value = txtNumTel.Text;
            maCommande.Parameters.Add("quartierEtCell", MySqlDbType.VarChar).Value = txtAdresse.Text;
            maCommande.Parameters.Add("dateInscription", MySqlDbType.DateTime).Value = dateTimePicker1.Value;
            maCommande.Parameters.Add("montant", MySqlDbType.Decimal).Value = txtMontant.Text;
            maConnection.Open();
            if (maCommande.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Ajouté avec succès!", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAdresse.Text = "";
                txtCode.Text = "";
                txtNom.Text = "";
                txtPostNom.Text = "";
                txtPrenom.Text = "";
                txtNumTel.Text = "";
                txtMontant.Text = "";
                cbxGenre.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Echec lors de l'ajout", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            maConnection.Close();
            
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCode, "");
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNom, "");
        }

        private void txtPostNom_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPostNom, "");
        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPrenom, "");
        }

        private void cbxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbxGenre, "");
        }

        private void txtAdresse_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtAdresse, "");
        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMontant, "");
        }

        private void txtNumTel_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNumTel, "");
        }

        private void InscriptionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
