// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Entidades;
using ConsoleApp1.Factory;

Console.WriteLine("Hello, World!");

var escuela = (Escuela)FactoryEntidades.CrearEscuela();
escuela.Direccion = "xxxxxxx";
Console.WriteLine(escuela.Direccion);

//creacion de las demas entidad (TODO)





