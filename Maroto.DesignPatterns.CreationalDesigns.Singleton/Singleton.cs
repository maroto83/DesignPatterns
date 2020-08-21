using System;

namespace Maroto.DesignPatterns.CreationalDesigns.Singleton
{
    public class Singleton
    {
        private static Singleton _instancia;
        private Singleton()
        {
        }

        public static Singleton GetInstancia()
        {
            return _instancia ?? (_instancia = new Singleton());
        }

        public void OperacionConcreta()
        {
            Console.WriteLine("La instancia singleton hace una operación.");
        }
    }
}