using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Trabajador : IEstudiante
    {
        public void AsistirClases()
        {
            Console.WriteLine("el estudiante asiti a clases 8am");
        }

        public bool Estudiar()
        {
            return true;
        }

        public void HacerTareas()
        {
            throw new NotImplementedException();
        }

        public void RealizarEvaluaciones()
        {
            throw new NotImplementedException();
        }
    }
}
