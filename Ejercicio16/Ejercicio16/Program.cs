using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ingreso de datos
            Console.Write("Ingrese el valor por hora ($): ");
            decimal valorHora;
            if (!decimal.TryParse(Console.ReadLine(), out valorHora) || valorHora <= 0)
            {
                Console.WriteLine("Error: Ingrese un valor por hora válido.");
                return;
            }

            Console.Write("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la antigüedad del empleado (en años): ");
            int antiguedad;
            if (!int.TryParse(Console.ReadLine(), out antiguedad) || antiguedad < 0)
            {
                Console.WriteLine("Error: Ingrese una antigüedad válida.");
                return;
            }

            Console.Write("Ingrese la cantidad de horas trabajadas en el mes: ");
            int horasTrabajadas;
            if (!int.TryParse(Console.ReadLine(), out horasTrabajadas) || horasTrabajadas < 0)
            {
                Console.WriteLine("Error: Ingrese una cantidad válida de horas trabajadas.");
                return;
            }

            // Cálculos
            decimal salarioBruto = valorHora * horasTrabajadas;
            decimal antiguedadBonificacion = antiguedad * 30;
            decimal totalBruto = salarioBruto + antiguedadBonificacion;
            decimal descuento = totalBruto * 0.13m;
            decimal salarioNeto = totalBruto - descuento;

            // Impresión del recibo
            Console.WriteLine();
            Console.WriteLine("RECIBO DE SALARIO");
            Console.WriteLine("-----------------");
            Console.WriteLine($"Nombre del empleado: {nombre}");
            Console.WriteLine($"Antigüedad: {antiguedad} años");
            Console.WriteLine($"Valor por hora: ${valorHora}");
            Console.WriteLine($"Total a cobrar en bruto: ${totalBruto}");
            Console.WriteLine($"Total de descuentos (13%): ${descuento}");
            Console.WriteLine($"Valor neto a cobrar: ${salarioNeto}");
            Console.ReadKey();
        }
    }
 }

