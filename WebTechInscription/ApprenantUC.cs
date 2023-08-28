using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WebTechInscription
{
    public partial class ApprenantUC : UserControl
    {
        public ApprenantUC()
        {
            InitializeComponent();
        }
        private void CacheDgv()
        {
            lblTitre.Visible = false;
            btnNouvelA.Visible = false;
            gpb.Visible = false;
            dataGridView1.Visible = false;
        }
        private void CacherFormulaire()
        {
            lblCode.Visible = false;
            lblAdresse.Visible = false;
            lblGenre.Visible = false;
            lblMontant.Visible = false;
            lblNom.Visible = false;
            lblNum.Visible = false;
            lblPrenom.Visible = false;
            lblDate.Visible = false;
            lblPostNom.Visible = false;

            txtAdresse.Visible = false;
            txtCode.Visible = false;
            txtMontant.Visible = false;
            txtNumTel.Visible = false;
            txtPostNom.Visible = false;
            txtPrenom.Visible = false;
            txtNom.Visible = false;
            cbxGenre.Visible = false;
            dateTimePicker1.Visible = false;
            textBox1.Visible = false;
            comboBox1.Visible = false;
            btnAjouter.Visible = false;
        }
        private void AfficherFormulaire()
        {
            lblCode.Visible = true;
            lblAdresse.Visible = true;
            lblGenre.Visible = true;
            lblMontant.Visible = true;
            lblNom.Visible = true;
            lblNum.Visible = true;
            lblPrenom.Visible = true;
            lblDate.Visible = true;
            lblPostNom.Visible = true;

            txtAdresse.Visible = true;
            txtCode.Visible = true;
            txtMontant.Visible = true;
            txtNumTel.Visible = true;
            txtPostNom.Visible = true;
            txtPrenom.Visible = true;
            txtNom.Visible = true;
            cbxGenre.Visible = true;
            dateTimePicker1.Visible = true;
            textBox1.Visible = true;
            comboBox1.Visible = true;
            btnAjouter.Visible = true;
        }
        private void ApprenantUC_Load(object sender, EventArgs e)
        {
            CacherFormulaire();
            AfficherApprenants();
            
        }
        private void AfficherApprenants()
        {
            MySqlConnection maConnexion = new MySqlConnection();
            maConnexion.ConnectionString = "server='localhost';database='webtech';uid='root';pwd=''";
            MySqlCommand maCommande = new MySqlCommand();
            maCommande.CommandText = "select * from apprenant";
            maCommande.Connection = maConnexion;
            maConnexion.Open();
            MySqlDataAdapter canal = new MySqlDataAdapter();
            DataTable table = new DataTable();
            canal.SelectCommand = maCommande;
            canal.Fill(table);
            dataGridView1.DataSource = table;
            maConnexion.Close();
        }
        //private void Cacher()
        //{
        //    dateTimePicker1.Visible = false;
        //    txtAdresse.Visible = false;
        //    txtCode.Visible = false;
        //    txtNom.Visible = false;
        //    txtNumTel.Visible = false;
        //    txtPostNom.Visible = false;
        //    txtPrenom.Visible = false;
        //    btnAjouter.Visible = false;
        //    cbxGenre.Visible = false;
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            InscriptionForm myform = new InscriptionForm();
            myform.ShowDialog();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            CacheDgv();
            AfficherFormulaire();
            textBox1.Text = dataGridView1.CurrentRow.Cells["codeApp"].Value.ToString();
            txtAdresse.Text = dataGridView1.CurrentRow.Cells["quartierEtCell"].Value.ToString();
            txtMontant.Text = dataGridView1.CurrentRow.Cells["montant"].Value.ToString();
            txtNumTel.Text = dataGridView1.CurrentRow.Cells["numeroTel"].Value.ToString();
            txtNom.Text = dataGridView1.CurrentRow.Cells["nom"].Value.ToString();
            txtPostNom.Text = dataGridView1.CurrentRow.Cells["postnom"].Value.ToString();
            txtPrenom.Text = dataGridView1.CurrentRow.Cells["prenom"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["genre"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["dateInscription"].Value.ToString();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();//création de l'objet con
            con.ConnectionString = "server='localhost';database='webtech';uid='root';pwd=";
            MySqlCommand maCommande = new MySqlCommand();
            maCommande.CommandText = "UPDATE apprenant SET nom=@nom,postnom=@postnom1,prenom=@prenom,genre=@genre,numeroTel=@numeroTel,quartierEtCell=@quartierEtCell,dateInscription=@dateInscription,montant=@montant WHERE codeApp=@codeApp";
            maCommande.Connection = con;//
            maCommande.Parameters.Add("codeApp", MySqlDbType.VarChar).Value = textBox1.Text;
            maCommande.Parameters.Add("nom", MySqlDbType.VarChar).Value = txtNom;
            maCommande.Parameters.Add("postnom1", MySqlDbType.VarChar).Value = txtPostNom.Text;
            maCommande.Parameters.Add("prenom", MySqlDbType.VarChar).Value = txtPrenom.Text;
            maCommande.Parameters.Add("genre", MySqlDbType.VarChar).Value = comboBox1.Text;
            maCommande.Parameters.Add("numeroTel", MySqlDbType.VarChar).Value = txtNumTel.Text;
            maCommande.Parameters.Add("quartierEtCell", MySqlDbType.VarChar).Value = txtAdresse.Text;
            maCommande.Parameters.Add("dateInscription", MySqlDbType.DateTime).Value = dateTimePicker1.Value;
            maCommande.Parameters.Add("montant", MySqlDbType.Decimal).Value = txtMontant.Text;
            con.Open();
            if (maCommande.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Bien modifié");
                txtNom.Text = "";
                textBox1.Text = "";
                txtPostNom.Text = "";
                txtPrenom.Text = "";
                txtPostNom.Text = "";
                comboBox1.SelectedIndex = -1;
                txtPrenom.Text = "";
                txtMontant.Text = "";
                txtAdresse.Text = "";
                txtNumTel.Text = "";
            }
            else
            {
                MessageBox.Show("Erreur!");
            }
            con.Close();
           
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Voulez-vous vraiment supprimer?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.No)
            {
                return;
            }
            MySqlConnection con = new MySqlConnection();//création de l'objet con
            con.ConnectionString = "server='localhost';database='webtech';uid='root';pwd=";
            MySqlCommand maCommande = new MySqlCommand();
            maCommande.CommandText = "DELETE FROM `apprenant` WHERE  codeApp=@codeApp";
            maCommande.Connection = con;//
            maCommande.Parameters.Add("codeApp", MySqlDbType.VarChar).Value = dataGridView1.CurrentRow.Cells["codeApp"].Value.ToString();
            
            con.Open();
            if (maCommande.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Bien supprimé!");
                AfficherApprenants();
                
            }
            else
            {
                MessageBox.Show("Erreur!");
            }
            con.Close();
        }
    }
}
