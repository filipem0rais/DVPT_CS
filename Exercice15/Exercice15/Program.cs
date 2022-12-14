namespace Exercice15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture v = new Voiture();
            Console.WriteLine("Vitesse de la voiture: {0}", v.Vitesse);
            v.Accelerer();
            Console.WriteLine("Vitesse de la voiture: {0}", v.Vitesse);
        }
    }
}