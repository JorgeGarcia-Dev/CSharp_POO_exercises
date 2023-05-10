/*
Realizar un programa que conste de una clase llamada Alumno que tenga como atributos el nombre y la nota del alumno.
Definir los métodos para inicializar sus atributos, imprimirlos y mostrar un mensaje con el resultado de la nota y si ha aprobado o no.
*/

using System;

namespace ejercicioAlumno
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            double nota = 0;

            nombre = LeerNombre("Ingresa el nombre del alumno: ");
            nota = LeerNota("Ingresa la nota del alumno: ");

            Alumno alumno = new Alumno(nombre, nota);
            alumno.Imprimir();
            alumno.Aprobado();
        }

        static string LeerNombre(string mensaje)
        {
            Console.Write(mensaje);
            string input = Console.ReadLine() ?? "";

            while (input == "")
            {
                Console.WriteLine("El nombre no puede estar vacío. Intenta nuevamente.");
                Console.Write(mensaje);
                input = Console.ReadLine() ?? "";
            }

            return input;
        }

        static double LeerNota(string mensaje)
        {
            Console.Write(mensaje);
            string input = Console.ReadLine() ?? "";

            double nota;
            while (!double.TryParse(input, out nota))
            {
                Console.WriteLine("El valor ingresado no es un número válido. Intenta nuevamente.");
                Console.Write(mensaje);
                input = Console.ReadLine() ?? "";
            }

            return nota;
        }
    }
}