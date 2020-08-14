using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Contracts;

namespace Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Sofas
{
    public class SofaGotico
        : ISofa
    {
        public string Tumbarse()
        {
            return " Me tumbo en un sofa gotico.";
        }
    }
}