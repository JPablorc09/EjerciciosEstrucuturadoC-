using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir la contraseña correcta
            string contraseñaCorrecta = "Contra123";
            int intentosMaximos = 3;
            int intentos = 0;
            bool contrasenaCorrecta = false;

            Console.WriteLine("Ingrese la contraseña:");

            while (intentos < intentosMaximos && !contrasenaCorrecta)
            {
                // Leer la contraseña ingresada por el usuario
                string contraseñaIngresada = Console.ReadLine();

                // Comparar la contraseña ingresada con la correcta
                if (contraseñaIngresada == contraseñaCorrecta)
                {
                    contrasenaCorrecta = true;
                    Console.WriteLine("Contraseña correcta. Acceso concedido.");
                }
                else
                {
                    intentos++;
                    if (intentos < intentosMaximos)
                    {
                        Console.WriteLine($"Contraseña incorrecta. Te quedan {intentosMaximos - intentos} intentos.");
                    }
                    else
                    {
                        Console.WriteLine("Has excedido el número máximo de intentos. Acceso denegado.");
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}
