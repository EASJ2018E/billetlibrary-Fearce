using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC
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
        /// MC pris
        /// </summary>
        /// <returns>Pris som decimal</returns>
        public decimal Pris()
        {
            return 125;
        }

        /// <summary>
        /// Køretøj type
        /// </summary>
        /// <returns>Køretøj som string</returns>
        public string Køretøj()
        {
            return "MC";
        }

    }
}
