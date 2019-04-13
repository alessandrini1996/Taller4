using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Alumno
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public List<Materia> materias;
        public List<Examen> examenes;
        Materia materia;
        Examen examen;
        //Profesor profesor;


        public Alumno(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        public void examenAlumno()
        {
            float totalNota = 2;
            float promedio;
            Alumno alumno;
            var ex = new List<Examen>();

            ex.Add(new Examen(new Alumno("Mariano"), "19/03/2019", 6, new Materia("POO")));
            ex.Add(new Examen(new Alumno("Sofia"), "25/03/2019", 9, new Materia("REDES")));
            ex.Add(new Examen(new Alumno("Carolina"), "29/04/2019", 7, new Materia("TAD")));
            ex.Add(new Examen(new Alumno("Pablo"), "30/03/2019", 3, new Materia("SIMULACION")));
            ex.Add(new Examen(new Alumno("Pablo"), "01/04/2019", 6, new Materia("TALLER 4")));
            ex.Add(new Examen(new Alumno("Sofia"), "10/04/2019", 8, new Materia("JUDAICAS")));
            ex.Add(new Examen(new Alumno("Mariano"), "14/04/2019", 10, new Materia("POO")));
            ex.Add(new Examen(new Alumno("Carolina"), "18/04/2019", 2, new Materia("AyM")));
            ex.Add(new Examen(new Alumno("Agusitna"), "21/04/2019", 4, new Materia("AyM")));
            ex.Add(new Examen(new Alumno("Agusitna"), "27/04/2019", 7, new Materia("TALLER 4")));

            foreach (Examen e in ex)
            {
                System.Console.WriteLine("El examen fue el dia: " + e.dia + " y la nota fue: " + e.nota);
                //if (ex.Contains(alumno).CompareTo.nombre) { 
                //promedio = (e.nota + e.nota) / 2;
                //System.Console.WriteLine("El promedio de:" + this.nombre + " es: " + promedio);
                //}

            }
            Console.ReadKey();
        }

        public void InscribirMateria(Materia materia)
        {
            materias.Add(materia);
        }

        public void InscibirMaterias(List<Materia> materias)
        {
            materias.Add(materia);
        }

        public void Baja(Materia materia)
        {
            materias.Remove(materia);
        }

        public void Evaluar(Examen examen)
        {
            examenes.Add(examen);
        }
    }
}
