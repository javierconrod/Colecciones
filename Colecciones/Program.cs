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
            /* Otro metodo para agregar los alumnos.
            Alumno alumno1 = new Alumno();

            alumno1.Nombre = "Jose Perez";
            alumno1.Materias.Add(new Materia("Historia", "HST745"));
            alumno1.Materias.Add(new Materia("Matematicas", "MAT798"));
            alumno1.Materias.Add(new Materia("Civismo", "CIV456"));
            */

            //materias0
            alumnos[0].Materias.Add(new Materia("Historia", "HST741"));

            alumnos[0].Materias.Add(new Materia("Programacion", "PM4698"));

            alumnos[0].Materias.Add(new Materia("Fisica", "FSC6497"));

            //materias1
            alumnos[1].Materias.Add(new Materia("Matematicas", "MAT4976"));
            alumnos[1].Materias.Add(new Materia("Geometria", "GEO1346"));
            alumnos[1].Materias.Add(new Materia("Calculo Integral", "CAI6458"));

            //materias2
            alumnos[2].Materias.Add(new Materia("Amor", "DHI13468"));
            alumnos[2].Materias.Add(new Materia("Español", "ESP16452"));
            alumnos[2].Materias.Add(new Materia("Matematicas", "MAT46135"));

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
