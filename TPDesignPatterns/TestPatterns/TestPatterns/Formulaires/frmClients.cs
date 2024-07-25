using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TestPatterns.Classes;

namespace TestPatterns.Formulaires
{
    public partial class frmClients : Form
    {

        public frmClients()
        {
            InitializeComponent();
        }

        void Actualiser()
        {
            txtId.Text = "";
            txtNom.Text = "";
            txtAdresse.Text = "";
            txtContact.Text = "";
            txtId.Text = "";
        }

        public void LoadList()
        {
            try
            {
                //Charger DataGrid
                listeClient.DataSource = clsPrincipale.GetInstance().Chargement("tClient");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de chargement", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            LoadList();
            //listeClient.DataSource = clsPrincipale.GetInstance().Chargement("tClient");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clsPrincipale.GetInstance().Supprimer("tClient", "id", txtId.Text);
            LoadList();
        }

        private void frmClients_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tClient cl = new tClient();
            cl.Noms = txtNom.Text;
            cl.Adresse = txtAdresse.Text;
            cl.Contact = txtContact.Text;
            clsPrincipale.GetInstance().EnregistrerClient(cl);
            LoadList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Actualiser();
            button2.Enabled = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            tClient cl = new tClient();
            cl.Id = int.Parse(txtId.Text);
            cl.Noms = txtNom.Text;
            cl.Adresse = txtAdresse.Text;
            cl.Contact = txtContact.Text;
            clsPrincipale.GetInstance().ModifierClient(cl);
            LoadList();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            clsPrincipale.GetInstance().Supprimer("tClient", "id", txtId.Text);
            LoadList();
        }

        public void Chargement_DataGrid()
        {
            if (listeClient.RowCount > 0)
            {
                txtId.Text = listeClient["id", listeClient.CurrentRow.Index].Value.ToString();
                txtNom.Text = listeClient["noms", listeClient.CurrentRow.Index].Value.ToString();
                txtAdresse.Text = listeClient["adresse", listeClient.CurrentRow.Index].Value.ToString();
                txtContact.Text = listeClient["contact", listeClient.CurrentRow.Index].Value.ToString();
            }
        }

        private void listeClient_DoubleClick(object sender, EventArgs e)
        {
            Chargement_DataGrid();
            button2.Enabled = false;
        }
    }
}
