using FluentAssertions;
using Maroto.DesignPatterns.TestSupport;
using System;
using Xunit;

namespace Maroto.DesignPatterns.CreationalDesigns.Singleton.UnitTests.SingletonTests
{
    public class OperacionConcretaTest
    {
        public class Given_A_Singleton_When_Do_OperacionConcreta
            : Given_When_Then_Test
        {
            private Singleton _sut;
            private Exception _exception;

            protected override void Given()
            {
                _sut = Singleton.GetInstancia();
            }

            protected override void When()
            {
                try
                {
                    _sut.OperacionConcreta();
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