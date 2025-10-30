using System;
using System.Collections;

namespace HackerRankExamples
{
    public class NonEmptyBST<D> : Tree<D> where D : IComparable<D>
    {
        D data;
        Tree<D> left;
        Tree<D> right;

        // Constructor
        public NonEmptyBST(D elt)
        {
            data = elt;
            left = new EmptyBST<D>();
            right = new EmptyBST<D>();

        }
        public NonEmptyBST(D elt, Tree<D> leftTree, Tree<D> rightTree)
        {
            data = elt;
            left = leftTree;
            right = rightTree;

        }
        public bool IsEmpty()
        {
            return false;
        }
        public int Cardinality()
        {
            return 1 + left.Cardinality() + right.Cardinality();
        }

        public bool Member(D elt)
        {
            int cmp = elt.CompareTo(data);
            if (cmp == 0)
            {
                return true;
            }
            else if (cmp < 0)
            {
                return left.Member(elt);
            }
            else
            {
                return right.Member(elt);
            }
            //if (data == elt)
            //{
            //    return true;
            //}
            //else
            //{
            //    if (elt.CompareTo(data) < 0)
            //    {
            //        return left.member(elt);
            //    }
            //    else
            //    {
            //        return right.member(elt);
            //    }
            //}
        }

        public NonEmptyBST<D> Add(D elt)
        {
            int cmp = elt.CompareTo(data);
            if (cmp == 0)
            {
                return this; //ya está en el árbol, no se añade duplicado.
            }
            else if (cmp < 0)
            {
                return new NonEmptyBST<D>(data, left.Add(elt), right);
            }
            else
            {
                return new NonEmptyBST<D>(data, left, right.Add(elt));
            }
        }
        //if (data == elt)
        //{
        //    return this;
        //}
        //else
        //{
        //    if (elt.CompareTo(data) < 0)
        //    {
        //        return new NonEmptyBST(data, left.add(elt), right);
        //    }
        //    else
        //    {
        //        return new NonEmptyBST(data, left, right.add(elt));
        //    }
        //}

        public override string ToString()
        {
            return $"({left} {data} {right})";
        }
    }
}
