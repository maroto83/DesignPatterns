using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Contracts;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Enums;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Models;

namespace Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Clients
{
    public class LogisticaTerrestre
        : CentroLogistica
    {
        public LogisticaTerrestre(PaqueteEnums.TipoDeEnvio tipoDeEnvio = PaqueteEnums.TipoDeEnvio.Estandar)
            : base(tipoDeEnvio)
        {
        }

        public override ITransporte CrearTransporte()
        {
            if (TipoDeEnvio.Equals(PaqueteEnums.TipoDeEnvio.Urgente))
                return new Tren();

            return new Camion();
        }
    }
}