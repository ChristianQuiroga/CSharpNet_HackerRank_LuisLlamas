using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExamples
{
    public class EmptyBST<D>  : Tree<D> where D : IComparable<D>
    {
        public EmptyBST()
        {
        }
        public bool IsEmpty()
        {
            return true;
        }
        public int Cardinality()
        {
            return 0;
        }
        public bool Member(D elt)
        {
            return false;        }

        public NonEmptyBST<D> Add(D elt)
        {
            return new NonEmptyBST<D>(elt);
        }

        //
        public override string ToString()
        {
            return ".";
        }

    }
}
