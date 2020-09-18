using FluentAssertions;
using Maroto.DesignPatterns.StructuralDesigns.Adapter.Contracts;
using Maroto.DesignPatterns.StructuralDesigns.Adapter.Taladro;
using Maroto.DesignPatterns.TestSupport;
using Moq;
using System;
using Xunit;

namespace Maroto.DesignPatterns.StructuralDesigns.Adapter.UnitTests.Taladro.TaladroAmericanoTests
{
    public static class ConstructorTest
    {
        public class Given_Valid_Dependencies_When_Constructing_Instance
            : Given_When_Then_Test
        {
            private TaladroAmericano _sut;
            private IEnchufeAmericano _enchufeAmericano;

            protected override void Given()
            {
                _enchufeAmericano = Mock.Of<IEnchufeAmericano>();
            }

            protected override void When()
            {
                _sut = new TaladroAmericano(_enchufeAmericano);
            }

            [Fact]
            public void Then_It_Should_Have_Created_A_Valid_Instance()
            {
                _sut.Should().NotBeNull();
            }
        }

        public class Given_A_Null_EnchufeAmericano_When_Constructing_Instance
            : Given_When_Then_Test
        {
            private TaladroAmericano _sut;
            private IEnchufeAmericano _enchufeAmericano;
            private ArgumentException _argumentException;

            protected override void Given()
            {
                _enchufeAmericano = default(IEnchufeAmericano);
            }

            protected override void When()
            {
                try
                {
                    _sut = new TaladroAmericano(_enchufeAmericano);
                }
                catch (ArgumentException argumentException)
                {
                    _argumentException = argumentException;
                }
            }

            [Fact]
            public void Then_It_Should_Have_Not_Created_A_Valid_Instance()
            {
                _sut.Should().BeNull();
            }

            [Fact]
            public void Then_It_Should_Return_An_ArgumentException()
            {
                _argumentException.Should().NotBeNull();
            }
        }
    }
}