using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Estudiante : IEstudiante
    {
        public void AsistirClases()
        {
            Console.WriteLine("el estudiante asiti a clases 1 pm");
        }

        public bool Estudiar()
        {
            throw new NotImplementedException();
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
