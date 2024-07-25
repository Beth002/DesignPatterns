using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Classes
{
    class tClient
    {
        int id;
        string noms;
        string adresse;
        string contact;

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

        public string Noms
        {
            get
            {
                return noms;
            }

            set
            {
                noms = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string Contact
        {
            get
            {
                return contact;
            }

            set
            {
                contact = value;
            }
        }

        //public int Id { get => id; set => id = value; }
        //public string Noms { get => noms; set => noms = value; }
        //public string Adresse { get => adresse; set => adresse = value; }
        //public string Contact { get => contact; set => contact = value; }
    }
}
