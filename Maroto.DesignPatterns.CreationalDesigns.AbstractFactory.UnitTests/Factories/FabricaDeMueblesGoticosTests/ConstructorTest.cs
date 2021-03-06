﻿using FluentAssertions;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Contracts;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Factories;
using Maroto.DesignPatterns.TestSupport;
using Xunit;

namespace Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.UnitTests.Factories.FabricaDeMueblesGoticosTests
{
    public static class ConstructorTest
    {
        public class Given_Valid_Dependencies_When_Constructing_Instance
            : Given_When_Then_Test
        {
            private FabricaDeMueblesGoticos _sut;

            protected override void Given()
            {
            }

            protected override void When()
            {
                _sut = new FabricaDeMueblesGoticos();
            }

            [Fact]
            public void Then_It_Should_Have_Created_A_Valid_Instance()
            {
                _sut.Should().NotBeNull();
            }

            [Fact]
            public void Then_It_Should_Be_A_IFabricaDeMuebles()
            {
                _sut.Should().BeAssignableTo<IFabricaDeMuebles>();
            }
        }
    }
}