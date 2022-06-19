using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VeterinariaWeb.Model;
using VeterinariaWeb.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace VeterinariaWeb.Pages.Pacientes
{
    public class ListadoModel : PageModel
    {
        [BindProperty]
        public List<Pacient> Pacientes { get; set; }
        [BindProperty]
        public List<int> Numeros { get; set; }


        private InterfacePaciente _pacientesService;

        public ListadoModel(InterfacePaciente pacientesService)
        {
            this._pacientesService = pacientesService;
        }
        public void OnGet(string orden)
        {
            Pacientes = _pacientesService.MostrarTodos().ToList();

            if (orden == "PorNombrePaciente")
            {
                Pacientes = Pacientes.OrderBy(x => x.NombrePaciente).ToList();
            }
            else if (orden == "PorApellido")
            {
                Pacientes = Pacientes.OrderBy(x => x.Apellido).ToList();
            }
            else if (orden == "PorClaseAnimal")
            {
                Pacientes = Pacientes.OrderBy(x => x.ClaseAnimal).ToList();
            }
            else if (orden == "PorTipoAtencion")
            {
                Pacientes = Pacientes.OrderBy(x => x.TipoAtencion).ToList();
            }
            else if (orden == "PorAtendido")
            {
                Pacientes = Pacientes.OrderBy(x => x.Atendido).ToList();
            }
            else
            {
                Pacientes = Pacientes.OrderBy(x => x.IdPaciente).ToList();
            }


        }

        public void OnGetBorrar(int idborrar)
        {
            var paciborrar = _pacientesService.MostrarTodos().Where(x => x.IdPaciente == idborrar).First();
            _pacientesService.Eliminar(paciborrar);
            Pacientes = _pacientesService.MostrarTodos().ToList();
        }

        public void OnPostFiltrar(int idFiltro)
        {
            Pacientes = _pacientesService.MostrarTodos().Where(x => x.IdPaciente == idFiltro).ToList();
        }
    }
}
