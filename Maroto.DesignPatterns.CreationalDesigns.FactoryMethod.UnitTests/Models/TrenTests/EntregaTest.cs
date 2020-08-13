using FluentAssertions;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Models;
using Maroto.DesignPatterns.TestSupport;
using System;
using Xunit;

namespace Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.UnitTests.Models.TrenTests
{
    public static class EntregaTest
    {
        public class Given_A_Barco_When_Entrega
            : Given_When_Then_Test
        {
            private Tren _sut;
            private Exception _exception;
            private string _result;
            private string _expectedResult;

            protected override void Given()
            {
                _sut = new Tren();

                _expectedResult = " El Tren hace la entrega";
            }

            protected override void When()
            {
                try
                {
                    _result = _sut.Entrega();
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