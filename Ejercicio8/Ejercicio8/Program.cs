using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int num=int.Parse(Console.ReadLine());
            Console.ReadKey();
            numeroPositivoNegativo(num);
        }
        static int numeroPositivoNegativo(int num)
        {
            if (num >= 1)
            {
                Console.WriteLine("El numero es positivo");
                Console.ReadKey();
            }
            else
                if (num == 0)
            {
                Console.WriteLine("el numero es neutro");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("El numero es negativo");
                Console.ReadKey();
            }
            return num;
        }
        
    }
}
