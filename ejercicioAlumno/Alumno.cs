using System;

namespace ejercicioAlumno
{
    class Alumno
    {
        // Atributos
        private string nombre;
        private double nota;

        // Constructor
        public Alumno(string nombre, double nota)
        {
            this.nombre = nombre;
            this.nota = nota;
        }

        // Métodos
        public void Imprimir()
        {
            Console.WriteLine($"El nombre del alumno es: {nombre}");
            Console.WriteLine($"La nota del alumno es: {nota}");
        }

        public void Aprobado()
        {
            if (nota > 5)
            {
                Console.WriteLine("El alumno está aprobado");
            }
            else
            {
                Console.WriteLine("El alumno está reprobado");
            }
        }
    }
}