using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Harwares
{
    internal class Procesador : Harware
    {
        public override void ConeccionElectrica()
        {
            Console.WriteLine("conecta a 4 v");
        }
    }
}
