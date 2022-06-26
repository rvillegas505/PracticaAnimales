using System.Collections.Generic;
using PracticaAnimales.Repositorios;

namespace PracticaAnimales.Servicios
{
    public class TipoAnimalServicio : ITipoAnimalServicio
    {
        ITipoAnimalRepositorio _tipoAnimalRepositorio;
        public TipoAnimalServicio(ITipoAnimalRepositorio tipoAnimalRepositorio)
        {
            _tipoAnimalRepositorio = tipoAnimalRepositorio; 
        }
        public List<TipoAnimal> ObtenerTodos()
        {
            return _tipoAnimalRepositorio.ObtenerTodos();
        }
    }
}
