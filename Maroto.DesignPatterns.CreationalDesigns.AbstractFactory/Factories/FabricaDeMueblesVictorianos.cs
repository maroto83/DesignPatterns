using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Contracts;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Mesillas;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Sillas;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Sofas;

namespace Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Factories
{
    public class FabricaDeMueblesVictorianos
        : IFabricaDeMuebles
    {
        public ISilla CrearSilla()
        {
            return new SillaVictoriana();
        }

        public ISofa CrearSofa()
        {
            return new SofaVictoriano();
        }

        public IMesilla CrearMesilla()
        {
            return new MesillaVictoriana();
        }
    }
}