using System;

namespace ejercicioMayorEdad
{
    class Persona
    {
        // Atributos
        private string nombre;
        private int edad;

        // Constructor
        public MayorEdad(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        // Métodos
        public void Imprimir()
        {
            Console.WriteLine($"El nombre del alumno es: {nombre}");
            Console.WriteLine($"La edad del alumno es: {edad}");
        }

        public void Mayor()
        {
            if (edad >= 18)
            {
                Console.WriteLine("El alumno es mayor de edad");
            }
            else
            {
                Console.WriteLine("El alumno es menor de edad");
            }
        }
    }
}