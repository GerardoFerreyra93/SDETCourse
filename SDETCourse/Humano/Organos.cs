using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETCourse.Humano
{
    public abstract class Organos : GlobulosBlancos
    {
        internal void Pulmon()
        {
            Console.WriteLine("Usando Pulmones");
        }

        internal void Intestino()
        {
            Console.WriteLine("Usando Intestino");
        }

        internal void Piernas_Patas()
        {
            Console.WriteLine("Usando Piernas/Patas");
        }

        public abstract string Bombear(int segundos);

    }


}
