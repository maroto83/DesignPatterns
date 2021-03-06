﻿using FluentAssertions;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Sofas;
using Maroto.DesignPatterns.TestSupport;
using System;
using Xunit;

namespace Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.UnitTests.Models.Sofas.SofaGoticaTests
{
    public static class TumbarseTest
    {
        public class Given_A_SofaGotico_When_Tumbarse
            : Given_When_Then_Test
        {
            private SofaGotico _sut;
            private Exception _exception;
            private string _result;
            private string _expectedResult;

            protected override void Given()
            {
                _sut = new SofaGotico();

                _expectedResult = " Me tumbo en un sofa gotico.";
            }

            protected override void When()
            {
                try
                {
                    _result = _sut.Tumbarse();
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