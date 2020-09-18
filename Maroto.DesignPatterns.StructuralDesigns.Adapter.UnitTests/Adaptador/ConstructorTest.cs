using FluentAssertions;
using Maroto.DesignPatterns.StructuralDesigns.Adapter.Adaptador;
using Maroto.DesignPatterns.StructuralDesigns.Adapter.Contracts;
using Maroto.DesignPatterns.TestSupport;
using Moq;
using System;
using Xunit;

namespace Maroto.DesignPatterns.StructuralDesigns.Adapter.UnitTests.Adaptador
{
    public static class ConstructorTest
    {
        public class Given_Valid_Dependencies_When_Constructing_Instance
            : Given_When_Then_Test
        {
            private AdaptadorAmericanoEuropeo _sut;
            private IEnchufeEuropeo _enchufeEuropeo;

            protected override void Given()
            {
                _enchufeEuropeo = Mock.Of<IEnchufeEuropeo>();
            }

            protected override void When()
            {
                _sut = new AdaptadorAmericanoEuropeo(_enchufeEuropeo);
            }

            [Fact]
            public void Then_It_Should_Have_Created_A_Valid_Instance()
            {
                _sut.Should().NotBeNull();
            }
        }

        public class Given_A_Null_EnchufeEuropeo_When_Constructing_Instance
            : Given_When_Then_Test
        {
            private AdaptadorAmericanoEuropeo _sut;
            private IEnchufeEuropeo _enchufeEuropeo;
            private ArgumentException _argumentException;

            protected override void Given()
            {
                _enchufeEuropeo = default(IEnchufeEuropeo);
            }

            protected override void When()
            {
                try
                {
                    _sut = new AdaptadorAmericanoEuropeo(_enchufeEuropeo);
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