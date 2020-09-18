using Maroto.DesignPatterns.StructuralDesigns.Adapter.Contracts;

namespace Maroto.DesignPatterns.StructuralDesigns.Adapter.Enchufes
{
    public class EnchufeEuropeo
        : IEnchufeEuropeo
    {
        public int Voltaje { get; }
        public int Bornes { get; }

        public EnchufeEuropeo()
        {
            Voltaje = 220;
            Bornes = 2;
        }

        public string Flujo220V()
        {
            return $"Usando flujo europeo ({Voltaje}V)";
        }


        public string ObtenerNumeroDeBornes()
        {
            return $"Este enchufe tiene {Bornes} bornes.";
        }
    }
}