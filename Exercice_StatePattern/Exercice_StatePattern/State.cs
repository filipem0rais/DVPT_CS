namespace Exercice_StatePattern
{
    internal abstract class State
    {
    
        public abstract State Allumer();
        public abstract State Eteindre();
        public abstract State Hiberner();
       
    }
}