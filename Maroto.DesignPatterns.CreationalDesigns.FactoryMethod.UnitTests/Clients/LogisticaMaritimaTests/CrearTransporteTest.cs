using FluentAssertions;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Clients;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Contracts;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Enums;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Models;
using Maroto.DesignPatterns.TestSupport;
using System;
using Xunit;

namespace Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.UnitTests.Clients.LogisticaMaritimaTests
{
    public static class CrearTransporteTest
    {
        public abstract class Given_A_LogisticaMaritima_When_Crea_Un_Transporte
            : Given_When_Then_Test
        {
            private LogisticaMaritima _sut;
            private Exception _exception;
            private ITransporte _result;
            private Barco _expectedResult;

            protected abstract PaqueteEnums.TipoDeEnvio TipoDeEnvio { get; }

            protected override void Given()
            {
                _sut = new LogisticaMaritima();

                _expectedResult = new Barco();
            }

            protected override void When()
            {
                try
                {
                    _result = _sut.CrearTransporte(TipoDeEnvio);
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
                _result.Should().BeOfType(_expectedResult.GetType());
            }
        }
        public class Given_A_LogisticaMaritima_When_Envio_No_Es_Urgente
            : Given_A_LogisticaMaritima_When_Crea_Un_Transporte
        {
            protected override PaqueteEnums.TipoDeEnvio TipoDeEnvio => PaqueteEnums.TipoDeEnvio.Estandar;
        }

        public class Given_A_LogisticaMaritima_When_Envio_Es_Urgente
            : Given_A_LogisticaMaritima_When_Crea_Un_Transporte
        {
            protected override PaqueteEnums.TipoDeEnvio TipoDeEnvio => PaqueteEnums.TipoDeEnvio.Urgente;
        }
    }
}