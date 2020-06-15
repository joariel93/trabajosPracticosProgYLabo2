using System;
using Excepciones;
using ClasesAbstractas;
using ClasesInstanciables;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitarios
{
    [TestClass]
    public class TestDeserializer
    {
        [TestMethod]
        public void TestUniversidadLeer()
        {
            //Arange
            Universidad testUni1 = new Universidad();
            Universidad testUni2 = new Universidad();
            Alumno alumnoTest1 = new Alumno(1, "Joaquin", "Calero", "37996295", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno alumnoTest2 = new Alumno(2, "Diego", "Maradona", "996295", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion);
            Profesor profesorTest1 = new Profesor(1, "Dr. ", "Chapatin", "25364", Persona.ENacionalidad.Argentino);
            Profesor profesorTest2 = new Profesor(2, "Dr. ", "Chapatin", "5364", Persona.ENacionalidad.Argentino);
            Profesor profesorTest3 = new Profesor(3, "Dr. ", "Chapatin", "364", Persona.ENacionalidad.Argentino);
            Profesor profesorTest4 = new Profesor(4, "Dr. ", "Chapatin", "64", Persona.ENacionalidad.Argentino);

            //Act
            testUni1 += alumnoTest1;
            testUni1 += alumnoTest2;
            testUni1 += profesorTest1;
            testUni1 += profesorTest2;
            testUni1 += profesorTest3;
            testUni1 += profesorTest4;
            testUni1 += Universidad.EClases.Programacion;

            Universidad.Guardar(testUni1);

            testUni2=Universidad.Leer();

            //Assert
            Assert.IsNotNull(testUni2);


        }
    }
}
