using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal interface IEstudiante
    {
        public const string Tipo = "1"; 

        public bool Estudiar();

        public void HacerTareas();

        public void AsistirClases();

        public void RealizarEvaluaciones();
    }
}
