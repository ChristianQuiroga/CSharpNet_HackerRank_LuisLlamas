using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendamosAProgramarEnCSharp
{
    [Serializable]
    internal class Persona
    {
        // Campos
        public string Nombre { get; set; } // Propiedad para el nombre de la persona
        public int Edad { get; set; } // Propiedad para la edad de la persona

        // Método constructor
        public Persona(string nombre, int edad)
        {
            Nombre = nombre; // Asigna el nombre proporcionado al campo Nombre
            Edad = edad; // Asigna la edad proporcionada al campo Edad
        }
        public Persona() { } //Constructor Vacio

        [Obsolete("Este método es obsoletoooo")]
        // Método
        public void Saludar()
        {
            Console.WriteLine($"¡Hola, soy {Nombre} y tengo {Edad} años!"); // Imprime un saludo con el nombre y la edad de la persona
        }
    }

}
