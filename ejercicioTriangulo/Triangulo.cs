using System;

namespace ejercicioTriangulo
{
    class Triangulo
    {   
        // Atributos
        private double lado1;
        private double lado2;
        private double lado3;

        // Constructor
        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }
        // Métodos
        public void Imprimir()
        {
            Console.WriteLine($"El lado 1 mide: {lado1}cm");
            Console.WriteLine($"El lado 2 mide: {lado2}cm");
            Console.WriteLine($"El lado 3 mide: {lado3}cm");
        }

        public void TipoTriangulo()
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero");
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                Console.WriteLine("El triángulo es isósceles");
            }
            else
            {
                Console.WriteLine("El triángulo es escaleno");
            }
        }
        public void ladoMayor()
        {
            if (lado1 > lado2 && lado1 > lado3)
            {
                Console.WriteLine($"El lado mayor es: lado1 ({lado1}cm)");
            }
            else if (lado2 > lado1 && lado2 > lado3)
            {
                Console.WriteLine($"El lado mayor es: lado2 ({lado2}cm)");
            }
            else if (lado3 > lado1 && lado3 > lado2)
            {
                Console.WriteLine($"El lado mayor es: lado3 ({lado3}cm)");
            }
            else if (lado1 > lado2 && lado3 > lado2)
            {
                Console.WriteLine($"Los 2 lados mayores son: lado1 ({lado1}) y lado3 ({lado3}cm)");
            }
            else if (lado2 > lado1 && lado3 > lado1)
            {
                Console.WriteLine($"Los 2 lados mayores son: lado2 ({lado2}cm) y lado3 ({lado3}cm)");
            }
            else if (lado1 > lado3 && lado2 > lado3)
            {
                Console.WriteLine($"Los 2 lados mayores son: lado1 ({lado1}cm) y lado2 ({lado2}cm)");
            }
            else
            {
                Console.WriteLine("Los 3 lados son iguales");
            }
        }
    }
}