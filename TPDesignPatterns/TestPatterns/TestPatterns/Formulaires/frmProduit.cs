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
    public partial class frmProduit : Form
    {
        public frmProduit()
        {
            InitializeComponent();
        }

        void Actualiser()
        {
            txtNom.Text = "";
            txtPU.Text = "";
            cbCategorie.Text = null;
            txtId.Text = "";
        }

        private void LoadList()
        {
            listeProduit.DataSource = clsPrincipale.GetInstance().Chargement("produit");
        }

        private void frmProduit_Load(object sender, EventArgs e)
        {
            LoadList();
            //clsPrincipale.GetInstance().chargeCombo(cbCategorie, "designation", "tCategorie");
            clsPrincipale.GetInstance().ChargeCombobox(cbCategorie, "designation", "id", "tCategorie");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actualiser();
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tProduit prod = new tProduit();
            
            prod.Nom_produit = txtNom.Text;
            prod.Pu = float.Parse(txtPU.Text);
            prod.Categorie = (clsPrincipale.GetInstance().GetIdByName("tCategorie","designation", cbCategorie.Text)).ToString();
            clsPrincipale.GetInstance().EnregistrerProduit(prod);
            LoadList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tProduit prod = new tProduit();
            prod.Nom_produit = txtNom.Text;
            prod.Pu = float.Parse(txtPU.Text);
            prod.Categorie = (clsPrincipale.GetInstance().GetIdByName("tCategorie", "designation", cbCategorie.Text)).ToString(); ;
            prod.Id = int.Parse(txtId.Text);
            clsPrincipale.GetInstance().ModifierProduit(prod);
            LoadList();
        }

        public void Chargement_DataGrid()
        {
            if (listeProduit.RowCount > 0)
            {
                txtId.Text = listeProduit["id", listeProduit.CurrentRow.Index].Value.ToString();
                txtNom.Text = listeProduit["nom_produit", listeProduit.CurrentRow.Index].Value.ToString();
                txtPU.Text = listeProduit["pu", listeProduit.CurrentRow.Index].Value.ToString();
                cbCategorie.Text = listeProduit["categorie", listeProduit.CurrentRow.Index].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clsPrincipale.GetInstance().Supprimer("tProduit", "id", txtId.Text);
            LoadList();
        }

        private void listeProduit_DoubleClick(object sender, EventArgs e)
        {
            Chargement_DataGrid();
            button2.Enabled = false;
        }

        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
