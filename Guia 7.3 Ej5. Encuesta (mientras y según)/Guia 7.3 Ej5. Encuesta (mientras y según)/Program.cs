using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7._3_Ej5.Encuesta__mientras_y_según_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int positivas = 0;
            int negativas = 0;
            int indecisos = 0;
            int total = 0;

            Console.WriteLine("ENCUESTA: Ingrese opiniones (0=Positiva, 1=Negativa, 2=Indecisa)");

            string respuesta = "s";

            while (respuesta.ToLower() == "s")
            {
                Console.Write("Ingrese opinión (0, 1 o 2): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int opinion))
                {
                    switch (opinion)
                    {
                        case 0:
                            positivas++;
                            total++;
                            break;
                        case 1:
                            negativas++;
                            total++;
                            break;
                        case 2:
                            indecisos++;
                            total++;
                            break;
                        default:
                            Console.WriteLine("Opinión no válida. Solo se permiten 0, 1 o 2.");
                            continue; 
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Debe ser un número (0, 1 o 2).");
                    continue; 
                }

                Console.Write("¿Continuar? (s/n): ");
                respuesta = Console.ReadLine();
            }

            if (total == 0)
            {
                Console.WriteLine("No hubo encuestados.");
            }
            else
            {
                double porcPositivas = (double)positivas / total * 100;
                double porcNegativas = (double)negativas / total * 100;
                double porcIndecisos = (double)indecisos / total * 100;

                Console.WriteLine("\nResultados de la encuesta:");
                Console.WriteLine($"Total de encuestados: {total}");
                Console.WriteLine($"Opiniones positivas: {positivas} ({porcPositivas:F2}%)");
                Console.WriteLine($"Opiniones negativas: {negativas} ({porcNegativas:F2}%)");
                Console.WriteLine($"Opiniones indecidas: {indecisos} ({porcIndecisos:F2}%)");
            }
        
        }
    }
}
