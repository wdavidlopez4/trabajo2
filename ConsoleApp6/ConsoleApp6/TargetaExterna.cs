using ConsoleApp6.Harwares;
using ConsoleApp6.Perifericos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class TargetaExterna : Harware, IPeriferico
    {
        public override void ConeccionElectrica()
        {
            throw new NotImplementedException();
        }
    }
}
