using FluentAssertions;
using Maroto.DesignPatterns.StructuralDesigns.Adapter.Contracts;
using Maroto.DesignPatterns.StructuralDesigns.Adapter.Taladro;
using Maroto.DesignPatterns.TestSupport;
using Moq;
using System;
using Xunit;

namespace Maroto.DesignPatterns.StructuralDesigns.Adapter.UnitTests.Taladro.TaladroAmericanoTests
{
    public static class EncenderTest
    {
        public class Given_A_TaladroAmericano_When_Enciende
            : Given_When_Then_Test
        {
            private TaladroAmericano _sut;
            private Exception _exception;

            protected override void Given()
            {
                var enchufeAmericano = Mock.Of<IEnchufeAmericano>();
                _sut = new TaladroAmericano(enchufeAmericano);
            }

            protected override void When()
            {
                try
                {
                    _sut.Encender();
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
        }
    }
}