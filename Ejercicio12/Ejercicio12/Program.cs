using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int cantidadNumeros = 5;
            int[] numeros = new int[cantidadNumeros];

            // Pedir al usuario que ingrese los 5 números
            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.WriteLine("Error: Ingrese un número válido.");
                    Console.ReadKey();
                    return;
                }
            }

            // Encontrar el mayor y el menor número
            int mayor = EncontrarMayor(numeros);
            int menor = EncontrarMenor(numeros);

            // Mostrar resultados
            Console.WriteLine($"El mayor número es: {mayor}");
            Console.WriteLine($"El menor número es: {menor}");
            Console.ReadKey();
        }
        
        
        // Método para encontrar el mayor número en un arreglo
        public static int EncontrarMayor(int[] numeros)
        {
            int max = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > max)
                {
                    max = numeros[i];
                }
            }
            return max;
        }

        // Método para encontrar el menor número en un arreglo
        public static int EncontrarMenor(int[] numeros)
        {
            int min = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] < min)
                {
                    min = numeros[i];
                }
            }
            return min;
        }
    }
}
