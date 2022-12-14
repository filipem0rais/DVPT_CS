namespace Exercice16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo(("Lion", "Gazelle"), ("Mistigri","Miaoumiam"), ("Bear","Poisson"));
            Console.WriteLine(zoo["Lion"]);
            Console.WriteLine(zoo["Mistigri"]);
            Console.WriteLine(zoo["Bear"]);
        }
    }
}