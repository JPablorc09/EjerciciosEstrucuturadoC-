using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mostrar los números impares entre 0 y 100
            Console.WriteLine("Números impares entre 0 y 100:");

            // Iterar desde 1 hasta 100 con un incremento de 2 para obtener solo los números impares
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}

