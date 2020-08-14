using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Contracts;

namespace Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Mesillas
{
    public class MesillaModerna
        : IMesilla
    {
        public string Comer()
        {
            return " Como en una mesa moderna.";
        }
    }
}