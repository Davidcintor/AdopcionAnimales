using ManejoAdopciones.Models;
using ManejoAdopciones.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace ManejoAdopciones.Controllers
{
    public class MascotasAdopcionController : Controller
    {
        private readonly IRepositorioMascotasAdopcion repositorioMascotasAdopcion;

        public MascotasAdopcionController(IRepositorioMascotasAdopcion repositorioMascotasAdopcion)
        {
            this.repositorioMascotasAdopcion = repositorioMascotasAdopcion;
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(MascotaAdopcion mascotaAdopcion)
        {
            if (!ModelState.IsValid)
            {
                return View(mascotaAdopcion);
            }
            repositorioMascotasAdopcion.Crear(mascotaAdopcion);
            return View();
        }
    }
}