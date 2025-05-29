using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7._3__Promedio_de_20_numeros_Para_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador;
            double numero, suma = 0, promedio;

            for (contador = 1; contador <= 20; contador++)
            {
                Console.Write("Ingrese un numero " + contador + " : ");
                numero = Convert.ToDouble(Console.ReadLine());
                suma += numero;

            }
            promedio = suma / 20;
            Console.WriteLine("El Promedio de los 20 numeros es: " + promedio);


        }
    }
}
