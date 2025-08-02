using ManejoAdopciones.Models;

namespace ManejoAdopciones.Servicios
{
    public interface IRepositorioMascotasAdopcion
    {
        void Crear(MascotaAdopcion mascotaAdopcion);
    }
}