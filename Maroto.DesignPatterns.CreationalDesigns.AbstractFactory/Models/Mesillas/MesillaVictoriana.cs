using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Contracts;

namespace Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Mesillas
{
    public class MesillaVictoriana
        : IMesilla
    {
        public string Comer()
        {
            return " Como en una mesa Victoriana.";
        }
    }
}