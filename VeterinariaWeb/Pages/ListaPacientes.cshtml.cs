using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VeterinariaWeb.Servicios;
using VeterinariaWeb.Model;

namespace VeterinariaWeb.Pages.Shared
{
    public class ListaPacientesModel : PageModel
    {
        [BindProperty]
        public Pacient pacientes1 { get; set; }

        private InterfacePaciente _pacienteService;

        public ListaPacientesModel(InterfacePaciente pacienteService)
        {
            _pacienteService = pacienteService;
        }

        public void OnGet()
        {


        }


        public void OnPost()
        {
            var paci = pacientes1;
            _pacienteService.Agregar(paci);
        }
    }
}
