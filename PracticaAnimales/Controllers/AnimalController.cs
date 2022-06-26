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
            ViewBag.TipoAnimal = _tipoAnimalServicio.ObtenerTodos();

            return View(animales);
        }

        [HttpPost]
        public ActionResult Listar(int? idTipoAnimal)
        {
            if (idTipoAnimal.HasValue)
            {
                List<Animal> animalesPortipo = _animalServicio.ObtenerPorTipo(idTipoAnimal.Value);
                List<TipoAnimal> tipoAnimales = _tipoAnimalServicio.ObtenerTodos();
                ViewBag.TipoAnimal = tipoAnimales;
                return View(animalesPortipo);
            }

            List<Animal> animales = _animalServicio.ObtenerTodos();
            
            return View(animales);
        }


    }
}
