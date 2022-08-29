using ConsoleApp1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Factory
{
    public static class FactoryEntidades
    {
        public static Entidad CrearEscuela()
        {
            return new Escuela();
        }

        public static Entidad CrearProfesor()
        {
            return new Profesor();
        }

        public static Entidad CrearEstudiante()
        {
            return new Estudiante();
        }
    }
}
