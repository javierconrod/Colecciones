using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>();


            //alumno0
            alumnos.Add(new Alumno());
            alumnos[0].Nombre = "Juan";
            alumnos[0].Matricula = "194536";
            //alumno1
            alumnos.Add(new Alumno());
            alumnos[1].Nombre = "Manuel";
            alumnos[1].Matricula = "194546";
            //alumno2
            alumnos.Add(new Alumno());
            alumnos[2].Nombre = "Renato";
            alumnos[2].Matricula = "194566";
            //alumno3
            alumnos.Add(new Alumno());
            alumnos[3].Nombre = "PepsiMan";
            alumnos[3].Matricula = "184566";



            //materias0
            alumnos[0].Materias.Add(new Materia());
            alumnos[0].Materias[0].Nombre = "Historia";
            alumnos[0].Materias[0].Identificador = "HT45687";

            alumnos[0].Materias.Add(new Materia());
            alumnos[0].Materias[1].Nombre = "Programación";
            alumnos[0].Materias[1].Identificador = "PM48687";

            alumnos[0].Materias.Add(new Materia());
            alumnos[0].Materias[2].Nombre = "Fisica";
            alumnos[0].Materias[2].Identificador = "FS55687";

            //materias1
            alumnos[1].Materias.Add(new Materia());
            alumnos[1].Materias[0].Nombre = "Historia";
            alumnos[1].Materias[0].Identificador = "HT45687";

            alumnos[1].Materias.Add(new Materia());
            alumnos[1].Materias[1].Nombre = "Programación";
            alumnos[1].Materias[1].Identificador = "PM48687";

            alumnos[1].Materias.Add(new Materia());
            alumnos[1].Materias[2].Nombre = "Fisica";
            alumnos[1].Materias[2].Identificador = "FS55687";

            //materias2
            alumnos[2].Materias.Add(new Materia());
            alumnos[2].Materias[0].Nombre = "Historia";
            alumnos[2].Materias[0].Identificador = "HT45687";

            alumnos[2].Materias.Add(new Materia());
            alumnos[2].Materias[1].Nombre = "Programación";
            alumnos[2].Materias[1].Identificador = "PM48687";

            alumnos[2].Materias.Add(new Materia());
            alumnos[2].Materias[2].Nombre = "Fisica";
            alumnos[2].Materias[2].Identificador = "FS55687";

            /*
            alumno.Materias.RemoveAt(1);
            alumno.Materias.RemoveAt(1);

            alumno.Materias.Clear();*/
            
            foreach(Alumno alumno in alumnos)
            {
                Console.WriteLine("Nombre: " + alumno.Nombre);
                foreach(Materia materia in alumno.Materias)
                {
                    Console.WriteLine("Materia: " + materia.Nombre);
                }

            }

            Console.ReadLine();
        }
    }
}
