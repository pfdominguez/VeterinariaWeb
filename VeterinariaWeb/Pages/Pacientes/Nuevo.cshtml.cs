using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinariaWeb.Servicios;
using VeterinariaWeb.Model;
using Microsoft.AspNetCore.Mvc.Rendering; // agrego para usar el seleclist


namespace VeterinariaWeb.Pages.Pacientes
{
    public class NuevoModel : PageModel
    {
        [BindProperty]
        public Pacient PacienteNuevo { get; set; }

        private InterfacePaciente _pacientesService;
        private InterfaceAnimal _animalService;

        public NuevoModel(InterfacePaciente pacientesService, InterfaceAnimal animalService)
        {
            _pacientesService = pacientesService;
            _animalService = animalService;
        }

        public void OnGet()
        {
            var animales = _animalService.MostrarTodos();
            ViewData["Animales"] = new SelectList(animales, "idAnimal", "tipoAnimal");
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _pacientesService.Agregar(PacienteNuevo);
                return RedirectToPage("Listado");

            }
            return Page();
        }

}   }
