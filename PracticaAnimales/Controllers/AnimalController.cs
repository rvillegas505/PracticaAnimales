using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticaAnimales.Servicios;
using System.Collections.Generic;

namespace PracticaAnimales.Controllers
{
    public class AnimalController : Controller
    {
        ITipoAnimalServicio _tipoAnimalServicio;
        IAnimalServicio _animalServicio;
        public AnimalController(ITipoAnimalServicio tipoAnimalServicio, IAnimalServicio animalServicio)
        {
            _tipoAnimalServicio = tipoAnimalServicio;
            _animalServicio = animalServicio;
        }

        [HttpGet]
        public ActionResult Alta()
        {
            List<TipoAnimal> tipoAnimales = _tipoAnimalServicio.ObtenerTodos();
            ViewBag.TipoAnimal = tipoAnimales;
            return View();
        }

        [HttpPost]
        public ActionResult Alta(Animal animal)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.TipoAnimales = _tipoAnimalServicio.ObtenerTodos();
                return View(animal);
            }

            _animalServicio.Insertar(animal);
            return RedirectToAction("Listar"); 
        }

        [HttpGet]
        public ActionResult Listar()
        {
            List<Animal> animales = _animalServicio.ObtenerTodos();
            
            return View(animales);
        }


    }
}
