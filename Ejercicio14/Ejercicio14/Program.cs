using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario los dos números
            Console.Write("Ingrese el primer número: ");
            int num1;
            if (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Error: Ingrese un número válido.");
                return;
            }

            Console.Write("Ingrese el segundo número: ");
            int num2;
            if (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Error: Ingrese un número válido.");
                return;
            }

            // Determinar el rango de números naturales
            int menor = Math.Min(num1, num2);
            int mayor = Math.Max(num1, num2);

            // Variables para contar los números y los pares
            int conteoTotal = 0;
            int conteoPares = 0;

            // Imprimir los números naturales entre los dos números dados
            Console.WriteLine($"Números naturales entre {menor} y {mayor}:");
            for (int i = menor + 1; i < mayor; i++)
            {
                Console.Write(i + " ");
                conteoTotal++;
                if (i % 2 == 0)
                {
                    conteoPares++;
                }
            }

            // Imprimir el conteo total y el conteo de pares
            Console.WriteLine();
            Console.WriteLine($"Cantidad total de números naturales entre {menor} y {mayor}: {conteoTotal}");
            Console.WriteLine($"Cantidad de números pares entre {menor} y {mayor}: {conteoPares}");
            Console.ReadKey();
        }
    }
}
    

