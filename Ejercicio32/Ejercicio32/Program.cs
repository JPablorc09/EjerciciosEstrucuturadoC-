using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el texto para verificar si es un palíndromo:");
            string texto = Console.ReadLine();

            // Limpiar el texto: quitar espacios y convertir a minúsculas
            string textoLimpio = LimpiarTexto(texto);

            // Verificar si es un palíndromo
            bool esPalindromo = EsPalindromo(textoLimpio);

            if (esPalindromo)
            {
                Console.WriteLine("El texto es un palíndromo.");
            }
            else
            {
                Console.WriteLine("El texto no es un palíndromo.");
            }
            Console.ReadKey ();
        }

        static string LimpiarTexto(string texto)
        {
            // Quitar espacios y convertir a minúsculas
            string textoSinEspacios = texto.Replace(" ", "").ToLower();

            // Opcional: eliminar caracteres no alfanuméricos (solo si quieres ignorar puntuaciones)
            textoSinEspacios = new string(Array.FindAll(textoSinEspacios.ToCharArray(), char.IsLetterOrDigit));

            return textoSinEspacios;
        }

        static bool EsPalindromo(string texto)
        {
            int izquierda = 0;
            int derecha = texto.Length - 1;

            while (izquierda < derecha)
            {
                if (texto[izquierda] != texto[derecha])
                {
                    return false;
                }

                izquierda++;
                derecha--;
            }

            return true;
        }
    }
}

