using System;
using Excepciones;
using EntidadesAbstractas;
using ClasesInstanciables;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitarios
{
    [TestClass]
    public class TestDniInvalidoException
    {
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestDniInvalido()
        {
            Alumno alumnoTest1 = new Alumno(1, "Joaquin", "Calero", "37996295", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno alumnoTest2 = new Alumno(1, "Diego", "Maradona", "a996295", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
        }
    }
}
