using Maroto.DesignPatterns.StructuralDesigns.Adapter.Adaptador;
using Maroto.DesignPatterns.StructuralDesigns.Adapter.Contracts;
using Maroto.DesignPatterns.StructuralDesigns.Adapter.Enchufes;
using Maroto.DesignPatterns.StructuralDesigns.Adapter.Taladro;

namespace Maroto.DesignPatterns.StructuralDesigns.Adapter.Console
{
    class Program
    {
        static void Main()
        {
            var enchufeEuropeo = new EnchufeEuropeo();
            IEnchufeAmericano adaptadorAmericano = new AdaptadorAmericanoEuropeo(enchufeEuropeo);

            var taladro = new TaladroAmericano(adaptadorAmericano);

            taladro.Encender();

            System.Console.ReadLine();
        }
    }
}