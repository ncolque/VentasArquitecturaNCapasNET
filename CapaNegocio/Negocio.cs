using CapaDatos;
namespace CapaNegocio
//RESPONSABILIDAD: Filtrar y buscar el saludo correspondiente a la opcion elegida por el usuario
{
    //CAPA 2 - Esto es una Libreria de Clases
    //Agregar referencia de proyecto con la Capa de Datos
    public class Negocio
    {
        Dato servicio;
        public Negocio()
        {
            servicio = new Dato();
        }
        public string DevolverSaludo(int opcion)
        {
            if (opcion == 1)
            {
                return servicio.Espaniol();
            }
            if (opcion == 2)
            {
                return servicio.Ingles();
            }
            else
            {
                return servicio.Frances();
            }
        }
    }
}