using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Contracts;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Enums;

namespace Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Clients
{
    public abstract class CentroLogistica
    {
        public PaqueteEnums.TipoDeEnvio TipoDeEnvio;
        public abstract ITransporte CrearTransporte();

        protected CentroLogistica(PaqueteEnums.TipoDeEnvio tipoDeEnvio = PaqueteEnums.TipoDeEnvio.Estandar)
        {
            TipoDeEnvio = tipoDeEnvio;
        }

        public string EnviarPaquete()
        {
            var mensajeCentroLogistica = BuildMensajeCentroLogistica();

            var transporte = CrearTransporte();

            var mensajeTransportista = transporte.Entrega();

            return mensajeCentroLogistica + mensajeTransportista;
        }

        private string BuildMensajeCentroLogistica()
        {
            var mensajeCentroLogistica = "CentroLogistica recibe paquete.";

            if (TipoDeEnvio.Equals(PaqueteEnums.TipoDeEnvio.Urgente))
                mensajeCentroLogistica += " El envío es urgente.";
            else
                mensajeCentroLogistica += " El envío no es urgente.";

            return mensajeCentroLogistica;
        }
    }
}