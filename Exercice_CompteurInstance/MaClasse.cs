namespace Exercice_CompteurInstance;

public class MaClasse
{
    public static int instances = 0;

    public MaClasse()
    {
        instances++;
    }

    ~MaClasse()
    {
        instances--;
    }
}