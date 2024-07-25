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
    public partial class frmDetailVente : Form
    {
        public frmDetailVente()
        {
            InitializeComponent();
        }

        void Actualiser()
        {
            txtPu.Text = "";
            txtQte.Text = "";
            cbProduit.Text = null;
            txtId.Text = "";
        }

        private void LoadList()
        {
            listeProduit.DataSource = clsPrincipale.GetInstance().Chargement("vente");
        }

        private void frmDetailVente_Load(object sender, EventArgs e)
        {
            LoadList();
            clsPrincipale.GetInstance().chargeCombo(cbProduit, "nom_produit", "tProduit");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actualiser();
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tDetailVente dVente = new tDetailVente();
            dVente.RefProduit = (clsPrincipale.GetInstance().GetIdByName("tProduit", "nom_produit", cbProduit.Text)).ToString();
            dVente.Qte = int.Parse(txtQte.Text);
            dVente.Pu_vente = float.Parse(txtPu.Text);
            clsPrincipale.GetInstance().EnregistrerDetailVente(dVente);
            LoadList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tDetailVente dVente = new tDetailVente();
            dVente.RefProduit = (clsPrincipale.GetInstance().GetIdByName("tproduit", "nom_produit", cbProduit.Text)).ToString();
            dVente.Qte = int.Parse(txtQte.Text);
            dVente.Pu_vente = float.Parse(txtPu.Text);
            dVente.Id = int.Parse(txtId.Text);
            clsPrincipale.GetInstance().ModifierDetailVente(dVente);
            LoadList();
        }

        public void Chargement_DataGrid()
        {
            if (listeProduit.RowCount > 0)
            {
                txtId.Text = listeProduit["id", listeProduit.CurrentRow.Index].Value.ToString();
                cbProduit.Text = listeProduit["refProduit", listeProduit.CurrentRow.Index].Value.ToString();
                txtQte.Text = listeProduit["qte", listeProduit.CurrentRow.Index].Value.ToString();
                txtPu.Text = listeProduit["pu_vente", listeProduit.CurrentRow.Index].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clsPrincipale.GetInstance().Supprimer("tDetailVente", "id", txtId.Text);
            LoadList();
        }

        private void listeProduit_DoubleClick(object sender, EventArgs e)
        {
            Chargement_DataGrid();
            button2.Enabled = false;
        }
    }
}
