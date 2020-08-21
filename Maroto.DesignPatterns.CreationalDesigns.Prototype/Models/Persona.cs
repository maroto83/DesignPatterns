using System;

namespace Maroto.DesignPatterns.CreationalDesigns.Prototype.Models
{
    public class Persona
    {
        public int Edad;
        public DateTime FechaNacimiento;
        public string Nombre;
        public InformacionAdicional InformacionAdicional;

        public Persona CopiaSuperficial()
        {
            return (Persona)MemberwiseClone();
        }

        public Persona CopiaProfunda()
        {
            var clonedPerson = CopiaSuperficial();

            clonedPerson.InformacionAdicional = new InformacionAdicional(InformacionAdicional.Identificacion);
            clonedPerson.Nombre = string.Copy(Nombre);

            return clonedPerson;
        }

    }
}