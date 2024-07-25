using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Classes
{
    class tProduit
    {
        int id;
        string nom_produit;
        float pu;
        string categorie;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nom_produit
        {
            get
            {
                return nom_produit;
            }

            set
            {
                nom_produit = value;
            }
        }

        public float Pu
        {
            get
            {
                return pu;
            }

            set
            {
                pu = value;
            }
        }

        public string Categorie
        {
            get
            {
                return categorie;
            }

            set
            {
                categorie = value;
            }
        }
    }
}
