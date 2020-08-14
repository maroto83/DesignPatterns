using FluentAssertions;
using Maroto.DesignPatterns.CreationalDesigns.Builder.Builders;
using Maroto.DesignPatterns.CreationalDesigns.Builder.Models;
using Maroto.DesignPatterns.TestSupport;
using System;
using Xunit;

namespace Maroto.DesignPatterns.CreationalDesigns.Builder.UnitTests.Builders.ManualDelCocheBuilderTests
{
    public static class SetAsientosTest
    {
        public class Given_A_ManualDelCocheBuilder_When_SetAsientos
            : Given_When_Then_Test
        {
            private ManualDelCocheBuilder _sut;
            private Exception _exception;
            private ManualDelCoche _expectedResult;
            private ManualDelCoche _result;
            private int _numeroDeAsientos;

            protected override void Given()
            {
                _numeroDeAsientos = 4;
                _sut = new ManualDelCocheBuilder();

                _expectedResult =
                    new ManualDelCoche
                    {
                        NumeroDeAsientos = _numeroDeAsientos
                    };
            }

            protected override void When()
            {
                try
                {
                    _sut.Reset();

                    _sut.SetAsientos(_numeroDeAsientos);

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