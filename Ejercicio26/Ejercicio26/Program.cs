using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mostrar los números pares entre 0 y 100
            Console.WriteLine("Números pares entre 0 y 100:");

            // Iterar desde 0 hasta 100
            for (int i = 0; i <= 100; i++)
            {
                // Verificar si el número es par
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
