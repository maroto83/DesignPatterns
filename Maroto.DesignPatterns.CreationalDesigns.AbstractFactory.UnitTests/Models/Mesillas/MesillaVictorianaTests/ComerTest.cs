﻿using FluentAssertions;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Mesillas;
using Maroto.DesignPatterns.TestSupport;
using System;
using Xunit;

namespace Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.UnitTests.Models.Mesillas.MesillaVictorianaTests
{
    public static class ComerTest
    {
        public class Given_A_MesillaVictoriana_When_Come
            : Given_When_Then_Test
        {
            private MesillaVictoriana _sut;
            private Exception _exception;
            private string _result;
            private string _expectedResult;

            protected override void Given()
            {
                _sut = new MesillaVictoriana();

                _expectedResult = " Como en una mesa victoriana.";
            }

            protected override void When()
            {
                try
                {
                    _result = _sut.Comer();
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