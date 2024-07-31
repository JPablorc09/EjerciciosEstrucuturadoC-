using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            numeroCuadrado();
        } 
        static double numeroCuadrado()
        {
            double numero;
            bool numeroValido = false;

            do
            {
                Console.Write("Ingrese un número mayor que cero: ");
                string input = Console.ReadLine();

                // Intentar convertir el input a double
                if (double.TryParse(input, out numero))
                {
                    // Verificar si el número es mayor que cero
                    if (numero > 0)
                    {
                        numeroValido = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. El número debe ser mayor que cero. Reingrese número.\n");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR. Entrada inválida. Reingrese número.\n");
                }

            } while (!numeroValido);

            // Calcular el cuadrado del número ingresado
            double cuadrado = Math.Pow(numero,2);

            // Mostrar el resultado
            Console.WriteLine($"El cuadrado de {numero} es: {cuadrado}");

            // Esperar a que el usuario presione una tecla para salir
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
            return cuadrado;
        }

    }
}



