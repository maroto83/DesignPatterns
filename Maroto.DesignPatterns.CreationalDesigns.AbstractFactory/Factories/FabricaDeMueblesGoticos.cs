using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Contracts;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Mesillas;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Sillas;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Sofas;

namespace Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Factories
{
    public class FabricaDeMueblesGoticos
        : IFabricaDeMuebles
    {
        public ISilla CrearSilla()
        {
            return new SillaGotica();
        }

        public ISofa CrearSofa()
        {
            return new SofaGotico();
        }

        public IMesilla CrearMesilla()
        {
            return new MesillaGotica();
        }
    }
}