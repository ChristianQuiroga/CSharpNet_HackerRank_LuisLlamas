using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendamosAProgramarEnCSharp
{
    internal class Telefono : IEncendible, IComunicador
    {
        //
        //Implementación de métodos IEncendible
        public void Encender()
        {
            Console.WriteLine("El teléfono se está encendiendo.");
        }
        public void Apagar()
        {
            Console.WriteLine("El teléfono se está apagando.");
        }
        public void Reiniciar()
        {
            Console.WriteLine("El teléfono se está reiniciando.");
        }

        //
        //Implementación de métodos IComunicador
        public void Llamar(string numero)
        {
            Console.WriteLine($"Llamando al número {numero}.");
        }
        public void EnviarMensaje(string numero, string mensaje)
        {
            Console.WriteLine($"Enviando mensaje al número {numero}: {mensaje}");
        }
    }
}
