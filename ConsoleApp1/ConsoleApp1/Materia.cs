using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Materia
    {
        public string nombre { get; set; }
        public string codigo { get; set; }
        Aula aula;
        private string v1;
        private string v2;

        public Materia(string nombre, string codigo)
        {
            this.nombre = nombre;
            this.codigo = codigo;
        }
    }
}
