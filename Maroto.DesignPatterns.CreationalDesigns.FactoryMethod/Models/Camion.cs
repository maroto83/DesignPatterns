using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Contracts;

namespace Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Models
{
    public class Camion
        : ITransporte
    {
        public string Entrega()
        {
            return " El Camion hace la entrega";
        }
    }
}