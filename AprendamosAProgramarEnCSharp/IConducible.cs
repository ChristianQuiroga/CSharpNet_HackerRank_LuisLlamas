using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendamosAProgramarEnCSharp
{
    public interface IConducible
    {
        string Matricula { get; set; }

        // Métodos
        void Conducir();
        void Frenar();
    }
}
