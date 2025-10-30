using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendamosAProgramarEnCSharp.EjePolimorfismoHerencia
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        //Método
        public virtual void Conducir()
        {
            Console.WriteLine($"Conduciciendo Vehiculo! {Marca} {Modelo}");
        }
    }
}
