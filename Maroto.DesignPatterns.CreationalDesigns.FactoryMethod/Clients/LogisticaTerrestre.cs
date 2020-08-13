using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Contracts;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Enums;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Models;

namespace Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Clients
{
    public class LogisticaTerrestre
        : CentroLogistica
    {
        public override ITransporte CrearTransporte(PaqueteEnums.TipoDeEnvio tipoDeEnvio = PaqueteEnums.TipoDeEnvio.Estandar)
        {
            if (tipoDeEnvio.Equals(PaqueteEnums.TipoDeEnvio.Urgente))
                return new Tren();

            return new Camion();
        }
    }
}