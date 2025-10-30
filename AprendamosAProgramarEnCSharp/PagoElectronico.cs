using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendamosAProgramarEnCSharp
{
    internal class PagoElectronico : IPagos
    {
        //Implementación de métodos
        public void ProcesarPago(decimal monto)
        {
            Console.WriteLine($"Procesando pago de {monto}.");
        }
        public void ReembolsarPago(decimal monto)
        {
            Console.WriteLine($"Reembolsando pago de {monto}.");
        }
    }
}
