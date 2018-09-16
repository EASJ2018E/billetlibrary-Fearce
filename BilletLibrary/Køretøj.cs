using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class Køretøj
    {
        private string _nummerplade;
        private decimal _pris;

        /// <summary>
        /// Property til nummerplade - maks 7 i længde
        /// </summary>
        public virtual string Nummerplade
        {
            get => _nummerplade;
            set
            {
                _nummerplade = value;
                if (_nummerplade.Length > 7)
                {
                    throw new ArgumentOutOfRangeException("Nummerplade må ikke være længere end 7 tegn");
                }
            }
        }

        /// <summary>
        /// Property til dato
        /// </summary>
        public abstract DateTime Dato { get; set; }

        /// <summary>
        /// Property til brobizz
        /// </summary>
        public bool Brobizz { get; set; }

        /// <summary>
        /// Køretøjets pris
        /// </summary>
        /// <returns>Pris som decimal</returns>
        public abstract decimal Pris();

        /// <summary>
        /// Køretøjets total pris. -5% rabat hvis det er med Brobizz
        /// </summary>
        /// <returns>Total pris som decimal</returns>
        public virtual decimal TotalPris()
        {
            if (Brobizz)
            {
                return Pris() - (Pris() / 100 * 5);
            }
            return Pris();
        }

        /// <summary>
        /// Køretøj type
        /// </summary>
        /// <returns>Køretøj som string</returns>
        public abstract string KøretøjType();

    }
}
