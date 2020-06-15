using System;
using Excepciones;
using ClasesAbstractas;
using ClasesInstanciables;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace TestUnitarios
{
    [TestClass]
    public class TestNacionalidadInvalidaException
    {
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestNacionalidadInvalida()
        {
            Profesor profesorTest1 = new Profesor(1, "Dr. ", "Chapatin", "25364", Persona.ENacionalidad.Argentino);
            Profesor profesorTest2 = new Profesor(1, "Dr. ", "Zeus", "25364", Persona.ENacionalidad.Extranjero);
        }
    }
}
