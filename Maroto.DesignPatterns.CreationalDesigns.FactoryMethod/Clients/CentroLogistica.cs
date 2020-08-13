using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Contracts;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Enums;

namespace Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Clients
{
    public abstract class CentroLogistica
    {
        public abstract ITransporte CrearTransporte(PaqueteEnums.TipoDeEnvio tipoDeEnvio = PaqueteEnums.TipoDeEnvio.Estandar);

        public string EnviarPaquete(PaqueteEnums.TipoDeEnvio tipoDeEnvio = PaqueteEnums.TipoDeEnvio.Estandar)
        {
            var mensajeCentroLogistica = BuildMensajeCentroLogistica(tipoDeEnvio);

            var transporte = CrearTransporte(tipoDeEnvio);

            var mensajeTransportista = transporte.Entrega();

            return mensajeCentroLogistica + mensajeTransportista;
        }

        private static string BuildMensajeCentroLogistica(PaqueteEnums.TipoDeEnvio tipoDeEnvio)
        {
            var mensajeCentroLogistica = "CentroLogistica recibe paquete.";

            if (tipoDeEnvio.Equals(PaqueteEnums.TipoDeEnvio.Urgente))
                mensajeCentroLogistica += " El envío es urgente.";
            else
                mensajeCentroLogistica += " El envío no es urgente.";

            return mensajeCentroLogistica;
        }
    }
}