namespace Maroto.DesignPatterns.CreationalDesigns.Singleton.Console
{
    class Program
    {
        static void Main()
        {
            var singleton1 = Singleton.GetInstancia();
            var singleton2 = Singleton.GetInstancia();

            if (singleton1 == singleton2)
            {
                System.Console.WriteLine("El patrón singleton funciona:\n");

                singleton1.OperacionConcreta();
            }
            else
            {
                System.Console.WriteLine("El patrón singleton ha fallado.\n");
            }

            System.Console.ReadLine();
        }
    }
}