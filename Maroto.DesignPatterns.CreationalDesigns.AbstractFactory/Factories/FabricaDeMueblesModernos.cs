using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Contracts;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Mesillas;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Sillas;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Sofas;

namespace Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Factories
{
    public class FabricaDeMueblesModernos
        : IFabricaDeMuebles
    {
        public ISilla CrearSilla()
        {
            return new SillaModerna();
        }

        public ISofa CrearSofa()
        {
            return new SofaModerno();
        }

        public IMesilla CrearMesilla()
        {
            return new MesillaModerna();
        }
    }
}