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

            humano.Respirar();
            perro.Respirar();

            humano.Digerir();
            perro.Digerir();

            humano.Caminar();
            perro.Caminar();

            humano.Correr();
            perro.Correr();

            Console.WriteLine(humano.get_meat_protein());
            Console.WriteLine(perro.get_meat_protein());

            Console.WriteLine(humano.Bombear(2));
            Console.WriteLine(perro.Bombear(2));

            Console.WriteLine("changes");


        }
    }
}
