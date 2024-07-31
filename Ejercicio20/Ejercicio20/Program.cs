using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese dos números
            Console.Write("Ingrese el primer número: ");
            double numero1;
            if (!double.TryParse(Console.ReadLine(), out numero1))
            {
                Console.WriteLine("Error: Ingrese un número válido.");
                return;
            }

            Console.Write("Ingrese el segundo número: ");
            double numero2;
            if (!double.TryParse(Console.ReadLine(), out numero2))
            {
                Console.WriteLine("Error: Ingrese un número válido.");
                return;
            }

            // Imprimir los números antes del intercambio
            Console.WriteLine($"Antes del intercambio: Número 1 = {numero1}, Número 2 = {numero2}");

            // Intercambiar los números usando una variable temporal
            double temp = numero1;
            numero1 = numero2;
            numero2 = temp;

            // Imprimir los números después del intercambio
            Console.WriteLine($"Después del intercambio: Número 1 = {numero1}, Número 2 = {numero2}");
            Console.ReadKey();
        }
        
    }
}

