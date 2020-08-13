using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Clients;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Contracts;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Enums;
using Moq;

namespace Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.UnitTests.Builders
{
    public class CentroLogisticaBuilder
    {
        private Mock<CentroLogistica> _centroLogisticaMock;

        public CentroLogisticaBuilder()
        {
            _centroLogisticaMock = new Mock<CentroLogistica>();
        }

        public CentroLogisticaBuilder WithCentroLogisticaMock(Mock<CentroLogistica> centroLogisticaMock)
        {
            _centroLogisticaMock = centroLogisticaMock;
            return this;
        }

        public CentroLogisticaBuilder WithTransporteCreado(ITransporte transporte, PaqueteEnums.TipoDeEnvio tipoDeEnvio)
        {
            _centroLogisticaMock
                .Setup(x => x.CrearTransporte(tipoDeEnvio))
                .Returns(transporte);
            return this;
        }

        public CentroLogistica Build()
        {
            var centroLogistica = _centroLogisticaMock.Object;

            return centroLogistica;
        }
    }
}