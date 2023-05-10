/*
Realizar un programa que tenga una clase Persona con las siguientes características.
La clase tendrá como atributos el nombre y la edad de una persona.
Implementar los métodos necesarios para inicializar los atributos,
mostrar los datos e indicar si la persona es mayor de edad o no.
*/

using System;

namespace ejercicioMayorEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            int edad = 0;

            nombre = LeerNombre("Ingresa el nombre de la persona: ");
            edad = LeerEdad("Ingresa la edad de la persona: ");

            MayorEdad persona = new MayorEdad(nombre, edad);
            persona.Imprimir();
            persona.Mayor();
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

        static int LeerEdad(string mensaje)
        {
            Console.Write(mensaje);
            string input = Console.ReadLine() ?? "";

            int edad;
            while (!int.TryParse(input, out edad))
            {
                Console.WriteLine("El valor ingresado no es un número válido. Intenta nuevamente.");
                Console.Write(mensaje);
                input = Console.ReadLine() ?? "";
            }

            return edad;
        }
    }
}