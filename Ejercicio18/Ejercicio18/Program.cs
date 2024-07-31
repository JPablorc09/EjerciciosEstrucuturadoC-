using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario los tres lados del triángulo
            Console.Write("Ingrese el primer lado del triángulo: ");
            double lado1;
            if (!double.TryParse(Console.ReadLine(), out lado1) || lado1 <= 0)
            {
                Console.WriteLine("Error: Ingrese un valor válido para el primer lado.");
                return;
            }

            Console.Write("Ingrese el segundo lado del triángulo: ");
            double lado2;
            if (!double.TryParse(Console.ReadLine(), out lado2) || lado2 <= 0)
            {
                Console.WriteLine("Error: Ingrese un valor válido para el segundo lado.");
                return;
            }

            Console.Write("Ingrese el tercer lado del triángulo: ");
            double lado3;
            if (!double.TryParse(Console.ReadLine(), out lado3) || lado3 <= 0)
            {
                Console.WriteLine("Error: Ingrese un valor válido para el tercer lado.");
                return;
            }

            // Verificar si los lados forman un triángulo
            if (EsTriangulo(lado1, lado2, lado3))
            {
                // Determinar el tipo de triángulo
                string tipoTriangulo = ObtenerTipoTriangulo(lado1, lado2, lado3);
                Console.WriteLine($"Los lados {lado1}, {lado2} y {lado3} forman un triángulo {tipoTriangulo}.");
            }
            else
            {
                Console.WriteLine("Los lados ingresados no forman un triángulo.");
            }
            Console.ReadKey();  
        }

        // Método para verificar si los lados forman un triángulo
        public static bool EsTriangulo(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        // Método para obtener el tipo de triángulo
        public static string ObtenerTipoTriangulo(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "equilátero";
            }
            else if (a == b || b == c || a == c)
            {
                return "isósceles";
            }
            else
            {
                return "escaleno";
            }
        }
    }
}

