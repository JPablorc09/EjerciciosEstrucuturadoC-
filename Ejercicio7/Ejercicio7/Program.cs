using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una letra: ");
            char vocal =char.Parse(Console.ReadLine());
            Console.ReadKey();
            if (esVocal(vocal))
            {
                Console.WriteLine("La letra ingresada es una vocal");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("la letra no es una vocal");
                Console.ReadKey();
            }
        }
        static bool esVocal(char vocal)
        {
            vocal=char.ToLower(vocal);

            switch (vocal)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;
                default:
                    return false;
            }
        }
    }
}
