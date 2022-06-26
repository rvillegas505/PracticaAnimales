using System.Collections.Generic;

namespace PracticaAnimales.Repositorios
{
    public interface IAnimalRepositorio
    {
        void Insertar (Animal entidad);

        List<Animal> ObtenerTodos ();

        List<Animal> ObtenerPorTipo(int idTipo);

        void SaveChanges();


    }
}
