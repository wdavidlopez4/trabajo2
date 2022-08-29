// See https://aka.ms/new-console-template for more information
using ConsoleApp6;
using ConsoleApp6.Computadores;
using ConsoleApp6.Perifericos;

Console.WriteLine("Hello, World!");

//crear perifericos
IPeriferico periferico = new Teclado();
IPeriferico periferico1 = new TargetaExterna();


Computadora computadora = new Computadora(periferico, periferico1);
