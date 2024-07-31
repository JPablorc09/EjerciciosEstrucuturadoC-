using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escoja la conversión que desea realizar:");
                Console.WriteLine("1. Centímetros a Pies y Pulgadas");
                Console.WriteLine("0. Salir");

                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida. Por favor, ingrese un número válido.");
                    continue;
                }

                double centimetros;
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese la longitud en centímetros: ");
                        if (double.TryParse(Console.ReadLine(), out centimetros))
                        {
                            ConvertirCentimetrosAPiesPulgadas(centimetros);
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido. Por favor, ingrese un número válido.");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa.");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }

                Console.WriteLine();
            }
         }
        // Método para convertir de centímetros a pies y pulgadas
        public static void ConvertirCentimetrosAPiesPulgadas(double centimetros)
        {
            // 1 pulgada = 2.54 cm
            double pulgadasTotales = centimetros / 2.54;

            // 1 pie = 12 pulgadas
            double pies = Math.Floor(pulgadasTotales / 12);
            double pulgadas = pulgadasTotales % 12;

            Console.WriteLine($"{centimetros} cm = {pies} pies y {pulgadas} pulgadas");
        }
    }
}
