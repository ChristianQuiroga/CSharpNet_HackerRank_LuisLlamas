using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days
{
    internal class Difference
    {
        //Un campo es una variable declarada directamente dentro de una clase o estructura.
        //Generalmente es privado y se usa para almacenar datos.

        // Notación: Se usa camelCase (la primera letra en minúscula) y prefijo de subrayado _.
        private int[] elements;
        public int maximumDifference;

        //Constructor
        public Difference(int[] arr)
        {
            this.elements = arr;
            this.maximumDifference = 0;
        }

        //Método 
        public int computeDifference()  //porque no Static??? Resp. Porque tiene que ser instanciado para acceder al método. 
            //Porque un método static no puede acceder a miembros(campos o propiedades) no estáticos de la clase.
            //El campo elements no es static, pero el método sí lo es.Esto rompe las reglas del lenguaje.
        {
            Array.Sort(elements); //Ordena 3, 10, 4, 1, 6
            maximumDifference = Math.Abs(elements[0] - elements[elements.Length - 1]); //aca va ser siempr del primero con el último.
            
            return maximumDifference;
        }
    }
}
