using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7._3_Ej_4.Mayor_y_menor__Para_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero , mayor = 0 , menor = 0 , contador = 0 ;

            Console.WriteLine("INGRESE UN NUMERO ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= 30; i++)
            {
                Console.WriteLine("INGRESE UN NUMERO ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > mayor )
                {
                    mayor= numero;
                }
                if (numero < menor )
                {
                    menor = numero;
                }
                contador++;
            }

            if (contador > 0)
            {
                Console.WriteLine("El mayor numero ingresado es : " + mayor);
                Console.WriteLine("El menor numero ingresado es : " + menor);
            }
        }
    }
}
