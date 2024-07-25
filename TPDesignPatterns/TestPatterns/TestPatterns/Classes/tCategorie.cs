using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Classes
{
    class tCategorie
    {
        int id;
        string designation;

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

        public string Designation
        {
            get
            {
                return designation;
            }

            set
            {
                designation = value;
            }
        }

        //public int Id { get => id; set => id = value; }
        //public string Designation { get => designation; set => designation = value; }
    }
}
