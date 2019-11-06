using System;
using System.Collections.Generic;
using System.Text;

namespace Nominas.Core
{
    public abstract class Empleado
    {
        //Clase abstracta, no se pueden crear objetos, constructor protected
        protected Empleado(string nombre, int salarioPorHora)
        {
            this.Nombre = nombre;
            this.SalarioPorHora = salarioPorHora;
        }

        public string Nombre
        {
            get;set;
        }

        public int SalarioPorHora
        {
            get;set;
        }

        public virtual int CalculaNomina(int horas)
        {
            return horas * this.SalarioPorHora;
        }

        public override string ToString()
        {
            return "Empleado: " +this.Nombre + "  Salario/hora: " +this.SalarioPorHora;
        }
    }
}
