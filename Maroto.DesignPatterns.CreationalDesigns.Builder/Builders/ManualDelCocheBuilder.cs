using Maroto.DesignPatterns.CreationalDesigns.Builder.Contracts;
using Maroto.DesignPatterns.CreationalDesigns.Builder.Models;

namespace Maroto.DesignPatterns.CreationalDesigns.Builder.Builders
{
    public class ManualDelCocheBuilder
        : ICocheBuilder
    {
        private ManualDelCoche _manualDelCoche = new ManualDelCoche();

        public ManualDelCocheBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _manualDelCoche = new ManualDelCoche();
        }

        public void SetAsientos(int numeroDeAsientos)
        {
            _manualDelCoche.NumeroDeAsientos = numeroDeAsientos;
        }

        public void SetMotor(string motor)
        {
            _manualDelCoche.Motor = motor;
        }

        public void SetOrdenadorABordo()
        {
            _manualDelCoche.OrdenadorABordo = "Descrito el ordenador de abordo en el manual.";
        }

        public void SetGPS()
        {
            _manualDelCoche.GPS = "Descrito el gps en el manual";
        }

        public ManualDelCoche Build()
        {
            return _manualDelCoche;
        }
    }
}