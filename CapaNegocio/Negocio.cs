using CapaDatos;
namespace CapaNegocio
{
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