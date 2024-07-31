using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario el número de elementos
            Console.WriteLine("Ingrese el número de elementos del arreglo:");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("El número de elementos debe ser mayor que cero.");
                return;
            }

            // Crear el arreglo
            int[] arreglo = new int[n];

            // Llenar el arreglo con valores ingresados por el usuario
            Console.WriteLine("Ingrese los elementos del arreglo:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                arreglo[i] = int.Parse(Console.ReadLine());
            }

            // Encontrar el menor valor en el arreglo
            int menor = EncontrarMenor(arreglo);

            // Verificar si el menor valor se repite en el arreglo
            bool seRepite = VerificarRepeticion(arreglo, menor);

            // Mostrar el menor valor y el mensaje sobre la repetición
            Console.WriteLine($"El menor valor en el arreglo es: {menor}");
            if (seRepite)
            {
                Console.WriteLine("El menor valor se repite en el arreglo.");
            }
            else
            {
                Console.WriteLine("El menor valor no se repite en el arreglo.");
            }
            Console.ReadKey();
        }

        static int EncontrarMenor(int[] arreglo)
        {
            int menor = arreglo[0];
            foreach (var item in arreglo)
            {
                if (item < menor)
                {
                    menor = item;
                }
            }
            return menor;
        }

        static bool VerificarRepeticion(int[] arreglo, int valor)
        {
            return arreglo.Count(x => x == valor) > 1;
        }
    }
}
    

