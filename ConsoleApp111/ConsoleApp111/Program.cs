// See https://aka.ms/new-console-template for more information

using ConsoleApp111.Entities;
using ConsoleApp111.Fabricas;

IFactory factory = new Factory();

factory.BuildProfesor(1, "20000");


var estudiante = (Estudiante) factory.BuildEstudiante(2);
