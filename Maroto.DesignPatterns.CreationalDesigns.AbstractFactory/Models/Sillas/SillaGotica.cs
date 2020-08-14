using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Contracts;

namespace Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Sillas
{
    public class SillaGotica
        : ISilla
    {
        public string Sentarse()
        {
            return " Me siento en una silla gotica.";
        }
    }
}