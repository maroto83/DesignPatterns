using FluentAssertions;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Contracts;
using Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.Models;
using Maroto.DesignPatterns.TestSupport;
using Xunit;

namespace Maroto.DesignPatterns.CreationalDesigns.FactoryMethod.UnitTests.Models.CamionTests
{
    public static class ConstructorTest
    {
        public class Given_Valid_Dependencies_When_Constructing_Instance
            : Given_When_Then_Test
        {
            private Camion _sut;

            protected override void Given()
            {
            }

            protected override void When()
            {
                _sut = new Camion();
            }

            [Fact]
            public void Then_It_Should_Have_Created_A_Valid_Instance()
            {
                _sut.Should().NotBeNull();
            }

            [Fact]
            public void Then_It_Should_Be_A_ITransporte()
            {
                _sut.Should().BeAssignableTo<ITransporte>();
            }
        }
    }
}