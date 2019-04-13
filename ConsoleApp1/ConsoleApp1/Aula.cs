using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    [Serializable]
    public class Aula
    {
        public int piso { get; set; }
        public int sala { get; set; }
        Materia materia;

        public Aula(int piso, int sala)
        {
            this.piso = piso;
            this.sala = sala;
        }

        public void ProfAula()
        {
            var a = new List<Aula>();
            a.Add(new Aula(9));
            a.Add(new Aula(10));
            a.Add(new Aula(1));
            a.Add(new Aula(7));
            a.Add(new Aula(2));

            foreach (Aula au in a)
            {
                System.Console.WriteLine("El Nº de aula es: " + au.numAula);
            }
        }

    }
}
