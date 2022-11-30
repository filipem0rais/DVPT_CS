using Exercice1_Heritage;

namespace Exercice2_Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animaux = new Animal[3];
            animaux[0] = new Chien();
            animaux[1] = new Oiseau();
            animaux[2] = new ChienPourAveugle();
            
            foreach (Animal animal in animaux)
            {
                Console.WriteLine(animal.Manger());
            }
            Console.WriteLine("--------------------");


            Console.WriteLine((animaux[2] as ChienPourAveugle).Manger());
            
            Console.WriteLine(((ChienPourAveugle)animaux[2]).Manger());
        }
    }
}