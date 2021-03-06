﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class DataMock
    {
        internal static List<Alumno> Alumnos { get; private set; }
        internal static List<Profesor> Profesores { get; private set; }
        internal static List<Aula> Aulas { get; private set; }
        internal static List<Materia> Materias { get; private set; }
        internal static List<Examen> Examenes { get; private set; }

        public static void Inicialize()
        {
            #region
            var materia1 = new Materia("T4", "Taller 4");
            var materia2 = new Materia("BD", "Base de Datos");
            var materia3 = new Materia("SI", "Simulacio");
            var materia4 = new Materia("AyM", "Analisis y Metodologias");
            var materia5 = new Materia("RD", "Redes");

            #endregion

            #region
            var alumno1 = new Alumno("Mariano", "Perez", "36789987");
            var alumno2 = new Alumno("Sofia", "Meriadiano", "3978998");
            var alumno3 = new Alumno("Fernando", "Exposito", "38908678");
            var alumno4 = new Alumno("Gabriela", "Gallo", "35789098");
            var alumno5 = new Alumno("Maria", "Felix", "31890345");
            var alumno6 = new Alumno("Walter", "Cruz", "33456987");

            #endregion

            #region
            var profesor1 = new Profesor("Santiago", "Perez", "32456788", materia1);
            var profesor2 = new Profesor("Mariana", "Andalu", "16787543", materia3);
            var profesor3 = new Profesor("Sandra", "Ver", "32122235", materia4);
            var profesor4 = new Profesor("Mariano", "Exposito", "19876899", materia2);
            var profesor5 = new Profesor("Bautista", "Lopez", "18765335", materia5);

            #endregion

            #region
            var aula1 = new Aula(1, 3);
            var aula2 = new Aula(4, 2);
            var aula3 = new Aula(2, 1);
            var aula4 = new Aula(5, 4);
            var aula5 = new Aula(3, 1);
            #endregion

            #region

            var examen1 = new Examen(alumno1, "25/03/2019", 9, materia5);
            var examen2 = new Examen(alumno2, "29/04/2019", 7, materia4);
            var examen3 = new Examen(alumno3, "30/03/2019", 3, materia3);
            var examen4 = new Examen(alumno4, "01/04/2019", 6, materia2);
            var examen5 = new Examen(alumno5, "10/04/2019", 8, materia1);
            var examen6 = new Examen(alumno6, "21/04/2019", 4, materia1);
            #endregion

            #region
            var Alumnos = new[] { alumno1, alumno2, alumno3, alumno4, alumno5, alumno6 };
            var Materias = new[] { materia1, materia2, materia3, materia4, materia5 };
            var Profesores = new[] { profesor1, profesor2, profesor3, profesor4, profesor5 };
            var Aulas = new[] { aula1, aula2, aula3, aula4, aula5 };
            var Examenes = new[] { examen1, examen2, examen3, examen4, examen5, examen6 };
            #endregion
        }
    }
}
