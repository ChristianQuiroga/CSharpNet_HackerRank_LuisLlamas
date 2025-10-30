using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendamosAProgramarEnCSharp
{
    internal class Producto
    {

        // Campos
        public string Nombre { get; set; } // Propiedad para el nombre del producto
        public decimal Precio { get; set; } // Propiedad para el precio del producto

        // Método constructor
        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre; // Asigna el nombre proporcionado al campo Nombre
            Precio = precio; // Asigna el precio proporcionado al campo Precio
        }

        // Método
        public void MostrarInformacion()
        {
            Console.WriteLine($"Producto: {Nombre}, Precio: {Precio}"); // Imprime la información del producto
        }
    }
}
