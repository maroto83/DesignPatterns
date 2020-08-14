using FluentAssertions;
using Maroto.DesignPatterns.CreationalDesigns.Builder.Builders;
using Maroto.DesignPatterns.CreationalDesigns.Builder.Models;
using Maroto.DesignPatterns.TestSupport;
using System;
using Xunit;

namespace Maroto.DesignPatterns.CreationalDesigns.Builder.UnitTests.Builders.CocheBuilderTests
{
    public static class SetOrdenadorABordo
    {
        public class Given_A_CocheBuilder_When_SetOrdenadorABordo
            : Given_When_Then_Test
        {
            private CocheBuilder _sut;
            private Exception _exception;
            private Coche _expectedResult;
            private Coche _result;

            protected override void Given()
            {
                const string mensaje = "Ordenador de abordo añadido.";

                _sut = new CocheBuilder();

                _expectedResult =
                    new Coche
                    {
                        OrdenadorABordo = mensaje
                    };
            }

            protected override void When()
            {
                try
                {
                    _sut.Reset();

                    _sut.SetOrdenadorABordo();

                    _result = _sut.Build();
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

            [Fact]
            public void Then_The_Result_Should_Be_A_Coche()
            {
                _result.Should().BeEquivalentTo(_expectedResult);
            }
        }
    }
}