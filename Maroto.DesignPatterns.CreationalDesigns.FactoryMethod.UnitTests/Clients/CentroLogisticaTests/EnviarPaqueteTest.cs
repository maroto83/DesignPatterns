using FluentAssertions;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Clients;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Enums;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.UnitTests.Builders;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.UnitTests.Fakes;
using Maroto.DesignPatterns.TestSupport;
using System;
using Xunit;

namespace Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.UnitTests.Clients.CentroLogisticaTests
{
    public static class EnviarPaqueteTest
    {
        public abstract class Given_A_CentroLogistica_When_Envia_Un_Paquete
            : Given_When_Then_Test
        {
            private CentroLogistica _sut;
            private Exception _exception;
            private string _result;
            private string _expectedResult;

            protected abstract PaqueteEnums.TipoDeEnvio TipoDeEnvio { get; }
            protected abstract string MensajeCentroLogistica { get; }

            protected override void Given()
            {
                var transporteFake = new TransporteFake();

                _sut = new CentroLogisticaBuilder()
                    .WithTransporteCreado(transporteFake, TipoDeEnvio)
                    .Build();

                _expectedResult = MensajeCentroLogistica;
            }

            protected override void When()
            {
                try
                {
                    _result = _sut.EnviarPaquete(TipoDeEnvio);
                }
                catch (Exception exception)
                {
                    _exception = exception;
                }
            }

            [Fact]
            public void Then_It_Should_Handle_Correctly()
            {
                _exception.Should().BeNull();
            }

            [Fact]
            public void Then_The_Result_Should_Be_The_Expected_Result()
            {
                _result.Should().BeEquivalentTo(_expectedResult);
            }
        }
        public class Given_A_CentroLogistica_When_Envio_No_Es_Urgente
            : Given_A_CentroLogistica_When_Envia_Un_Paquete
        {
            protected override PaqueteEnums.TipoDeEnvio TipoDeEnvio => PaqueteEnums.TipoDeEnvio.Estandar;
            protected override string MensajeCentroLogistica => "CentroLogistica recibe paquete. El envío no es urgente. El TransporteFake hace la entrega";
        }

        public class Given_A_CentroLogistica_When_Envio_Es_Urgente
            : Given_A_CentroLogistica_When_Envia_Un_Paquete
        {
            protected override PaqueteEnums.TipoDeEnvio TipoDeEnvio => PaqueteEnums.TipoDeEnvio.Urgente;
            protected override string MensajeCentroLogistica => "CentroLogistica recibe paquete. El envío es urgente. El TransporteFake hace la entrega";
        }
    }
}