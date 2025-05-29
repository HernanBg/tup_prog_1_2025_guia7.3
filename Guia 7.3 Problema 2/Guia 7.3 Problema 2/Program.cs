using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7._3_Problema_2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
        {
                string nombre;
                int legajo;
                double nota;

                
                double mayorNota = double.MinValue;
                double menorNota = double.MaxValue;
                string nombreMayor = "";
                string nombreMenor = "";
                int legajoMayor = 0;
                int legajoMenor = 0;

                Console.WriteLine("Registro de Alumnos");
                

                Console.Write("¿Desea registrar un alumno? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta != "s")
                {
                    Console.WriteLine("No se registraron alumnos.");
                    return;
                }

                while (respuesta == "s")
                {
                    Console.Write("Número de libreta: ");
                    while (!int.TryParse(Console.ReadLine(), out legajo))
                    {
                        Console.Write("Entrada inválida. Ingrese un número válido: ");
                    }

                    Console.Write("Nombre del alumno: ");
                    nombre = Console.ReadLine();

                    Console.Write("Nota del alumno (0 a 10): ");
                    while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
                    {
                        Console.Write("Nota inválida. Ingrese un valor entre 0 y 10: ");
                    }

                   
                    if (nota > mayorNota)
                    {
                        mayorNota = nota;
                        nombreMayor = nombre;
                        legajoMayor = legajo;
                    }

                    if (nota < menorNota)
                    {
                        menorNota = nota;
                        nombreMenor = nombre;
                        legajoMenor = legajo;
                    }

                    Console.Write("¿Registrar otro alumno? (s/n): ");
                    respuesta = Console.ReadLine().ToLower();
                }

                
                Console.WriteLine("\n--- Resultados ---");
                Console.WriteLine($"Alumno con mayor nota:");
                Console.WriteLine($"Nombre: {nombreMayor} | Libreta: {legajoMayor} | Nota: {mayorNota:F2}");
                Console.WriteLine($"\nAlumno con menor nota:");
                Console.WriteLine($"Nombre: {nombreMenor} | Libreta: {legajoMenor} | Nota: {menorNota:F2}");
            }
        }
    }
    
    }
