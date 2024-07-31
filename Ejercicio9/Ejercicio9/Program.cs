using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            
            while (true)
            {
                Console.WriteLine("Escoja la conversión que desea realizar:");
                Console.WriteLine("1. Celsius a Fahrenheit");
                Console.WriteLine("2. Fahrenheit a Celsius");
                Console.WriteLine("0. Salir");
     
                if (!int.TryParse(Console.ReadLine(), out op)) {
                    Console.WriteLine("Opción inválida. Por favor, ingrese un número válido.");
                    continue;

                }
                double temperatura;
                switch (op)
                {
                    case 1:
                        Console.Write("Ingrese la temperatura en grados Celsius: ");
                        temperatura=double.Parse(Console.ReadLine());

                        double fahrenheit = CelsiusaFahrenhei(temperatura);
                        Console.WriteLine($"{temperatura} °C = {fahrenheit} °F");
                        break;
                    case 2:
                        Console.Write("Ingrese la temperatura en grados Fahrenheit: ");
                        temperatura=double.Parse(Console.ReadLine());

                        double celcius =  FahrenheiaCelsius(temperatura);
                        Console.WriteLine($"{temperatura} °F = {celcius} °C");
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
        public static double CelsiusaFahrenhei(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public static double FahrenheiaCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
