using trabajo2.Agregacion;
using trabajo2.Entities;
using trabajo2.Entities1;

//------------------------------------------------------entidades
//polimorfismo y caste (atributos)
Entity ve = new VehiculoElectrico(id: "1", placa: "hga223", horasCarga: 50.1);
var ve1 = (VehiculoElectrico)ve;
Console.WriteLine(ve1.HorasCarga);

//polimorfismo y caste (metodo)
Entity vg = new VehiculoGasolina(id: "2", placa: "hga223");
var vg1 = (VehiculoGasolina)vg;
vg1.ImprimirValores();


//-----------------------------------------entidades1
Entity1 vehiculo = new VehiculoElectrico1();
vehiculo.Arrancar();

Entity1 vehiculo2 = new VehiculoGasolina1();
vehiculo2.Arrancar();

Entity1 per = new Persona();
per.Arrancar();



//------------------------------------asociacio
var estudiante = new Estudiante(new Escuela());