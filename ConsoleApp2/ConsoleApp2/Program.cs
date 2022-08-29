// See https://aka.ms/new-console-template for more information

using ConsoleApp2;


//polimorfismo
Entidad persona = new Persona("juan", "gomez");
persona.ImprimirValores();


//casteo
var persona1 = (Persona) persona;
persona1.ImprimirApellido();

