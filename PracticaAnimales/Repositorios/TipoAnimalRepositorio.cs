using System.Collections.Generic;
using System.Linq;

namespace PracticaAnimales.Repositorios
{
    public class TipoAnimalRepositorio : BaseRepositorio, ITipoAnimalRepositorio
    {

        public TipoAnimalRepositorio(_20221CPracticaEFContext ctx) : base(ctx)
        {
      
        }
        public List<TipoAnimal> ObtenerTodos()
        {
            return _Contexto.TipoAnimals.ToList();
        }
    }
}
