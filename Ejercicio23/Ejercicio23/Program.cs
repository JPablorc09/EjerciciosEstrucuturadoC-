using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero del 1 en adelante");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Por favor ingrese un valor mayo a cero");
            }
            Console.ReadKey();
        }
    }
}
