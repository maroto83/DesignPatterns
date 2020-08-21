using FluentAssertions;
using Maroto.DesignPatterns.CreationalDesigns.Prototype.Models;
using Maroto.DesignPatterns.TestSupport;
using Xunit;

namespace Maroto.DesignPatterns.CreationalDesigns.Prototype.UnitTests.Models.InformacionAdicionalTests
{
    public static class ConstructorTest
    {
        public class Given_Valid_Dependencies_When_Constructing_Instance
            : Given_When_Then_Test
        {
            private InformacionAdicional _sut;
            private int _identificacion;

            protected override void Given()
            {
                _identificacion = 1;
            }

            protected override void When()
            {
                _sut = new InformacionAdicional(_identificacion);
            }

            [Fact]
            public void Then_It_Should_Have_Created_A_Valid_Instance()
            {
                _sut.Should().NotBeNull();
            }
        }
    }
}