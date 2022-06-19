using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinariaWeb.Model;

namespace VeterinariaWeb.Servicios
{
    public class AnimalService : InterfaceAnimal
    {
        private List<Animal> animales;

        public AnimalService()
        {
            animales = new List<Animal>()
            {
                new Animal() { idAnimal = 1, tipoAnimal= "Perro"},
                new Animal() { idAnimal = 2, tipoAnimal="Gato"},
                new Animal() { idAnimal = 3, tipoAnimal="Ave"},
                new Animal() { idAnimal = 4, tipoAnimal="Puma"}
            };
        }

        public List<Animal> MostrarTodos()
        {
            return animales;
        }

        public void Agregar(Animal animal)
        {
            animales.Add(animal);
        }

        public void Eliminar(Animal animal)
        {
            var Animalanterior = animales.Where(x => x.idAnimal == animal.idAnimal).First();
            animales.Remove(Animalanterior);
        }

        public void Modificar(Animal ani)
        {
            var Animalanterior = animales.Where(x => x.idAnimal == ani.idAnimal).First();
            animales.Remove(Animalanterior);
            animales.Add(ani);
        }
    }
}