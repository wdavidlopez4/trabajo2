using ConsoleApp6.Harwares;
using ConsoleApp6.Perifericos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Computadores
{
    internal class Computadora
    {
        private IPeriferico Periferico;

        private Harware RAM;

        private Harware Procesador;

        private IPeriferico periferico1;

        public Computadora(IPeriferico periferico, IPeriferico periferico1)
        {
            Periferico = periferico;

            //composicion
            this.RAM = new RAM();
            this.Procesador = new Procesador();
        }
    }
}
