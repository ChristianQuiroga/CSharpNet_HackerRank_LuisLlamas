using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendamosAProgramarEnCSharp
{
    public class Bicicleta : IConducible
    {
        // Implementación de propiedades    
        public string Matricula { get; set; }
        // implementación
        // Implementación de métodos
        public void Conducir()
        {
            Console.WriteLine("La bicicleta ha comenzado a moverse.");
        }

        public void Frenar()
        {
            Console.WriteLine("La bicicleta se ha detenido.");
        }
    }
}
