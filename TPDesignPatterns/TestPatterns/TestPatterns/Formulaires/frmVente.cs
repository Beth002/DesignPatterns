using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestPatterns.Classes;

namespace TestPatterns.Formulaires
{
    public partial class frmVente : Form
    {
        public frmVente()
        {
            InitializeComponent();
        }

        void Actualiser()
        {
            txtDate.Text = "";
            cbClient.Text = null;
            txtId.Text = "";
        }

        private void LoadList()
        {
            listeVente.DataSource = clsPrincipale.GetInstance().Chargement("client");
        }

        private void frmVente_Load(object sender, EventArgs e)
        {
            LoadList();
            clsPrincipale.GetInstance().chargeCombo(cbClient, "noms", "tClient");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actualiser();
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tVente vente = new tVente();
            vente.Date_vente = DateTime.Parse(txtDate.Text);
            vente.Client = (clsPrincipale.GetInstance().GetIdByName("tClient", "noms", cbClient.Text)).ToString(); 
            clsPrincipale.GetInstance().EnregistrerVente(vente);
            LoadList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tVente vente = new tVente();
            vente.Date_vente = DateTime.Parse(txtDate.Text);
            vente.Client = (clsPrincipale.GetInstance().GetIdByName("tClient", "noms", cbClient.Text)).ToString(); ;
            vente.Id = int.Parse(txtId.Text);
            clsPrincipale.GetInstance().ModifierVente(vente);
            LoadList();
        }

        public void Chargement_DataGrid()
        {
            if (listeVente.RowCount > 0)
            {
                txtId.Text = listeVente["id", listeVente.CurrentRow.Index].Value.ToString();
                txtDate.Text = listeVente["date_vente", listeVente.CurrentRow.Index].Value.ToString();
                cbClient.Text = listeVente["refClient", listeVente.CurrentRow.Index].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clsPrincipale.GetInstance().Supprimer("tVente", "id", txtId.Text);
            LoadList();
        }

        private void listeVente_DoubleClick(object sender, EventArgs e)
        {
            Chargement_DataGrid();
            button2.Enabled = false;
        }
    }
}
