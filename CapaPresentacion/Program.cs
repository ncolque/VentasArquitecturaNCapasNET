// See https://aka.ms/new-console-template for more information
using CapaNegocio;
//RESPONSABILIDAD: Presentar opciones al usuario y mostrar el resultado correspondiente

//CAPA 1 - Esto es un Proyecto de Consola - Ejecutable
//Agregar referencia de proyecto con la Capa de Negocio

Negocio servicio = new Negocio();
Console.WriteLine("Elija el idioma de su preferencia");
Console.WriteLine("[1] Español [2] Ingles [3] Frances");
int opcion = int.Parse(Console.ReadLine());

Console.WriteLine(servicio.DevolverSaludo(opcion));

Console.ReadKey();