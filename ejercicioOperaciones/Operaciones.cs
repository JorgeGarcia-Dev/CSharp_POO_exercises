using System;

namespace ejercicioOperaciones
{
    class Operaciones
    {
        // Atributos
        private double num1;
        private double num2;

        // Constructor
        public Operaciones(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        // Métodos
        public void Imprimir()
        {
            Console.WriteLine($"El primer número es: {num1}");
            Console.WriteLine($"El segundo número es: {num2}");
        }

        public void suma()
        {
            double suma = num1 + num2;
            Console.WriteLine($"La suma de los números es: {suma}");
        }

        public void resta()
        {
            double resta = num1 - num2;
            Console.WriteLine($"La resta de los números es: {resta}");
        }

        public void multiplicacion()
        {
            double multiplicacion = num1 * num2;
            Console.WriteLine($"La multiplicación de los números es: {multiplicacion}");
        }

        public void division()
        {
            double division = num1 / num2;
            Console.WriteLine($"La división de los números es: {division}");
        }
    }
}