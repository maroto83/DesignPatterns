using Maroto.DesignPatterns.StructuralDesigns.Adapter.Contracts;
using System;

namespace Maroto.DesignPatterns.StructuralDesigns.Adapter.Adaptador
{
    public class AdaptadorAmericanoEuropeo
        : IEnchufeAmericano
    {
        private readonly IEnchufeEuropeo _enchufeEuropeo;

        public int Voltaje => _enchufeEuropeo.Voltaje / 2;

        public int Bornes => _enchufeEuropeo.Bornes + 1;

        public AdaptadorAmericanoEuropeo(IEnchufeEuropeo enchufeEuropeo)
        {
            _enchufeEuropeo =
                enchufeEuropeo
                ?? throw new ArgumentException(); ;
        }

        public string Flujo110V()
        {
            return $"Usando adaptador americano ({Voltaje}V)";
        }


        public string ObtenerNumeroDeBornes()
        {
            return $"Este adaptador tiene {Bornes} bornes.";
        }
    }
}