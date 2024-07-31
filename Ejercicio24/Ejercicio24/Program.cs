using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mostrar los números primos entre 0 y 100
            Console.WriteLine("Números primos entre 0 y 100:");

            for (int i = 0; i <= 100; i++)
            {
                if (EsPrimo(i))
                {
                    Console.WriteLine(i);
                }
               
            }
            Console.ReadKey();
        }
        // Método para determinar si un número es primo
        static bool EsPrimo(int number)
        {
            // Los números menores o iguales a 1 no son primos
            if (number <= 1) return false;

            // Verificar si el número es divisible por algún número desde 2 hasta la raíz cuadrada del número
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            // Si no es divisible por ningún número en el rango, es primo
            return true;
        }
    }
}
