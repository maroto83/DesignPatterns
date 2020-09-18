using Maroto.DesignPatterns.StructuralDesigns.Adapter.Contracts;

namespace Maroto.DesignPatterns.StructuralDesigns.Adapter.Enchufes
{
    public class EnchufeAmericano
        : IEnchufeAmericano
    {
        public int Voltaje { get; }
        public int Bornes { get; }

        public EnchufeAmericano()
        {
            Voltaje = 110;
            Bornes = 3;
        }

        public string Flujo110V()
        {
            return $"Usando flujo americano ({Voltaje}V)";
        }


        public string ObtenerNumeroDeBornes()
        {
            return $"Este enchufe tiene {Bornes} bornes.";
        }
    }
}