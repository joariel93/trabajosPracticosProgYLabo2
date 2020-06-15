using System;
using Excepciones;
using ClasesInstanciables;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitarios
{
    [TestClass]
    public class TestSinProfesorException
    {
        [TestMethod]
        [ExpectedException(typeof(SinProfesorException))]
        public void TestSinProfesor()
        {
            Universidad uniTest = new Universidad();
            uniTest += Universidad.EClases.Laboratorio;

        }
    }
}
