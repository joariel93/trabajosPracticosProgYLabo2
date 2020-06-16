using System;
using Excepciones;
using EntidadesAbstractas;
using ClasesInstanciables;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitarios
{
    [TestClass]
    public class TestAlumnoRepetidoException
    {
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void TestAlumnoRepetido()
        {
            Universidad uniTest = new Universidad();
            Profesor profesorTest1 = new Profesor(1, "Dr. ", "Chapatin", "25364", Persona.ENacionalidad.Argentino);
            Alumno alumnoTest1 = new Alumno(1, "Joaquin", "Calero", "37996295", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno alumnoTest2 = new Alumno(1, "Diego", "Maradona", "996295", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            uniTest += alumnoTest1;
            uniTest += alumnoTest2;
            uniTest += profesorTest1;
            uniTest += Universidad.EClases.Laboratorio;


        }
    }
}
