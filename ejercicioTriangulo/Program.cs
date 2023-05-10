/*
Desarrollar un programa que cargue los datos de un triángulo. Implementar una clase con los métodos para inicializar los atributos,
imprimir el nombre y valor del lado con un tamaño mayor y  el tipo de triángulo que es (equilátero, isósceles o escaleno).
*/

using System;

namespace ejercicioTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado1, lado2, lado3 = 0;

            lado1 = LeerNumero("Ingresa el lado 1 del triángulo: ");
            lado2 = LeerNumero("Ingresa el lado 2 del triángulo: ");
            lado3 = LeerNumero("Ingresa el lado 3 del triángulo: ");

            Triangulo triangulo = new Triangulo(lado1, lado2, lado3);
            triangulo.Imprimir();
            triangulo.TipoTriangulo();
            triangulo.ladoMayor();
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