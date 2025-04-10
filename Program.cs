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
            int ncursos, notas, dias, horas, ansie, reportD;
            int tiempo, motiva, hRedes;
            double prom, ingresosH;
            int asis = 0;
            int suma = 0;
            int Cursoaprobada = 0;
            int Cursodesaprobada = 0;
            int[] asiste;
            string nombre, cursos, notaStr, asiStr, diasSu, horasSu, ansiedad, actividad;
            string reportes, ingresos, tiemEstudio, acceso, motivacion, horasRedes;
            List<int> listanotas = new List<int>();

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
                listanotas.Add(notas);
            }
            prom = (double)suma / ncursos;

            Console.WriteLine("\n---- Asistencia de los cursos ----");
            Console.WriteLine("\n---- Ingrese su asistencia de los cursos");
            Console.WriteLine("\n---- Ingrese valores del 0 al 100");
            for (int i = 1; i <= ncursos; i++)
            {

                Console.Write($"\n---- Asistencia del {i}° curso: ");
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

            for (int i = 0; i < ncursos; i++)
            {
                if (listanotas[i] >= 11 && listanotas[i] <= 20)
                {
                    Console.WriteLine("Curso " + (i + 1) + " aprobado");
                    Cursoaprobada++;
                }
                else
                {
                    Console.WriteLine("Curso " + (i + 1) + " desaprobado");
                    Cursodesaprobada++;
                }
            }

            Console.WriteLine($"\n---- Cursos desaprobados: {Cursodesaprobada}");

            Console.WriteLine("\n---- Horas de Sueño ----");
            Console.WriteLine("\n---- Cuantas horas duerme?");
            Console.Write("---- Horas: "); //promedio de horas por noche
            horasSu = Console.ReadLine();
            horas = int.Parse(horasSu);

            Console.WriteLine("\n---- Nivel de Ansiedad ----");
            Console.Write("---- Ingrese su nivel de ansiedad: ");
            ansiedad = Console.ReadLine();
            ansie = int.Parse(ansiedad);

            if (ansie < 3)
            {
                Console.WriteLine("Su nivel de ansiedad es bajo");
            }
            else if (ansie > 3 && ansie <= 5)
            {
                Console.WriteLine("Su nivel de ansiedad es alto");

            }

            Console.WriteLine("\n---- Actividades Extracurriculares ----");
            Console.Write("---- Participa en actividades:  ");
            actividad = Console.ReadLine();
            
            if (actividad == "Si")
            {
                Console.WriteLine("Felicitaciones ");
                
            }
            else if (actividad == "No")
            {   
                Console.WriteLine("No participa en actividades");
                
            }
            else
            {
                Console.WriteLine("Introduzca solo Si o No");
            }

            Console.WriteLine("\n---- Reportes Disciplinarios ----");
            Console.Write("---- Ingrese el numero de reportes disciplinarios: ");
            reportes = Console.ReadLine();
            reportD = int.Parse(reportes);

            if (reportD <= 5)
            {
                Console.WriteLine("Su nivel de disciplina es alto");
            }
            else
            {
                Console.WriteLine("Su nivel de disciplina es bajo");
            }

            Console.WriteLine("\n---- Ingresos del Hogar ----");
            Console.Write("---- Ingrese sus ingresos: ");
            ingresos = Console.ReadLine();
            ingresosH = double.Parse(ingresos);
            if (ingresosH > 2000)
            {
                Console.WriteLine("Sus ingresos son altos");
            }
            else if (ingresosH >= 1000 && ingresosH <= 2000)
            {
                Console.WriteLine("Sus ingresos son medios");
            }
            else
            {
                Console.WriteLine("Sus ingresos son bajos");
            }

            Console.WriteLine("\n---- Tiempo de estudio ----");
            Console.Write("---- Ingrese el tiempo de estudio semanal: ");
            tiemEstudio = Console.ReadLine();
            tiempo = int.Parse(tiemEstudio);

            Console.WriteLine("\n---- Acceso a Internet ----");
            Console.Write("---- Tiene acceso a internet: ");
            acceso = Console.ReadLine();
            if (acceso == "Si")
            {
                Console.WriteLine("Acceso a internet");
            }
            else if (acceso == "No")
            {
                Console.WriteLine("No tiene acceso a internet");
            }
            else
            {
                Console.WriteLine("Introduzca solo Si o No");
            }

            Console.WriteLine("\n---- Motivacion ----");
            Console.Write("---- Ingrese su nivel de motivacion: ");
            motivacion = Console.ReadLine();
            motiva = int.Parse(motivacion);

            if (motiva >= 1 && motiva <= 5)
            {
                Console.WriteLine("Su nivel de motivacion es: " + motiva);
            }
            else
            {
                Console.WriteLine("Ingrese un valor entre el rango de 1 - 5");
            }

            Console.WriteLine("\n---- Redes Sociales ----");
            Console.Write("---- Cuantas horas pasa en redes sociales: ");
            horasRedes = Console.ReadLine();
            hRedes = int.Parse(horasRedes);

            if (prom >= 18 && prom <= 20)
            {
                if (asis == 100)
                {
                    if (Cursodesaprobada <= 0)
                    {
                        if (horas >= 8)
                        {
                            if (ansie < 3)
                            {
                                if (actividad == "Si")
                                {
                                    if (reportD == 0)
                                    {
                                        if (ingresosH > 2000)
                                        {
                                            if (tiempo >= 10)
                                            {
                                                if (acceso == "Si")
                                                {
                                                    if (motiva >= 4)
                                                    {
                                                        if (hRedes <= 2)
                                                        {
                                                            Console.WriteLine($"\n---- Felicitaciones, usted {nombre} es un Candidato a mencion honorifica ----");

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (prom >= 15 && prom < 18)
            {
                if (asis >= 80)
                {
                    if (Cursodesaprobada <= 0)
                    {
                        if (horas >= 7)
                        {
                            if (ansie < 4)
                            {
                                if (actividad == "Si")
                                {
                                    if (reportD <= 3)
                                    {
                                        if (ingresosH > 2000)
                                        {
                                            if (tiempo <= 5)
                                            {
                                                if (acceso == "Si")
                                                {
                                                    if (motiva >= 3)
                                                    {
                                                        if (hRedes <= 2)
                                                        {
                                                            Console.WriteLine($"\n---- Felicitaciones, usted {nombre} es Estudiante equilibrado ----");

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else if (actividad == "No")
                                {
                                    if (reportD <= 3)
                                    {
                                        if (ingresosH >= 1000 && ingresosH <= 2000)
                                        {
                                            if (tiempo <= 5)
                                            {
                                                if (acceso == "Si")
                                                {
                                                    if (motiva >= 3)
                                                    {
                                                        if (hRedes <= 2)
                                                        {
                                                            Console.WriteLine($"\n---- Felicitaciones, usted {nombre} es Estudiante equilibrado ----");

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (prom >= 12 && prom < 14)
            {
                if (asis <= 70)
                {
                    if (Cursodesaprobada <= 0)
                    {
                        if (horas >= 7)
                        {
                            if (ansie <= 4)
                            {
                                if (actividad == "No")
                                {
                                    if (reportD >= 3)
                                    {
                                        if (ingresosH <= 1000)
                                        {
                                            if (tiempo == 0 && tiempo < 5)
                                            {
                                                if (acceso == "No")
                                                {
                                                    if (motiva < 3)
                                                    {
                                                        if (hRedes > 2)
                                                        {
                                                            Console.WriteLine($"\n---- Usted {nombre} es Estudiante con Riesgo Medio ----");

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
            }
            else if (prom < 11)
            {
                if (asis < 50)
                {
                    if (Cursodesaprobada <= 0)
                    {
                        if (horas < 6)
                        {
                            if (ansie == 5)
                            {
                                if (actividad == "No")
                                {
                                    if (reportD >= 3)
                                    {
                                        if (ingresosH < 1000)
                                        {
                                            if (tiempo <= 3)
                                            {
                                                if (acceso == "No")
                                                {
                                                    if (motiva == 1)
                                                    {
                                                        if (hRedes > 4)
                                                        {
                                                            Console.WriteLine($"\n---- Usted {nombre} es Estudiante en Situacion Critica ----");

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}
