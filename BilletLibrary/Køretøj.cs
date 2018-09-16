using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class Køretøj
    {
        /// <summary>
        /// Property til nummerplade
        /// </summary>
        public abstract string Nummerplade { get; set; }

        /// <summary>
        /// Property til dato
        /// </summary>
        public abstract DateTime Dato { get; set; }


        /// <summary>
        /// Bilens pris
        /// </summary>
        /// <returns>Pris som decimal</returns>
        public abstract decimal Pris();

        /// <summary>
        /// Køretøj type
        /// </summary>
        /// <returns>Køretøj som string</returns>
        public abstract string KøretøjType();

    }
}
