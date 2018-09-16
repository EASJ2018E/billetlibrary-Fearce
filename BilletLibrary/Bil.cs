using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    class Bil
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }



        public decimal Pris()
        {
            return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }
    }
}
