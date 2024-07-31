using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario el número para la tabla de multiplicar
            Console.Write("Ingrese un número entre 0 y 10: ");
            int numero;
            if (!int.TryParse(Console.ReadLine(), out numero) || numero < 0 || numero > 10)
            {
                Console.WriteLine("Error: Ingrese un número válido entre 0 y 10.");
                return;
            }

            // Imprimir la tabla de multiplicar
            Console.WriteLine($"Tabla de multiplicar del {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
                Console.ReadKey();
            }
        }
    }
}

