using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Harwares
{
    internal abstract class Harware
    {
        public void Conectar()
        {
            Console.WriteLine("conectar a la placa");
        }

        public abstract void ConeccionElectrica();
    }
}
