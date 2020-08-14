using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Contracts;

namespace Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Sofas
{
    public class SofaVictoriano
        : ISofa
    {
        public string Tumbarse()
        {
            return " Me tumbo en un sofa victoriano.";
        }
    }
}