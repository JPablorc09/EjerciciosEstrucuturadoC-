using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("El promedio de los numeros es: {0}", promedio());
            Console.ReadKey();
        }
        static double promedio()
        {
            Console.WriteLine("Ingrese el primer numero");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            double num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero");
            double num4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el quinto numero");
            double num5 = double.Parse(Console.ReadLine());
            Console.ReadKey();
            double promedio = num1 + num2 + num3 + num4 + num5 / 5 ;
            return promedio;
        }
    }
  
}
