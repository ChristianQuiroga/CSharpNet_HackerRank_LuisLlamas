using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExamples
{
    public interface Tree<D> where D : IComparable<D>
    {
        bool IsEmpty();
        int Cardinality();
        bool Member(D elt); //Generico
        NonEmptyBST<D> Add(D elt);
    }
}
