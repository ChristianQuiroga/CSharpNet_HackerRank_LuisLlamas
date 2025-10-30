using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days.Day17_MoreExceptions
{
    internal class Calculator
    {

        //Method
        public int power(int n, int p) 
        {
            if (n < 0 || p < 0)
            {
                throw new Exception("n and p should be non-negative");
            }
                
            //El método Math.Pow() está definido en la clase Math y requiere que se importe el espacio de nombres System.
            return (int)Math.Pow(n, p);
        }
    }
}
