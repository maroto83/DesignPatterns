using FluentAssertions;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Contracts;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Factories;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Sofas;
using Maroto.DesignPatterns.TestSupport;
using System;
using Xunit;

namespace Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.UnitTests.Factories.FabricaDeMueblesVictorianosTests
{
    public static class CrearSofaTest
    {
        public class Given_A_FabricaDeMueblesVictorianos_When_Crea_Un_Sofa
            : Given_When_Then_Test
        {
            private FabricaDeMueblesVictorianos _sut;
            private Exception _exception;
            private ISofa _result;
            private SofaVictoriano _expectedResult;

            protected override void Given()
            {
                _sut = new FabricaDeMueblesVictorianos();

                _expectedResult = new SofaVictoriano();
            }

            protected override void When()
            {
                try
                {
                    _result = _sut.CrearSofa();
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