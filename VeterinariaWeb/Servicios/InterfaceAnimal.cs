using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinariaWeb.Model;

namespace VeterinariaWeb.Servicios
{
    public interface InterfaceAnimal
    {
        List<Animal> MostrarTodos();

        void Agregar(Animal animal);

        void Eliminar(Animal animal);

        void Modificar(Animal animal);
    }
}
