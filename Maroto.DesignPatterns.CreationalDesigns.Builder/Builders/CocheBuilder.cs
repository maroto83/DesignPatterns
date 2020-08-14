using Maroto.DesignPatterns.CreationalDesigns.Builder.Contracts;
using Maroto.DesignPatterns.CreationalDesigns.Builder.Models;

namespace Maroto.DesignPatterns.CreationalDesigns.Builder.Builders
{
    public class CocheBuilder
        : ICocheBuilder
    {
        private Coche _coche = new Coche();

        public CocheBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            _coche = new Coche();
        }

        public void SetAsientos(int numeroDeAsientos)
        {
            _coche.NumeroDeAsientos = numeroDeAsientos;
        }

        public void SetMotor(string motor)
        {
            _coche.Motor = motor;
        }

        public void SetOrdenadorABordo()
        {
            _coche.OrdenadorABordo = "Ordenador de abordo añadido.";
        }

        public void SetGPS()
        {
            _coche.GPS = "GPS añadido";
        }

        public Coche Build()
        {
            return _coche;
        }
    }
}