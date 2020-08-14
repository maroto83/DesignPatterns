using FluentAssertions;
using Maroto.DesignPatterns.CreationalDesigns.Builder.Builders;
using Maroto.DesignPatterns.CreationalDesigns.Builder.Contracts;
using Maroto.DesignPatterns.CreationalDesigns.Builder.Directors;
using Maroto.DesignPatterns.TestSupport;
using Xunit;

namespace Maroto.DesignPatterns.CreationalDesigns.Builder.UnitTests.Directors.CocheDirectorTests
{
    public static class ConstructorTest
    {
        public class Given_Valid_Dependencies_When_Constructing_Instance
            : Given_When_Then_Test
        {
            private CocheDirector _sut;
            private ICocheBuilder _builder;

            protected override void Given()
            {
                _builder = new CocheBuilder();
            }

            protected override void When()
            {
                _sut = new CocheDirector(_builder);
            }

            [Fact]
            public void Then_It_Should_Have_Created_A_Valid_Instance()
            {
                _sut.Should().NotBeNull();
            }
        }
    }
}