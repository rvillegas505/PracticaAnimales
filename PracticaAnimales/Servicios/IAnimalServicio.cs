using System.Collections.Generic;

namespace PracticaAnimales.Servicios
{
    public interface IAnimalServicio
    {
        void Insertar(Animal entidad);

        List<Animal> ObtenerTodos();

        List<Animal> ObtenerPorTipo(int idTipo);

        Animal ObtenerPorId(int idAnimal);

        void Eliminar(int idAnimal);

        void Modificar (Animal entidad);
        
    }
}
