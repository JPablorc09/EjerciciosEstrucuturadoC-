using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            numeroMayoresYMenores();
        }
        static int numeroMayoresYMenores() {
            int cantidadNumeros = 10;
            int mayoresCero = 0;
            int menoresCero = 0;

            // Solicitar al usuario que ingrese 10 números
            Console.WriteLine($"Ingrese {cantidadNumeros} números:");

            for (int i = 0; i < cantidadNumeros; i++)
            {
                double numero;

                // Validar la entrada del usuario hasta que sea válida
                while (true)
                {
                    Console.Write($"Número {i + 1}: ");
                    string input = Console.ReadLine();

                    // Intentar convertir la entrada a double
                    if (double.TryParse(input, out numero))
                    {
                        break; // Salir del bucle si la conversión fue exitosa
                        
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                    }
                }

                // Determinar si el número es mayor o menor que cero
                if (numero > 0)
                {
                    mayoresCero++;
                }
                else if (numero < 0)
                {
                    menoresCero++;
                }
                // No es necesario contar los números iguales a cero en este caso
            }

            // Mostrar resultados
            Console.WriteLine($"\nCantidad de números mayores a cero: {mayoresCero}");
            Console.WriteLine($"Cantidad de números menores a cero: {menoresCero}");

            // Esperar a que el usuario presione una tecla para salir
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
            return numeroMayoresYMenores();
            }
        }
    }
  

