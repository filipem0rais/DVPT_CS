namespace Exercice_StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ordinateur ordinateur = new Ordinateur();
            
            ordinateur.Allumer();
            
            ordinateur.Eteindre();

            ordinateur.Eteindre();

            ordinateur.Hiberner();

            ordinateur.Allumer();

            ordinateur.Allumer();

            ordinateur.Hiberner();

        }
    }
}