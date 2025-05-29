using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7._3_Matriz_Paras_anidados_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadGrupos = 4;
            int cantidadValores = 6;

            double suma, promedio;
            double mayorPromedio = 0, menorPromedio = 0;
            int grupoMayor = 0, grupoMenor = 0;

            for (int grupo = 1; grupo <= cantidadGrupos; grupo++)
            {
                Console.WriteLine($"\nIngrese los {cantidadValores} valores para el Grupo {grupo}:");
                suma = 0;

                for (int i = 1; i <= cantidadValores; i++)
                {
                    Console.Write($"Valor {i}: ");
                    double valor = Convert.ToDouble(Console.ReadLine());
                    suma += valor;
                }

                promedio = suma / cantidadValores;
                Console.WriteLine($"Promedio del Grupo {grupo}: {promedio}");

              
                if (grupo == 1)
                {
                    mayorPromedio = promedio;
                    menorPromedio = promedio;
                    grupoMayor = grupo;
                    grupoMenor = grupo;
                }
                else
                {
                    if (promedio > mayorPromedio)
                    {
                        mayorPromedio = promedio;
                        grupoMayor = grupo;
                    }
                    if (promedio < menorPromedio)
                    {
                        menorPromedio = promedio;
                        grupoMenor = grupo;
                    }
                }
            }

            
            Console.WriteLine("\n--- RESULTADOS FINALES ---");
            Console.WriteLine("Mayor promedio: " + mayorPromedio);
            Console.WriteLine("Grupo con mayor promedio: " + grupoMayor);
            Console.WriteLine("Menor promedio: " + menorPromedio);
            Console.WriteLine("Grupo con menor promedio: " + grupoMenor);
        }
    }
    
}
