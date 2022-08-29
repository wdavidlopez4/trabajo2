﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal abstract class Entidad
    {
        public string Name { get; protected set; }

        protected Entidad(string Name)
        {
            this.Name = Name;
        }

        public void ImprimirValores()
        {
            Console.WriteLine($"{this.Name}");
        }
    }
}
