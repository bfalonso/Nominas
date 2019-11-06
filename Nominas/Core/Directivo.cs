using System;
using System.Collections.Generic;
using System.Text;

namespace Nominas.Core
{
    class Directivo:Empleado
    {
        public const int SalarioBase = 1000;
        public const int SalarioPorHoraPrefijado = 100;
        public Directivo(string n) : base(n, SalarioPorHoraPrefijado)
        {

        }

        public override int CalculaNomina(int horas)
        {
            return base.CalculaNomina(horas) + SalarioBase;
        }

        public override string ToString()
        {
            return base.ToString() + " (directivo)";
        }
    }
}
