using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETCourse.Humano
{
    class AccionesPerros : Organos
    {
       
        internal void Respirar()
        {
            Pulmon();
            Console.WriteLine("Perro respirando usando los Pulmones");
        }

        internal void Digerir()
        {
            Intestino();
            Console.WriteLine("Perro digiriendo usando el intestino");
        }

        internal void Caminar()
        {
            Piernas_Patas();
            Console.WriteLine("Perro caminado usando las patas");
        }

        internal void Correr()
        {
            Piernas_Patas();
            Console.WriteLine("Perro corriendo usando las patas velozmente");
        }

        public override string Bombear(int vecesXMinutos)
        {
            return $"Perro bombea {vecesXMinutos * 2}";
        }

    }
}
