using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETCourse.Humano
{
    public class AccionesHumanos : Organos
    {
                 

        public override string Bombear(int vecesXSegundo)
        {
            return $"Humano bombea {vecesXSegundo}";
        }    
        
        internal void actividades_humano() 
        {
            List<string> actividades_h = new List<string>();
            actividades_h.Add("Respirar");
            actividades_h.Add("Digerir");
            actividades_h.Add("Caminar");
            actividades_h.Add("Correr");

            List<string> dias = new List<string>();
            dias.Add("Lunes");
            dias.Add("Martes");
            dias.Add("Miercoles");
            dias.Add("Jueves");
            dias.Add("Viernes");


            foreach (String d in dias)
            {
                foreach (String a in actividades_h)
                {
                    if (d == "Lunes" && a == "Respirar")
                    {
                        Pulmon();
                        Console.WriteLine("Humano respirando usando los pulmones el dia " + d);
                    }

                    if (d == "Martes" && a == "Digerir")
                    {
                        Intestino();
                        Console.WriteLine("Humano digiriendo usando el intestino el dia " + d);

                    }

                    if (d == "Miercoles" && a == "Caminar")
                    {
                        Piernas_Patas();
                        Console.WriteLine("Humano caminado usando las piernas el dia " + d);

                    }

                    if (d == "Jueves" && a == "Correr")
                    {
                        Piernas_Patas();
                        Console.WriteLine("Humano corriendo usando las piernas velozmente el dia " + d);
                        Console.WriteLine("\n");

                    }

                }
            }
           
        }
            
    }


}
