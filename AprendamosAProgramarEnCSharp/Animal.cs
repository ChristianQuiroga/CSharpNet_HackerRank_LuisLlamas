using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendamosAProgramarEnCSharp
{
    public abstract class Animal
    {
        //Propiedades
        public string Nombre { get; set; }

        //Constructor
        public Animal()
        {

        }
        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        //Métodos
        public void Comer()
        {
            Console.WriteLine("El animal está comiendo.");
        }
        public virtual void HacerSonido()  //Sobrescritura en clase Base (Virtual)
        {
            Console.WriteLine("El animal hace un sonido.");
        }

        //Método Abstracto.
        public abstract void Dormir();
    }

}
