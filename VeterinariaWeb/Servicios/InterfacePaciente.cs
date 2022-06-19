using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinariaWeb.Model;


namespace VeterinariaWeb.Servicios
{
    public interface InterfacePaciente
    {
        List<Pacient> MostrarTodos();

        void Agregar(Pacient paciente);

        void Eliminar(Pacient paciente);

        void Modificar(Pacient paciente);
    }
}
