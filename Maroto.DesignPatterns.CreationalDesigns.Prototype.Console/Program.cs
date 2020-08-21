using Maroto.DesignPatterns.CreationalDesigns.Prototype.Models;
using Newtonsoft.Json;
using System;

namespace Maroto.DesignPatterns.CreationalDesigns.Prototype.Console
{
    class Program
    {
        private static Persona _persona1;
        private static Persona _persona2;
        private static Persona _persona3;

        static void Main()
        {
            _persona1 = RellenarPersona(42, new DateTime(1983, 3, 22), "Pedro", 1);
            _persona2 = _persona1.CopiaSuperficial();
            _persona3 = _persona1.CopiaProfunda();

            MostrarDatosPersonas("\nValores originales de las personas.");

            _persona1.Edad -= 10;
            _persona1.FechaNacimiento = _persona1.FechaNacimiento.AddYears(10);
            _persona1.Nombre = "Enrique";
            _persona1.InformacionAdicional = new InformacionAdicional(2);

            MostrarDatosPersonas("\nValores después de cambiar los datos de la persona 1.");

            System.Console.ReadLine();
        }

        private static void MostrarDatosPersonas(string mensaje)
        {
            System.Console.WriteLine(mensaje);
            MostrarDatosPersona(_persona1, 1);
            MostrarDatosPersona(_persona2, 2);
            MostrarDatosPersona(_persona3, 3);
        }

        private static void MostrarDatosPersona(Persona persona, int numeroPersona)
        {
            System.Console.WriteLine($"\nPersona {numeroPersona}: ");
            System.Console.WriteLine(JsonConvert.SerializeObject(persona));
        }

        private static Persona RellenarPersona(int edad, DateTime fechaNacimiento, string nombre, int identificacion)
        {
            var persona =
                new Persona
                {
                    Edad = edad,
                    FechaNacimiento = fechaNacimiento,
                    Nombre = nombre,
                    InformacionAdicional = new InformacionAdicional(identificacion)
                };

            return persona;
        }
    }
}