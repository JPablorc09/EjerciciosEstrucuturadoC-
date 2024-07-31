using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Definir las dimensiones del arreglo
            int filas = 2;
            int columnas = 5;

            // Crear el arreglo de 2x5
            int[,] arreglo = new int[filas, columnas];

            // Cargar el arreglo por columnas
            CargarArregloPorColumnas(arreglo);

            // Imprimir el arreglo
            Console.WriteLine("El arreglo ingresado es:");
            ImprimirArreglo(arreglo);
        }

        static void CargarArregloPorColumnas(int[,] arreglo)
        {
            int filas = arreglo.GetLength(0);
            int columnas = arreglo.GetLength(1);

            for (int j = 0; j < columnas; j++)
            {
                Console.WriteLine($"Ingrese los valores para la columna {j + 1}:");
                for (int i = 0; i < filas; i++)
                {
                    Console.Write($"Elemento [{i}, {j}]: ");
                    arreglo[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void ImprimirArreglo(int[,] arreglo)
        {
            int filas = arreglo.GetLength(0);
            int columnas = arreglo.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(arreglo[i, j] + "\t");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
     }
}
    

