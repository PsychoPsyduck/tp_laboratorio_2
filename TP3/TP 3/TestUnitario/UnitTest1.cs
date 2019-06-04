using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Archivos;
using EntidadesAbstractas;
using Clases_Instanciables;
using Excepciones;
using System.Collections.Generic;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        Archivos.Texto testTexto;
        Alumno testAlumno;

        [TestMethod]
        public void TestLeerFalse()
        {
            string testLeer;
            testTexto = new Texto();
            string testPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\TestLeer.txt";

            try
            {
                testTexto.Leer(testPath, out testLeer);
            }
            catch(FileNotFoundException e)
            {
                Assert.IsInstanceOfType(e, typeof(FileNotFoundException));
            }
        }

        [TestMethod]
        public void TestSinProfesorException()
        {

            Universidad uni = new Universidad();
            try
            {
                uni += Universidad.EClases.Legislacion;
            }
            catch (SinProfesorException e)
            {
                Assert.IsInstanceOfType(e, typeof(SinProfesorException));
            }
        }

        [TestMethod]
        public void TestSetDniNumerico()
        {
            string dniTest = "98765432";
            testAlumno = new Alumno(333, "Bruno", "ElGato", dniTest, Persona.ENacionalidad.Extranjero, Universidad.EClases.Legislacion);

            Assert.AreEqual(int.Parse(dniTest), testAlumno.DNI);
        }

        [TestMethod]
        public void ValidaJornadaAlumnosNoEsNull()
        {
            Profesor testP = new Profesor(666, "Tuca", "LaGata", "12345678", Persona.ENacionalidad.Argentino);
            Jornada testJ = new Jornada(Universidad.EClases.Programacion, testP);

            Assert.IsNotNull(testJ.Alumnos);
        }
    }
}
