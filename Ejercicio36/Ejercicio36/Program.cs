using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista para almacenar la información de los estudiantes
            var estudiantes = new List<Estudiante>();

            while (true)
            {
                // Mostrar el menú de opciones
                Console.WriteLine("Mantenimiento de Notas de Estudiantes");
                Console.WriteLine("1. Insertar nota");
                Console.WriteLine("2. Modificar nota");
                Console.WriteLine("3. Eliminar nota");
                Console.WriteLine("4. Mostrar todas las notas");
                Console.WriteLine("5. Salir");
                Console.Write("Elija una opción: ");

                // Leer la opción del usuario
                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        InsertarNota(estudiantes);
                        break;
                    case "2":
                        ModificarNota(estudiantes);
                        break;
                    case "3":
                        EliminarNota(estudiantes);
                        break;
                    case "4":
                        MostrarNotas(estudiantes);
                        break;
                    case "5":
                        return; // Salir del programa
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
        }

        static void InsertarNota(List<Estudiante> estudiantes)
        {
            Console.Write("Ingrese el nombre del estudiante: ");
            var nombre = Console.ReadLine();

            Console.Write("Ingrese la nota del estudiante: ");
            if (decimal.TryParse(Console.ReadLine(), out var nota))
            {
                estudiantes.Add(new Estudiante { Nombre = nombre, Nota = nota });
                Console.WriteLine("Nota insertada correctamente.");
            }
            else
            {
                Console.WriteLine("Nota inválida. Intente nuevamente.");
            }
        }

        static void ModificarNota(List<Estudiante> estudiantes)
        {
            Console.Write("Ingrese el nombre del estudiante cuya nota desea modificar: ");
            var nombre = Console.ReadLine();

            var estudiante = estudiantes.FirstOrDefault(e => e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (estudiante != null)
            {
                Console.Write("Ingrese la nueva nota: ");
                if (decimal.TryParse(Console.ReadLine(), out var nuevaNota))
                {
                    estudiante.Nota = nuevaNota;
                    Console.WriteLine("Nota modificada correctamente.");
                }
                else
                {
                    Console.WriteLine("Nota inválida. Intente nuevamente.");
                }
            }
            else
            {
                Console.WriteLine("Estudiante no encontrado.");
            }
        }

        static void EliminarNota(List<Estudiante> estudiantes)
        {
            Console.Write("Ingrese el nombre del estudiante cuya nota desea eliminar: ");
            var nombre = Console.ReadLine();

            var estudiante = estudiantes.FirstOrDefault(e => e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (estudiante != null)
            {
                estudiantes.Remove(estudiante);
                Console.WriteLine("Nota eliminada correctamente.");
            }
            else
            {
                Console.WriteLine("Estudiante no encontrado.");
            }
        }

        static void MostrarNotas(List<Estudiante> estudiantes)
        {
            if (estudiantes.Count == 0)
            {
                Console.WriteLine("No hay notas para mostrar.");
                return;
            }

            Console.WriteLine("Notas de los estudiantes:");
            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine($"Nombre: {estudiante.Nombre}, Nota: {estudiante.Nota}");
            }
            Console.ReadKey();
        }
    }

    class Estudiante
    {
        public string Nombre { get; set; }
        public decimal Nota { get; set; }
    }
    
}
    

