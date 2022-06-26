using System.Collections.Generic;

namespace PracticaAnimales.Servicios
{
    public interface IAnimalServicio
    {
        void Insertar(Animal entidad);

        List<Animal> ObtenerTodos();
    }
}
