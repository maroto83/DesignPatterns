using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Contracts;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Enums;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Models;

namespace Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Clients
{
    public class LogisticaMaritima
        : CentroLogistica
    {
        public override ITransporte CrearTransporte(PaqueteEnums.TipoDeEnvio tipoDeEnvio = PaqueteEnums.TipoDeEnvio.Estandar)
        {
            return new Barco();
        }
    }
}