using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinariaWeb.Servicios;
using VeterinariaWeb.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using Microsoft.AspNetCore.Hosting;


namespace VeterinariaWeb.Pages.Pacientes
{
    public class EditarModel : PageModel
    {
        [BindProperty]
        public Pacient PacienteBuscado { get; set; }


        private InterfacePaciente _pacientesService;
        private InterfaceAnimal _animalService;


        public EditarModel(InterfacePaciente pacientesService, InterfaceAnimal animalService)
        {
            _pacientesService = pacientesService;
            _animalService = animalService;

        }


        public void OnGet(int id)
        {
            var animales = _animalService.MostrarTodos();
            ViewData["Animales"] = new SelectList(animales, "idAnimal", "tipoAnimal");
            PacienteBuscado = _pacientesService.MostrarTodos().Where(x => x.IdPaciente == id).First();

        }
        public IActionResult OnPost()
        {
            _pacientesService.Modificar(PacienteBuscado);
            return RedirectToPage("Listado");
        }


    }
}
