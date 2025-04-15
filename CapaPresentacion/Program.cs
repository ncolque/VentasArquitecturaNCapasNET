// See https://aka.ms/new-console-template for more information
using CapaNegocio;

Negocio servicio = new Negocio();
Console.WriteLine("Elija el idioma de su preferencia");
Console.WriteLine("[1] Español [2] Ingles [3] Frances");
int opcion = int.Parse(Console.ReadLine());

Console.WriteLine(servicio.DevolverSaludo(opcion));

Console.ReadKey();