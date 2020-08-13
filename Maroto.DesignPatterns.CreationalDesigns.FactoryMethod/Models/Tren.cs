using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Contracts;

namespace Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Models
{
    public class Tren
        : ITransporte
    {
        public string Entrega()
        {
            return " El Tren hace la entrega";
        }
    }
}