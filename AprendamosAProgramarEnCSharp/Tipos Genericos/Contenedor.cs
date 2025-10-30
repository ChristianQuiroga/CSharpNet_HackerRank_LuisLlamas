using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendamosAProgramarEnCSharp.Tipos_Genericos
{
    public class Contenedor<T>
    {
        private T _elemento;

        public void Guardar(T item)
        {
            _elemento = item;
        }

        public T Obtener()
        {
            return _elemento;
        }
    }

}
