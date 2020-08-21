using FluentAssertions;
using Maroto.DesignPatterns.CreationalDesigns.Prototype.Models;
using Maroto.DesignPatterns.TestSupport;
using System;
using Xunit;

namespace Maroto.DesignPatterns.CreationalDesigns.Prototype.UnitTests.Models.PersonaTests
{
    public class CopiaSuperficialTest
    {
        public class Given_A_Persona_When_Do_CopiaSuperficial
            : Given_When_Then_Test
        {
            private Persona _sut;
            private Persona _personaOriginal;
            private Exception _exception;
            private Persona _expectedResult;

            protected override void Given()
            {
                const int identificacion = 1;
                const string nombre = "nombre";
                const int edad = 1;
                var fechaNacimiento = DateTime.UtcNow;

                _personaOriginal =
                    new Persona
                    {
                        InformacionAdicional = new InformacionAdicional(identificacion),
                        Nombre = nombre,
                        Edad = edad,
                        FechaNacimiento = fechaNacimiento
                    };

                _expectedResult =
                    new Persona
                    {
                        InformacionAdicional = new InformacionAdicional(identificacion),
                        Nombre = nombre,
                        Edad = edad,
                        FechaNacimiento = fechaNacimiento
                    };
            }

            protected override void When()
            {
                try
                {
                    _sut = _personaOriginal.CopiaSuperficial();

                    _personaOriginal.Edad = 10;
                    _personaOriginal.FechaNacimiento = _personaOriginal.FechaNacimiento.AddYears(10);
                    _personaOriginal.Nombre = "Nombre 2";
                    _personaOriginal.InformacionAdicional = new InformacionAdicional(2);
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
            public void Then_The_Result_Should_Be_A_Persona()
            {
                _sut.Should().BeOfType(_expectedResult.GetType());
            }

            [Fact]
            public void Then_The_Result_Should_Be_The_Expected_Result()
            {
                _sut.Should().BeEquivalentTo(_expectedResult);
            }
        }
    }
}