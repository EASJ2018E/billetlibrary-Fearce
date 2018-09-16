using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class Bil : Køretøj
    {
        
        public override DateTime Dato { get; set; }
        public override decimal Pris()
        {
            return 240;
        }

        public override string KøretøjType()
        {
            return "Bil";
        }
    }
}
