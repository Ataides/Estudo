﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException() : base ("Saldo insuficiente")
        {

        }
    }
}