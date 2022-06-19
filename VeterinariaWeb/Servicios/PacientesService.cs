using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinariaWeb.Model;



namespace VeterinariaWeb.Servicios
{
    public class PacientesService : InterfacePaciente
    {

        private List<Pacient> pacientes;

        public PacientesService()
        {
            pacientes = new List<Pacient>()
            {
                new Pacient(){IdPaciente=111101,NombrePaciente="coco", Apellido="Rodriguez", NombreDueno="carlos",FechaNacimiento = new DateTime (2014,05,04),ClaseAnimal="Gato",TipoAtencion=1,Atendido=true},
                new Pacient(){IdPaciente=111102,NombrePaciente="pepe", Apellido="Martinez", NombreDueno="Pablo",FechaNacimiento= new DateTime (2017,02,20),ClaseAnimal="Perro",TipoAtencion=2,Atendido=false},
                new Pacient(){IdPaciente=111103,NombrePaciente="carlitos", Apellido="Roldan", NombreDueno="Luis",FechaNacimiento= new DateTime (2018,11,14),ClaseAnimal="Ave",TipoAtencion=3,Atendido=false},
                new Pacient(){IdPaciente=111104,NombrePaciente="Ardilla", Apellido="Benitez", NombreDueno="Emanuel",FechaNacimiento= new DateTime (2020,01,14),ClaseAnimal="Gato", TipoAtencion=1,Atendido=true},
                new Pacient(){IdPaciente=111105,NombrePaciente="Chispita", Apellido="Peralta", NombreDueno="Analia",FechaNacimiento= new DateTime (2021,08,08),ClaseAnimal="Ave",TipoAtencion=3,Atendido=true},
                new Pacient(){IdPaciente=111106,NombrePaciente="Ana", Apellido="Navarro", NombreDueno="Estevan",FechaNacimiento= new DateTime (2019,06,22),ClaseAnimal="Ave",TipoAtencion=2,Atendido=false},
                new Pacient(){IdPaciente=111107,NombrePaciente="Federico", Apellido="Patiño", NombreDueno="Emiliano",FechaNacimiento=new DateTime (2017,07,12),ClaseAnimal="Gato",TipoAtencion=2,Atendido=true},
                new Pacient(){IdPaciente=111108,NombrePaciente="Olivia", Apellido="Dominguez", NombreDueno="Pablo",FechaNacimiento= new DateTime (2019,08,18),ClaseAnimal="Perro",TipoAtencion=1,Atendido=true},
                new Pacient(){IdPaciente=111109,NombrePaciente="Panchito", Apellido="Kallweit", NombreDueno="Ines",FechaNacimiento= new DateTime (2017,09,29),ClaseAnimal="Perro",TipoAtencion=1,Atendido=false},
                new Pacient(){IdPaciente=111110,NombrePaciente="July", Apellido="Salguero", NombreDueno="Daniela",FechaNacimiento= new DateTime (2020,03,22),ClaseAnimal="Gato",TipoAtencion=3,Atendido=true}
            };

        }


        public List<Pacient> MostrarTodos()
        {
            return pacientes;
        }

        public void Agregar(Pacient paciente)
        {
            pacientes.Add(paciente);
        }

        public void Eliminar(Pacient paciente)
        {
            var pacienteanterior = pacientes.Where(x => x.IdPaciente == paciente.IdPaciente).First();
            pacientes.Remove(pacienteanterior);

        }

        public void Modificar(Pacient paciente)
        {
            var pacienteanterior = pacientes.Where(x => x.IdPaciente == paciente.IdPaciente).First();
            pacientes.Remove(pacienteanterior);
            pacientes.Add(paciente);

        }
    }
}
