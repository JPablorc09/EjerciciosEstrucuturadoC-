using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una frase no más de 20 caracteres:");
            string frase = Console.ReadLine();

            // Validar que la frase tenga como máximo 20 caracteres
            if (frase.Length > 20)
            {
                Console.WriteLine("La frase ingresada tiene más de 20 caracteres. Inténtelo de nuevo.");
                return;
            }

            int conteoVocales = ContarVocales(frase);

            Console.WriteLine($"La frase \"{frase}\" tiene {conteoVocales} vocales.");
            Console.ReadLine();
        }
        public static int ContarVocales(string frase)
        {
            int contador = 0;
            string vocales = "aeiouAEIOU";

            foreach (char c in frase)
            {
                if (vocales.Contains(c))
                {
                    contador++;
                }
            }

            return contador;
        }
        
    }
}
