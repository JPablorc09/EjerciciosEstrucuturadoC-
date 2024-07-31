using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             Console.WriteLine("Ingrese la base del triangulo: ");
             double bas=double.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese la altura del triangulo: ");
             double altura = double.Parse(Console.ReadLine());
             Console.ReadKey();
            calcularAreaTriangulo(bas, altura);
        }
        static void calcularAreaTriangulo(double bas,double altura)
        {
            double area;
            area= (bas*altura)/2;

            Console.WriteLine("El resultado del area del triangulo es de: {0}",area);
            Console.ReadKey();
        }
        
    }
}
