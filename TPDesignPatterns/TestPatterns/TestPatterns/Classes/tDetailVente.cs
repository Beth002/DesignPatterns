using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Classes
{
    class tDetailVente
    {
        int id;
        string refProduit;
        int qte;
        float pu_vente;
        float pt;

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

        public string RefProduit
        {
            get
            {
                return refProduit;
            }

            set
            {
                refProduit = value;
            }
        }

        public int Qte
        {
            get
            {
                return qte;
            }

            set
            {
                qte = value;
            }
        }

        public float Pu_vente
        {
            get
            {
                return pu_vente;
            }

            set
            {
                pu_vente = value;
            }
        }

        public float Pt
        {
            get
            {
                return pt;
            }

            set
            {
                pt = value;
            }
        }
    }
}
