using Dapper;
using ManejoAdopciones.Models;
using Microsoft.Data.SqlClient;

namespace ManejoAdopciones.Servicios
{
    public class RepositorioMascotasAdopcion : IRepositorioMascotasAdopcion
    {
        private readonly string connectionString;

        public RepositorioMascotasAdopcion(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Crear(MascotaAdopcion mascotaAdopcion)
        {
            using var connection = new SqlConnection(connectionString);
            var id = connection.QuerySingle<int>(@"
                INSERT INTO MascotasAdopcion (Nombre, Especie, Raza, Edad, NombreAdoptante, EmailAdoptante, TelefonoAdoptante)
                VALUES (@Nombre, @Especie, @Raza, @Edad, @NombreAdoptante, @EmailAdoptante, @TelefonoAdoptante);
                SELECT SCOPE_IDENTITY();", mascotaAdopcion);
            mascotaAdopcion.Id = id;
        }
    }
}