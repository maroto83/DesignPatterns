using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Contracts;
using System.Reflection;

namespace Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.UnitTests.Fakes
{
    public class TransporteFake
        : ITransporte
    {
        public string Entrega()
        {
            return $" El {MethodBase.GetCurrentMethod().DeclaringType?.Name} hace la entrega";
        }
    }
}