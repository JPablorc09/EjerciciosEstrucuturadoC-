using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un número entero positivo");
            num= Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            
            if (num > 0) {
                
                for (int i = 0; i < num; i++)
                {
                    suma += i;
                }
                // Mostrar el resultado
                Console.WriteLine("La suma de los números {0} que anteceden es {1}", num, suma);
            }
            else
            {
                // Manejar el caso en que la entrada no es un número entero positivo
                Console.WriteLine("Por favor, ingrese un número entero positivo válido.");
            }
            Console.ReadKey();
        }
    }
}
