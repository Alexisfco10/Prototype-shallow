using Prototype_shallow;

namespace Prototype
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal() { Patas=4, Nombre="Perro" };
            Animal animalClon = animal1.Clone() as Animal;
            animalClon.Nombre = "Gato";

            Console.WriteLine(animalClon.Nombre);            
            Console.WriteLine(animalClon.Patas);
            Console.ReadKey();
        }

    }

}