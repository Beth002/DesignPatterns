using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestPatterns.Formulaires;

namespace TestPatterns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmClients Client = new frmClients();
            Client.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCategorie Categorie = new frmCategorie();
            Categorie.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmProduit Produit = new frmProduit();
            Produit.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmVente Vente = new frmVente();
            Vente.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmDetailVente dVente = new frmDetailVente();
            dVente.ShowDialog();
        }
    }
}
