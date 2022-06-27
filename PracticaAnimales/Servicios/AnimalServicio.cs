using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PracticaAnimales.Repositorios;

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

    }
}
