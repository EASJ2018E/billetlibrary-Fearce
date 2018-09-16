﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class Bil : Køretøj
    {
        /// <inheritdoc />
        public override string Nummerplade { get; set; }

        /// <inheritdoc />
        public override DateTime Dato { get; set; }


        /// <inheritdoc />
        public override decimal Pris()
        {
            return 240;
        }

        /// <inheritdoc />
        public override string KøretøjType()
        {
            return "Bil";
        }
    }
}
