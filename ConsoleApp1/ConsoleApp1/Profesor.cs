using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Profesor
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        Materia _Materia;
        Alumno alumno;

        public Profesor(string nombre, string apellido, string dni, Materia materia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this._Materia = materia;
        }

        public void ObtenerProfesor()// ObtenerProfesor  ObtenerAulasPorProfesor
        {

            p.Add(new Profesor("Santiago", "Perez", "32456788"));
            p.Add(new Profesor("Mariana", "Andalu", "16787543"));
            p.Add(new Profesor("Sandra", "Ver", "32122235"));
            p.Add(new Profesor("Mariano", "Exposito", "19876899"));
            p.Add(new Profesor("Bautista", "Lopez", "18765335"));

            foreach (Profesor prof in p)
            {
                System.Console.WriteLine(prof.nombre + " " + prof.apellido + " " + prof.dni);

            }
        }

    }
}
