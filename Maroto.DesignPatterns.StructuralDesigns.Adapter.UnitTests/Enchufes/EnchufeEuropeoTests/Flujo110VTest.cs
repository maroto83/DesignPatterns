﻿using FluentAssertions;
using Maroto.DesignPatterns.StructuralDesigns.Adapter.Enchufes;
using Maroto.DesignPatterns.TestSupport;
using System;
using Xunit;

namespace Maroto.DesignPatterns.StructuralDesigns.Adapter.UnitTests.Enchufes.EnchufeEuropeoTests
{
    public static class Flujo110VTest
    {
        public class Given_A_FEnchufeAmericanoabricaDeMueblesGoticos_When_Flujo110V
            : Given_When_Then_Test
        {
            private EnchufeEuropeo _sut;
            private Exception _exception;
            private string _result;
            private string _expectedResult;

            protected override void Given()
            {
                _sut = new EnchufeEuropeo();

                _expectedResult = $"Usando flujo europeo ({_sut.Voltaje}V)";
            }

            protected override void When()
            {
                try
                {
                    _result = _sut.Flujo220V();
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
            public void Then_The_Result_Should_Be_The_Expected_Result()
            {
                _result.Should().Be(_expectedResult);
            }
        }
    }
}