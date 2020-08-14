using FluentAssertions;
using Maroto.DesignPatterns.CreationalDesigns.Builder.Builders;
using Maroto.DesignPatterns.CreationalDesigns.Builder.Directors;
using Maroto.DesignPatterns.CreationalDesigns.Builder.Models;
using Maroto.DesignPatterns.TestSupport;
using System;
using Xunit;

namespace Maroto.DesignPatterns.CreationalDesigns.Builder.UnitTests.Directors.CocheDirectorTests
{
    public static class BuildBasicoTest
    {
        public class Given_A_CocheDirector_When_The_Builder_Is_CocheBuilder_And_BuildBasico
            : Given_When_Then_Test
        {
            private CocheDirector _sut;
            private Exception _exception;
            private Coche _expectedResult;
            private Coche _result;
            private CocheBuilder _cocheBuilder;

            protected override void Given()
            {
                _cocheBuilder = new CocheBuilder();
                _sut = new CocheDirector(_cocheBuilder);

                _expectedResult =
                    new Coche
                    {
                        NumeroDeAsientos = 4,
                        Motor = "motor básico"
                    };
            }

            protected override void When()
            {
                try
                {
                    _sut.BuildBasico();

                    _result = _cocheBuilder.Build();
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
            public void Then_The_Result_Should_Be_A_Coche()
            {
                _result.Should().BeOfType(_expectedResult.GetType());
            }

            [Fact]
            public void Then_The_Result_Should_Be_The_Expected_Result()
            {
                _result.Should().BeEquivalentTo(_expectedResult);
            }
        }

        public class Given_A_CocheDirector_When_The_Builder_Is_ManualDelCocheBuilder_And_BuildBasico
            : Given_When_Then_Test
        {
            private CocheDirector _sut;
            private Exception _exception;
            private ManualDelCoche _expectedResult;
            private ManualDelCoche _result;
            private ManualDelCocheBuilder _manualDelCocheBuilder;

            protected override void Given()
            {
                _manualDelCocheBuilder = new ManualDelCocheBuilder();
                _sut = new CocheDirector(_manualDelCocheBuilder);

                _expectedResult =
                    new ManualDelCoche
                    {
                        NumeroDeAsientos = 4,
                        Motor = "motor básico"
                    };
            }

            protected override void When()
            {
                try
                {
                    _sut.BuildBasico();

                    _result = _manualDelCocheBuilder.Build();
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
            public void Then_The_Result_Should_Be_A_ManualDeCoche()
            {
                _result.Should().BeOfType(_expectedResult.GetType());
            }

            [Fact]
            public void Then_The_Result_Should_Be_The_Expected_Result()
            {
                _result.Should().BeEquivalentTo(_expectedResult);
            }
        }
    }
}