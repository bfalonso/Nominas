using System;
using System.Collections.Generic;
using System.Text;

namespace Nominas.Core
{
    class Obrero:Empleado
    {
        public const int SalarioPorHoraPrefijado = 50;
        public Obrero(string n) : base(n, SalarioPorHoraPrefijado)
        {

        }

        public override string ToString()
        {
            return base.ToString()+ " (obrero)";
        }


    }
}
