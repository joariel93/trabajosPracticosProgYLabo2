using System;
using System.Collections.Generic;
using ClasesInstanciables;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitarios
{
    [TestClass]
    public class TestColeccionInstanciada
    {
        [TestMethod]
        public void TestColeccion()
        {
            // Arange
            Universidad testUni = new Universidad();

            //Assert
            Assert.IsInstanceOfType(testUni.Alumnos, typeof(List<Alumno>));

        }
    }
}
