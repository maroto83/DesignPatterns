﻿using FluentAssertions;
using Maroto.DesignPatterns.StructuralDesigns.Adapter.Contracts;
using Maroto.DesignPatterns.StructuralDesigns.Adapter.Enchufes;
using Maroto.DesignPatterns.TestSupport;
using Xunit;

namespace Maroto.DesignPatterns.StructuralDesigns.Adapter.UnitTests.Enchufes.EnchufeAmericanoTests
{
    public static class ConstructorTest
    {
        public class Given_Valid_Dependencies_When_Constructing_Instance
            : Given_When_Then_Test
        {
            private EnchufeAmericano _sut;

            protected override void Given()
            {
            }

            protected override void When()
            {
                _sut = new EnchufeAmericano();
            }

            [Fact]
            public void Then_It_Should_Have_Created_A_Valid_Instance()
            {
                _sut.Should().NotBeNull();
            }

            [Fact]
            public void Then_It_Should_Be_A_EnchufeAmericano()
            {
                _sut.Should().BeAssignableTo<IEnchufeAmericano>();
            }
        }
    }
}