using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario los tres números
            Console.Write("Ingrese el primer número (límite inferior del intervalo): ");
            double limiteInferior;
            if (!double.TryParse(Console.ReadLine(), out limiteInferior))
            {
                Console.WriteLine("Error: Ingrese un número válido.");
                return;
            }

            Console.Write("Ingrese el tercer número (a verificar): ");
            double numeroVerificar;
            if (!double.TryParse(Console.ReadLine(), out numeroVerificar))
            {
                Console.WriteLine("Error: Ingrese un número válido.");
                return;
            }

            Console.Write("Ingrese el último número (límite superior del intervalo): ");
            double limiteSuperior;
            if (!double.TryParse(Console.ReadLine(), out limiteSuperior))
            {
                Console.WriteLine("Error: Ingrese un número válido.");
                return;
            }

            // Verificar si el número pertenece al intervalo
            bool perteneceAlIntervalo = numeroVerificar >= limiteInferior && numeroVerificar <= limiteSuperior;

            // Imprimir el resultado
            if (perteneceAlIntervalo)
            {
                Console.WriteLine($"El número {numeroVerificar} pertenece al intervalo [{limiteInferior}, {limiteSuperior}].");
            }
            else
            {
                Console.WriteLine($"El número {numeroVerificar} NO pertenece al intervalo [{limiteInferior}, {limiteSuperior}].");
            }
            Console.ReadKey();
        }
    }
}
