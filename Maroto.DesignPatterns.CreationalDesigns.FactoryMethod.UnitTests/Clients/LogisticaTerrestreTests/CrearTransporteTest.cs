using FluentAssertions;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Clients;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Contracts;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Enums;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Models;
using Maroto.DesignPatterns.TestSupport;
using System;
using Xunit;

namespace Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.UnitTests.Clients.LogisticaTerrestreTests
{
    public static class CrearTransporteTest
    {
        public abstract class Given_A_LogisticaTerrestre_When_Crea_Un_Transporte
            : Given_When_Then_Test
        {
            private LogisticaTerrestre _sut;
            private Exception _exception;
            private ITransporte _result;
            private ITransporte _expectedResult;

            protected abstract PaqueteEnums.TipoDeEnvio TipoDeEnvio { get; }
            protected abstract ITransporte TransporteCreado { get; }

            protected override void Given()
            {
                _sut = new LogisticaTerrestre(TipoDeEnvio);

                _expectedResult = TransporteCreado;
            }

            protected override void When()
            {
                try
                {
                    _result = _sut.CrearTransporte();
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
        public class Given_A_LogisticaTerrestre_When_Envio_No_Es_Urgente
            : Given_A_LogisticaTerrestre_When_Crea_Un_Transporte
        {
            protected override PaqueteEnums.TipoDeEnvio TipoDeEnvio => PaqueteEnums.TipoDeEnvio.Estandar;
            protected override ITransporte TransporteCreado => new Camion();
        }

        public class Given_A_LogisticaTerrestre_When_Envio_Es_Urgente
            : Given_A_LogisticaTerrestre_When_Crea_Un_Transporte
        {
            protected override PaqueteEnums.TipoDeEnvio TipoDeEnvio => PaqueteEnums.TipoDeEnvio.Urgente;
            protected override ITransporte TransporteCreado => new Tren();
        }
    }
}