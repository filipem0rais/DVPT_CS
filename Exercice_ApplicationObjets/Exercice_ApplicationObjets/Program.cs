namespace Exercice_ApplicationObjets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture f40 = new Voiture("rouge", 40, 450);

            f40.MettreEnMarche();
            f40.Avancer();
            

        }
    }
}