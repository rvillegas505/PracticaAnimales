using System.Collections.Generic;
using PracticaAnimales.Repositorios;

namespace PracticaAnimales.Servicios
{
    public class AnimalServicio : IAnimalServicio
    {
        IAnimalRepositorio _animalRepositorio;
        public AnimalServicio(IAnimalRepositorio AnimalRepositorio)
        {
            _animalRepositorio = AnimalRepositorio; 
        }

        public void Insertar(Animal entidad)
        {
            _animalRepositorio.Insertar(entidad);
            _animalRepositorio.SaveChanges();
        }

        public List<Animal> ObtenerTodos()
        {
            return _animalRepositorio.ObtenerTodos();
        }

        public List<Animal> ObtenerPorTipo(int idTipo)
        {
            return _animalRepositorio.ObtenerPorTipo(idTipo);
        }

    }
}
