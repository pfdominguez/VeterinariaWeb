using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinariaWeb.Model;
using VeterinariaWeb.Servicios;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

using System;


namespace VeterinariaWeb.Model
{
    public class Pacient
    {

        [Required, MaxLength(20)]
        public string NombrePaciente { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "El minimo son 3 caracteres y el maximo 15")]
        public string Apellido { get; set; }

        [Required, MaxLength(10)]
        public string NombreDueno { get; set; }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Debe ingresar el legajo"), Range(111111, 999999, ErrorMessage = "El rango debe ser entre...")]
        public int IdPaciente { get; set; }

        public bool Atendido { get; set; }
        [Required, MaxLength(10)]
        public string ClaseAnimal { get; set; }

        [Required(ErrorMessage = "Debe ingresar la fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }
       
        [Range(1, 3)]
        public int TipoAtencion { get; set; }

        public virtual List<Animal> Animales { get; set; }

        public string FotoRuta { get; set; }

        [NotMapped]
        public IFormFile Foto { get; set; }


    }
}
