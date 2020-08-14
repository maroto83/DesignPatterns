using FluentAssertions;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Contracts;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Factories;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Mesillas;
using Maroto.DesignPatterns.TestSupport;
using System;
using Xunit;

namespace Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.UnitTests.Factories.FabricaDeMueblesVictorianosTests
{
    public static class CrearMesillaTest
    {
        public class Given_A_FabricaDeMueblesVictorianos_When_Crea_Una_Mesilla
            : Given_When_Then_Test
        {
            private FabricaDeMueblesVictorianos _sut;
            private Exception _exception;
            private IMesilla _result;
            private MesillaVictoriana _expectedResult;

            protected override void Given()
            {
                _sut = new FabricaDeMueblesVictorianos();

                _expectedResult = new MesillaVictoriana();
            }

            protected override void When()
            {
                try
                {
                    _result = _sut.CrearMesilla();
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
    }
}