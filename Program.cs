using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajodeCampo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ncursos, notas, asis;
            double prom;
            int suma = 0;
            int[] asiste;
            string nombre, cursos, notaStr, asiStr;
            Console.WriteLine("---- Bienvenido -----");
            Console.WriteLine("\n---- Ingrese el nombre del Alumno");
            Console.Write("\n---- Nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine($"\n---- Hola {nombre}, Bienvenido al sistema de perfiles ----");
            Console.WriteLine("\n---- ¿Cuantos cursos esta llevando?");
            Console.Write("\n---- Ingrese numero de cursos: ");
            cursos = Console.ReadLine();
            ncursos = int.Parse(cursos);

            asiste = new int[ncursos];

            Console.WriteLine("\n---- Notas de los cursos  ----");
            Console.WriteLine("\n---- Ingrese la nota de sus cursos");
            for (int i = 1; i <= ncursos; i++)
            {
                Console.Write($"\n---- Ingrese {i}° Nota:");
                notaStr = Console.ReadLine();
                notas = int.Parse(notaStr);
    
                suma = suma + notas;    

            }
            prom = (double)suma / ncursos;

            Console.WriteLine("\n---- Asistencia de los cursos ----");
            Console.WriteLine("\n---- Ingrese su asistencia de los cursos");
            Console.WriteLine("\n---- Ingrese valores del 0 al 100");
            for (int i = 1; i <= ncursos; i++)
            {
                
                Console.Write($"\n---- Asistencia del {i}°: ");
                asiStr = Console.ReadLine();
                

                if (int.TryParse(asiStr, out asis))
                {
                    if (asis >= 0 && asis <= 100)
                    {
                        asiste[i - 1] = asis;
                        Console.WriteLine("Su asistencia es correcta");
                    }
                    else
                    {
                        Console.WriteLine("Su asistencia es incorrecta, por favor ingrese un valor entre 0 y 100");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada Invalida. Favor de ingresar numero entre 0 - 100");
                }
            }
        }
    }
}
