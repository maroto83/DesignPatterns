using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Contracts;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Factories;

namespace Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Console
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Quiero muebles goticos:\n");
            ObtenerMuebles(new FabricaDeMueblesGoticos());
            System.Console.WriteLine("\n\nQuiero muebles modernos:\n");
            ObtenerMuebles(new FabricaDeMueblesModernos());
            System.Console.WriteLine("\n\nQuiero muebles victorianos:\n");
            ObtenerMuebles(new FabricaDeMueblesVictorianos());

            System.Console.ReadLine();
        }

        private static void ObtenerMuebles(IFabricaDeMuebles fabricaDeMuebles)
        {
            var silla = fabricaDeMuebles.CrearSilla();
            var sofa = fabricaDeMuebles.CrearSofa();
            var mesilla = fabricaDeMuebles.CrearMesilla();

            System.Console.WriteLine(silla.Sentarse());
            System.Console.WriteLine(sofa.Tumbarse());
            System.Console.WriteLine(mesilla.Comer());
        }
    }
}