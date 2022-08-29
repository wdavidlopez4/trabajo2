using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Persona : Entidad
    {
        public string FirstName { get; private set; }

        public Persona(string name, string firstName):base(name)
        {
            FirstName = firstName;
        }

        public void ImprimirApellido()
        {
            Console.WriteLine($"{this.FirstName}");
        }
    }
}
