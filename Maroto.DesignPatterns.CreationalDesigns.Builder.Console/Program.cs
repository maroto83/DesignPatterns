using Maroto.DesignPatterns.CreationalDesigns.Builder.Builders;
using Maroto.DesignPatterns.CreationalDesigns.Builder.Directors;
using Newtonsoft.Json;

namespace Maroto.DesignPatterns.CreationalDesigns.Builder.Console
{
    class Program
    {
        static void Main()
        {
            var cocheBuilder = new CocheBuilder();
            var cocheDirector = new CocheDirector(cocheBuilder);

            System.Console.WriteLine("\nEl director fabrica un coche básico:\n");
            cocheDirector.BuildBasico();
            System.Console.WriteLine(JsonConvert.SerializeObject(cocheBuilder.Build(), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));

            System.Console.WriteLine("\n\nEl director fabrica un coche con todo incluido:\n");
            cocheDirector.BuildTodoIncluido();
            System.Console.WriteLine(JsonConvert.SerializeObject(cocheBuilder.Build()));

            var manualDelCocheBuilder = new ManualDelCocheBuilder();
            cocheDirector = new CocheDirector(manualDelCocheBuilder);

            System.Console.WriteLine("\n\nEl director fabrica un manual para el coche básico:\n");
            cocheDirector.BuildBasico();
            System.Console.WriteLine(JsonConvert.SerializeObject(manualDelCocheBuilder.Build(), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));

            System.Console.WriteLine("\n\nEl director fabrica un manual para el coche con todo incluido:\n");
            cocheDirector.BuildTodoIncluido();
            System.Console.WriteLine(JsonConvert.SerializeObject(manualDelCocheBuilder.Build()));

            System.Console.ReadLine();

        }
    }
}