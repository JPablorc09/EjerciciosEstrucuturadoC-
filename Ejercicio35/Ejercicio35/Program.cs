using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario las dimensiones del arreglo
            Console.WriteLine("Ingrese el número de filas:");
            int filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas:");
            int columnas = int.Parse(Console.ReadLine());

            // Crear la matriz con las dimensiones especificadas
            int[,] matriz = new int[filas, columnas];

            // Cargar la matriz con valores
            CargarMatriz(matriz);

            // Imprimir la matriz
            Console.WriteLine("Matriz:");
            ImprimirMatriz(matriz);

            // Imprimir la diagonal principal si es una matriz cuadrada
            if (filas == columnas)
            {
                Console.WriteLine("\nDiagonal Principal:");
                ImprimirDiagonalPrincipal(matriz);
            }
            else
            {
                Console.WriteLine("\nLa matriz no es cuadrada, no se puede imprimir la diagonal principal.");
            }
        }

        static void CargarMatriz(int[,] matriz)
        {
            Random random = new Random();
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    matriz[f, c] = random.Next(1, 10); // Rellena la matriz con números aleatorios del 1 al 9
                }
            }
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write(matriz[f, c] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void ImprimirDiagonalPrincipal(int[,] matriz)
        {
            int filas = matriz.GetLength(0);

            for (int f = 0; f < filas; f++)
            {
                Console.Write(matriz[f, f] + "\t");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
 }

