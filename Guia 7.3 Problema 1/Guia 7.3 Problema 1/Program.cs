using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7._3_Problema_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            double monto;
            double montoMayor = double.MinValue;
            double montoMenor = double.MaxValue;
            string nombreMayor = "";
            string nombreMenor = "";

            Console.WriteLine("Juego de Apuestas");
            Console.WriteLine("------------------");

            Console.Write("¿Desea registrar una apuesta? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta != "s")
            {
                Console.WriteLine("No se registraron apuestas.");
                return;
            }

            while (respuesta == "s")
            {
                Console.Write("Nombre del apostador: ");
                nombre = Console.ReadLine();

                Console.Write("Monto de la apuesta: ");
                while (!double.TryParse(Console.ReadLine(), out monto) || monto <= 0)
                {
                    Console.Write("Monto inválido. Ingrese un valor positivo: ");
                }

              
                if (monto > montoMayor)
                {
                    montoMayor = monto;
                    nombreMayor = nombre;
                }

                if (monto < montoMenor)
                {
                    montoMenor = monto;
                    nombreMenor = nombre;
                }

                Console.Write("¿Registrar otro apostador? (s/n): ");
                respuesta = Console.ReadLine().ToLower();
            }

            
            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Mayor apuesta: {nombreMayor} - $ {montoMayor:F2}");
            Console.WriteLine($"Menor apuesta: {nombreMenor} - $ {montoMenor:F2}");

        }
    }
}
