using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarar viable
            double num;
            // Solicitar al usuario que ingrese un número
            Console.WriteLine("Ingrese un numero");
            num=double.Parse(Console.ReadLine());

            // Calcular el cuadrado y el cubo del número
            double cuadrado = num * num;
            double cubo = num * num * num;

            // Mostrar los resultados
            Console.WriteLine("El cuadrado de {0} es {1}",num,cuadrado);
            Console.WriteLine("El cubo de {0} es {1}",num,cubo);
            Console.ReadKey();

        }
    }
}
