using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Classes
{
    class tVente
    {
        int id;
        DateTime date_vente;
        string client;

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

        public DateTime Date_vente
        {
            get
            {
                return date_vente;
            }

            set
            {
                date_vente = value;
            }
        }

        public string Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }
    }
}
