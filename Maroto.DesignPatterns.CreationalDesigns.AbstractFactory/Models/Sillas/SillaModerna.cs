using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Contracts;

namespace Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Sillas
{
    public class SillaModerna
        : ISilla
    {
        public string Sentarse()
        {
            return " Me siento en una silla moderna.";
        }
    }
}