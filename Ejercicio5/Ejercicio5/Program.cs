using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedir al usuario que ingrese el radio del círculo
            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();

            // Llamar al método para calcular longitud y área
            calcularCirculo(radio);

        }
        static  void calcularCirculo(double radio)
        {
            // Calcular la longitud de la circunferencia (2 * π * radio)
            double longitudCircunferencia = 2 * Math.PI * radio;

            // Calcular el área del círculo (π * radio^2)
            double areaCirculo = Math.PI * radio * radio;

            // Mostrar los resultados
            Console.WriteLine($"Longitud de la circunferencia: {longitudCircunferencia}");
            Console.WriteLine($"Área del círculo: {areaCirculo}");
            Console.ReadKey();
        }
       
        
    }
}
