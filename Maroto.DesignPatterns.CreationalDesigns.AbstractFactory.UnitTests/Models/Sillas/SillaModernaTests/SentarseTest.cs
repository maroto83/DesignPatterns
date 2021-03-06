﻿using FluentAssertions;
using Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Models.Sillas;
using Maroto.DesignPatterns.TestSupport;
using System;
using Xunit;

namespace Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.UnitTests.Models.Sillas.SillaModernaTests
{
    public static class SentarseTest
    {
        public class Given_A_SillaModerna_When_Sentarse
            : Given_When_Then_Test
        {
            private SillaModerna _sut;
            private Exception _exception;
            private string _result;
            private string _expectedResult;

            protected override void Given()
            {
                _sut = new SillaModerna();

                _expectedResult = " Me siento en una silla moderna.";
            }

            protected override void When()
            {
                try
                {
                    _result = _sut.Sentarse();
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