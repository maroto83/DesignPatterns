using FluentAssertions;
using Maroto.DesignPatterns.StructuralDesigns.Adapter.Adaptador;
using Maroto.DesignPatterns.StructuralDesigns.Adapter.Contracts;
using Maroto.DesignPatterns.TestSupport;
using Moq;
using System;
using Xunit;

namespace Maroto.DesignPatterns.StructuralDesigns.Adapter.UnitTests.Adaptador
{
    public static class Flujo110VTest
    {
        public class Given_A_AdaptadorAmericanoEuropeo_When_Flujo110V
            : Given_When_Then_Test
        {
            private AdaptadorAmericanoEuropeo _sut;
            private Exception _exception;
            private string _result;
            private string _expectedResult;

            protected override void Given()
            {
                var enchufeEuropeoMock = new Mock<IEnchufeEuropeo>();

                enchufeEuropeoMock
                    .SetupGet(x => x.Voltaje)
                    .Returns(220);

                var enchufeEuropeo = enchufeEuropeoMock.Object;
                _sut = new AdaptadorAmericanoEuropeo(enchufeEuropeo);

                _expectedResult = $"Usando adaptador americano ({_sut.Voltaje}V)";
            }

            protected override void When()
            {
                try
                {
                    _result = _sut.Flujo110V();
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
                _result.Should().Be(_expectedResult);
            }
        }
    }
}