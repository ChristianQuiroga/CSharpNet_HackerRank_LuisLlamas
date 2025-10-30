using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days.Day19_Interfaces
{
    internal class Calculator_I : AdvancedArithmetic 
    {
    

        // Method
        public int divisorSum(int n)
        {
            int sumEnteros = 0;
            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    sumEnteros += i;
                }
            }
            return sumEnteros;
        }
    }
}
