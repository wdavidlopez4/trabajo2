using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Perifericos
{
    internal class Parlante : IPeriferico
    {
        public void Conectar()
        {
            Console.WriteLine("se conecto un Parlante por b");
        }
    }
}
