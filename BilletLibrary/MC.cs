using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : Køretøj
    {
        /// <inheritdoc />
        public override DateTime Dato { get; set; }

        /// <inheritdoc />
        public override bool Brobizz { get; set; }

        /// <inheritdoc />
        public override decimal Pris()
        {
            return 125;
        }

        /// <inheritdoc />
        public override string KøretøjType()
        {
            return "MC";
        }

    }
}
