using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mostrar los múltiplos de 3 y de 2 entre 0 y 100
            Console.WriteLine("Números entre 0 y 100 que son múltiplos de 3 y 2:");

            // Iterar desde 0 hasta 100
            for (int i = 0; i <= 100; i++)
            {
                // Verificar si el número es múltiplo tanto de 3 como de 2
                if (i % 3 == 0 && i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
