using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETCourse.Humano
{
    public class AccionesHumanos : Organos
    {
        internal void Respirar()
        {
            Pulmon();
            Console.WriteLine("Humano respirando usando los pulmones");
        }

        internal void Digerir()
        {
            Intestino();
            Console.WriteLine("Humano digiriendo usando el intestino");
        }

        internal void Caminar()
        {
            Piernas_Patas();
            Console.WriteLine("Humano caminado usando las piernas");
        }

        internal void Correr()
        {
            Piernas_Patas();
            Console.WriteLine("Humano corriendo usando las piernas velozmente");
        }

        public override string Bombear(int vecesXSegundo)
        {
            return $"Humano bombea {vecesXSegundo}";
        }
    }
}
