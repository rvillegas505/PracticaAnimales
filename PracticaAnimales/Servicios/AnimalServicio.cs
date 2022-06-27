using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PracticaAnimales.Servicios
{
    public class AnimalServicio : IAnimalServicio
    {
        _20221CPracticaEFContext _contexto;
        public AnimalServicio(_20221CPracticaEFContext contexto)
        {
            _contexto = contexto; 
        }

        public void Insertar(Animal entidad)
        {
            _contexto.Add(entidad);
            _contexto.SaveChanges();
        }

        public List<Animal> ObtenerTodos()
        {
            return _contexto.Animals.Include(o => o.IdTipoAnimalNavigation).ToList();
        }

        public List<Animal> ObtenerPorTipo(int idTipo)
        {
            return _contexto.Animals.Include(o => o.IdTipoAnimalNavigation).
                Where(o => o.IdTipoAnimal == idTipo).ToList();
        }

        public Animal ObtenerPorId(int idAnimal)
        {
            Animal animal = _contexto.Animals.Where(o => o.IdAnimal == idAnimal).FirstOrDefault();
            if (animal == null)
                throw new ArgumentException("No se puede borrar el animal, ya que no se encuentra disponible.");
            return animal;
        }

        public void Eliminar(int idAnimal)
        {
            Animal animalABorrar = ObtenerPorId(idAnimal);
            _contexto.Remove(animalABorrar);
            _contexto.SaveChanges();
        }

        
    }
}
