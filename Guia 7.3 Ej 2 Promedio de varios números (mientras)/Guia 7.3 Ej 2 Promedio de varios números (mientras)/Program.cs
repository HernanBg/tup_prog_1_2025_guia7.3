using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7._3_Ej_2_Promedio_de_varios_números__mientras_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero, suma = 0, promedio;
            int contador = 0;

            Console.WriteLine("El Ingrese un numero entre el  0 y el 100 ");
            numero =Convert.ToDouble(Console.ReadLine());

            while (numero > 0 && numero <= 100)
            {
                suma += numero;
                contador ++;

                Console.WriteLine("Ingrese otro numero entre el 0 y el 100 ");
                numero = Convert.ToDouble(Console.ReadLine());
            }
            if (contador > 0 )
            {

                promedio = suma / contador;
                Console.WriteLine("El promedio de los numeros ingresados es : " + promedio);

            }
            else
            {
                Console.WriteLine("No se ingresaron numeros validos.");

            }
             
        }
    }
}
