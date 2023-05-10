/*
Realizar un programa en el cual se declaren dos valores enteros por teclado utilizando el método __init__.
Calcular después la suma, resta, multiplicación y división.
Utilizar un método para cada una e imprimir los resultados obtenidos.
Llamar a la clase Calculadora.
*/

using System;

namespace ejercicioOperaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2 = 0;

            num1 = LeerNumero("Ingresa el primer número: ");
            num2 = LeerNumero("Ingresa el segundo número: ");

            Operaciones operaciones = new Operaciones(num1, num2);
            operaciones.Imprimir();
            operaciones.suma();
            operaciones.resta();
            operaciones.multiplicacion();
            operaciones.division();
        }

        static double LeerNumero(string mensaje)
        {
            Console.Write(mensaje);
            string input = Console.ReadLine() ?? "";

            double numero;
            while (!double.TryParse(input, out numero))
            {
                Console.WriteLine("El valor ingresado no es un número válido. Intenta nuevamente.");
                Console.Write(mensaje);
                input = Console.ReadLine() ?? "";
            }

            return numero;
        }
    }
}