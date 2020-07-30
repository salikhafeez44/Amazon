using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.BST
{

    class Node<T> where T:IComparable<T>,IEquatable<T>
    {
        public T Value;
        public Node<T> Left;
        public Node<T> Right;

        public Node(T val)
        {
            Value = val;
        }

        public bool HasTwoChild()
        {
            if(Left!=null && Right != null)
            {
                return true;
            }
            return false;
        }

        public bool HasOneChild()
        {
            if(Left!=null || Right!= null)
            {
                return true;
            }
            return false;
        }

        public Node<T> HasChild()
        {
            if (HasOneChild())
            {
                if (Left != null) return Left;
                if (Right != null) return Right;
            }
            return null;
        }

    }
}
