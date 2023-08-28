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
    public partial class ModuleUC : UserControl
    {
        public ModuleUC()
        {
            InitializeComponent();
        }

        private void ModuleUC_Load(object sender, EventArgs e)
        {
            AfficherModules();
        }
        
        private bool champsOk()
        {
            if (txtCodeMod.Text != "" && txtIntitule.Text != "")
            {
                return true;
            }
            return false;
        }
        private void NotifierErreur()
        {
            if (txtIntitule.Text == "")
            {
                errorProvider1.SetError(txtIntitule, "Ce champ est obligatoire");
            }
            else
            {
                errorProvider1.SetError(txtIntitule, "");
            }
            if (txtCodeMod.Text == "")
            {
                errorProvider1.SetError(txtCodeMod, "Ce champ est obligatoire");
            }
            else
            {
                errorProvider1.SetError(txtCodeMod, "");
            }
        }

        private void AfficherModules()
        {
            MySqlConnection maConnexion = new MySqlConnection();
            maConnexion.ConnectionString = "server='localhost';database='webtech';uid='root';pwd=''";
            MySqlCommand maCommande = new MySqlCommand();
            maCommande.CommandText = "select * from module";
            maCommande.Connection = maConnexion;
            maConnexion.Open();
            MySqlDataAdapter canal = new MySqlDataAdapter();
            DataTable table = new DataTable();
            canal.SelectCommand = maCommande;
            canal.Fill(table);
            dataGridView1.DataSource = table;
            maConnexion.Close();
        }
        private void Vider()
        {
            txtCodeMod.Text = "";
            txtIntitule.Text = "";
        }

        bool update;
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!champsOk())
            {
                NotifierErreur();
                return;
            }
            MySqlConnection volonte = new MySqlConnection();
            volonte.ConnectionString = "server='localhost';database='webtech';uid='root';pwd=''";
            MySqlCommand sarah = new MySqlCommand();
            sarah.Connection = volonte;
            volonte.Open();
            if (update == true)
            {
                sarah.CommandText = "UPDATE `module` SET `intitule`=@intitule WHERE `codeMod`=@codeMod";
                sarah.Parameters.Add("codeMod", MySqlDbType.VarChar).Value = txtCodeMod.Text;
                sarah.Parameters.Add("intitule", MySqlDbType.VarChar).Value = txtIntitule.Text;

                if (sarah.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Bien modifié!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AfficherModules();
                    Vider();

                }
                else
                {
                    MessageBox.Show("Erreur");
                }
            }
            else
            {
                sarah.CommandText = "INSERT INTO `module`(`codeMod`, `intitule`) VALUES (@codeMod,@intitule)";
                sarah.Parameters.Add("codeMod", MySqlDbType.VarChar).Value = txtCodeMod.Text;
                sarah.Parameters.Add("intitule", MySqlDbType.VarChar).Value = txtIntitule.Text;
                if (sarah.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Bien enregistré!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AfficherModules();
                    Vider();

                }
                else
                {
                    MessageBox.Show("Erreur");
                }
            }
        }


        private void btnModifier_Click(object sender, EventArgs e)
        {
            update = true;
             txtIntitule.Text=dataGridView1.CurrentRow.Cells["intitule"].Value.ToString();
             txtCodeMod.Text = dataGridView1.CurrentRow.Cells["codemod"].Value.ToString();
             txtCodeMod.ReadOnly = true;
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
            maCommande.CommandText = "DELETE FROM `module` WHERE   codeMod=@codem";
            maCommande.Connection = con;//
            maCommande.Parameters.Add("codem", MySqlDbType.VarChar).Value = dataGridView1.CurrentRow.Cells["codeMod"].Value.ToString();

            con.Open();
            if (maCommande.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Bien supprimé!");
                AfficherModules();

            }
            else
            {
                MessageBox.Show("Erreur!");
            }
            con.Close();
        }

        private void txtCodeMod_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCodeMod, "");
        }

        private void txtIntitule_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtIntitule, "");
        }
    }
}
