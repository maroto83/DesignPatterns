using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Contracts;

namespace Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Models
{
    public class Barco
        : ITransporte
    {
        public string Entrega()
        {
            return " El Barco hace la entrega";
        }
    }
}