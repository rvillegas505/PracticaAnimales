﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace PracticaAnimales.Repositorios
{
    public class AnimalRepositorio : BaseRepositorio, IAnimalRepositorio
    {

        public AnimalRepositorio(_20221CPracticaEFContext ctx) : base(ctx)
        {

        }

        public void Insertar(Animal entidad)
        {
            _Contexto.Animals.Add(entidad);
        }

        public List<Animal> ObtenerTodos()
        {
            return _Contexto.Animals.Include(o => o.IdTipoAnimalNavigation).ToList();
        }
    }
}
