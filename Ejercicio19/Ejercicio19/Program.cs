using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializar variables
            int cantidadNumeros = 10;
            int sumaPositivos = 0;
            int productoNegativos = 1;
            bool hayNegativos = false;

            // Pedir al usuario que ingrese 10 números
            for (int i = 1; i <= cantidadNumeros; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                int numero;
                if (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Error: Ingrese un número válido.");
                    return;
                }

                // Verificar si el número es positivo o negativo
                if (numero >= 0)
                {
                    sumaPositivos += numero;
                }
                else
                {
                    productoNegativos *= numero;
                    hayNegativos = true;
                }
            }

            // Mostrar resultados
            Console.WriteLine();
            Console.WriteLine($"Suma de los números positivos: {sumaPositivos}");
            if (hayNegativos)
            {
                Console.WriteLine($"Producto de los números negativos: {productoNegativos}");
            }
            else
            {
                Console.WriteLine("No se ingresaron números negativos.");
            }
            Console.ReadKey();
        }
    }
}
