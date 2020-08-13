using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Clients;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Enums;

namespace Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            HacerEntrega(new LogisticaMaritima());
            HacerEntrega(new LogisticaTerrestre());
            HacerEntrega(new LogisticaTerrestre(PaqueteEnums.TipoDeEnvio.Urgente));

            System.Console.ReadLine();
        }

        private static void HacerEntrega(CentroLogistica centroLogistica)
        {
            System.Console.WriteLine(centroLogistica.EnviarPaquete());
        }
    }
}