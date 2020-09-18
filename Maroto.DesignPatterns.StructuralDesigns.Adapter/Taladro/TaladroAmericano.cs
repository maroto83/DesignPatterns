using Maroto.DesignPatterns.StructuralDesigns.Adapter.Contracts;
using System;

namespace Maroto.DesignPatterns.StructuralDesigns.Adapter.Taladro
{
    public class TaladroAmericano
    {
        private readonly IEnchufeAmericano _enchufeAmericano;
        public TaladroAmericano(IEnchufeAmericano enchufeAmericano)
        {
            _enchufeAmericano =
                enchufeAmericano
                ?? throw new ArgumentException();
        }

        public void Encender()
        {
            var flujoElectrico = _enchufeAmericano.Flujo110V();
            Console.WriteLine($"El Taladro está funcionando con { flujoElectrico }");
        }
    }
}