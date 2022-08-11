using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETCourse.Humano
{
    class AccionesPerros : Organos
    {
       
        public override string Bombear(int vecesXMinutos)
        {
            return $"Perro bombea {vecesXMinutos * 2}";
        }

        internal void actividades_perro()
        {
            List<string> actividades_p = new List<string>();
            actividades_p.Add("Respirar");
            actividades_p.Add("Digerir");
            actividades_p.Add("Caminar");
            actividades_p.Add("Correr");

            List<string> dias = new List<string>();
            dias.Add("Lunes");
            dias.Add("Martes");
            dias.Add("Miercoles");
            dias.Add("Jueves");
            dias.Add("Viernes");


            foreach (String d in dias)
            {
                foreach (String a in actividades_p)
                {
                    if (d == "Jueves" && a == "Respirar")
                    {
                        Pulmon();
                        Console.WriteLine("Perro respirando usando los pulmones el dia " + d);
                    }

                    if (d == "Miercoles" && a == "Digerir")
                    {
                        Intestino();
                        Console.WriteLine("Perro digiriendo usando el intestino el dia " + d);

                    }

                    if (d == "Martes" && a == "Caminar")
                    {
                        Piernas_Patas();
                        Console.WriteLine("Perro caminado usando las patas el dia " + d);

                    }

                    if (d == "Lunes" && a == "Correr")
                    {
                        Piernas_Patas();
                        Console.WriteLine("Perro corriendo usando las patas velozmente el dia " + d);

                    }

                }
            }

        }

    }
}
