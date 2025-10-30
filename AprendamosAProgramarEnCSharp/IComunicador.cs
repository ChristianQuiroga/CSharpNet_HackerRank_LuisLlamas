using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendamosAProgramarEnCSharp
{
    internal interface IComunicador
    {
        //Métodos
        void Llamar(string numero);
        void EnviarMensaje(string numero, string mensaje);
    }
}
