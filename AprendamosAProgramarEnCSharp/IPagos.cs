using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendamosAProgramarEnCSharp
{
    internal interface IPagos
    {
        //Métodos
        void ProcesarPago(decimal monto);
        void ReembolsarPago(decimal monto);
    }
}
