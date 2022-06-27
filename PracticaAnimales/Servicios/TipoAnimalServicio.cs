using System.Collections.Generic;
using System.Linq;
using PracticaAnimales.Repositorios;

namespace PracticaAnimales.Servicios
{
    public class TipoAnimalServicio : ITipoAnimalServicio
    {
        _20221CPracticaEFContext _contexto;
        public TipoAnimalServicio(_20221CPracticaEFContext contexto)
        {
            _contexto = contexto; 
        }
        public List<TipoAnimal> ObtenerTodos()
        {
            return _contexto.TipoAnimals.ToList();
        }
    }
}
