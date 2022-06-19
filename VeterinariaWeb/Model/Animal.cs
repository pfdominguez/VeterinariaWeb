using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace VeterinariaWeb.Model
{
    public class Animal
    {
        [Key]
        public int idAnimal { get; set; }

        public string tipoAnimal { get; set; }

        public virtual List<Pacient> Pacients { get; set; }

    }
}
