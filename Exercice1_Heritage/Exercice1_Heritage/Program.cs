using System.Collections.ObjectModel;

namespace Exercice1_Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal chien = new Chien();
            Animal oiseau = new Oiseau();

           // Console.WriteLine(chien.Manger());
           // Console.WriteLine(oiseau.Manger());


            Collection<Animal> animaux = new Collection<Animal>();

            animaux.Add(chien);
            animaux.Add(oiseau);
            animaux.Add(new Chien());
            animaux.Add(new Oiseau());

            Console.WriteLine("Affichage de la collection");
            foreach (Animal animal in animaux)
            {
                Console.WriteLine(animal.Manger());
            }

        }
    }
}