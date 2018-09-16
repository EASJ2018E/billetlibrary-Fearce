using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class Bil
    {
        /// <summary>
        /// Property til nummerplade
        /// </summary>
        public string Nummerplade { get; set; }

        /// <summary>
        /// Property til dato
        /// </summary>
        public DateTime Dato { get; set; }


        /// <summary>
        /// Bilens pris
        /// </summary>
        /// <returns>Pris som decimal</returns>
        public decimal Pris()
        {
            return 240;
        }

        /// <summary>
        /// Køretøj type
        /// </summary>
        /// <returns>Køretøj som string</returns>
        public string Køretøj()
        {
            return "Bil";
        }
    }
}
