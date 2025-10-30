using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendamosAProgramarEnCSharp
{
    public class Coche : IConducible
    {
        // Implementación de propiedades    
        public string Matricula { get; set; }

        // Implementación de métodos
        public void Conducir()
        {
            Console.WriteLine("El coche está en marcha.");
        }

        public void Frenar()
        {
            Console.WriteLine("El coche se ha detenido.");
        }
    }
}
