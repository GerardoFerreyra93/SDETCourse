using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDETCourse.Humano;
using System;

namespace SDETCourse
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AccionesHumanos humano = new AccionesHumanos();
            AccionesPerros perro = new AccionesPerros();
            humano.actividades_humano();
            perro.actividades_perro();

        }
    }
}
