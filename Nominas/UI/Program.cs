using System;
using Nominas.Core;

namespace Nominas.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Directivo("Tio Gilito");
            var o = new Obrero("Pato Donald");
		var j = new Obrero("Jaime");

            Console.Write(d);
            //Console.WriteLine("  Nomina: " + d.CalculaNomina(10));
            Console.Write(o);
            //Console.WriteLine("  Nomina: " + o.CalculaNomina(10));
        }
    }
}
