using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.BST
{
    public enum TraversalType
    {
        PreOrder,
        InOrder,  //sorted
        OutOrder, //reverse sorted
        PostOrder
    }

    class BinarySearchTree<T> where T: IComparable<T>,IEquatable<T>
    {
        Node<T> Root;

        public void Insert(T Value)
        {
            if (Root == null)
            {
                Root = new Node<T>(Value);
            }
            else
            {
                InsertHelper(Value,Root);
            }
        }

        public void Insert(T[] Value)
        {
            if (Value.Length == 0)
            {
                return;
            }

            int index = 0;
            
            if (Root == null)
            {
                Root = new Node<T>(Value[0]);
                index++;
            }

            for(int i=index; i < Value.Length; i++)
            {
                InsertHelper(Value[i], Root);
            }
        }

        private Node<T> InsertHelper(T Value, Node<T> node)
        {
            if (node == null)
            {
                node = new Node<T>(Value);
                return node;
            }

            if (Value.CompareTo(node.Value) == -1) //-1 for <
            {
                node.Left = InsertHelper(Value, node.Left);
            }
            else
            {
                node.Right = InsertHelper(Value, node.Right);
            }

            return node;
        }

        public Node<T> Search(T Value)
        {
            if (Root.Value.Equals(Value))
            {
                return Root;
            }
            else
            {
                return SearchHelper(Value, Root);
            }
        }
        private Node<T> SearchHelper(T Value, Node<T> node)
        {
            if (node == null)
            {
                return node;
            }
            if (Value.Equals(node.Value))
            {
                return node;
            }

            if (Value.CompareTo(node.Value) == -1) //-1 for <
            {
                node = SearchHelper(Value, node.Left);
            }
            else
            {
                node = SearchHelper(Value, node.Right);
            }

            return node;
        }
        public void Traverse(Action<Node<T>> process,TraversalType travType)
        {
            if (Root == null)
            {
                return;
            }

            switch (travType)
            {
                case TraversalType.PreOrder:TraverseHelperPreOrder(process,Root); break;
                case TraversalType.InOrder:TraverseHelperInOrder(process,Root); break;
                case TraversalType.PostOrder:TraverseHelperPostOrder(process,Root); break;
                case TraversalType.OutOrder:TraverseHelperOutOrder(process,Root); break;
            }

        }
        private void TraverseHelperPreOrder(Action<Node<T>> process, Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            process(node);
            TraverseHelperPreOrder(process,node.Left);
            TraverseHelperPreOrder(process,node.Right);

        }
        private void TraverseHelperInOrder(Action<Node<T>> process, Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            TraverseHelperInOrder(process, node.Left);
            Console.Write(node.Value + ",");
            TraverseHelperInOrder(process, node.Right);
            
        }
        private void TraverseHelperPostOrder(Action<Node<T>> process, Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            TraverseHelperPostOrder(process, node.Left);
            TraverseHelperPostOrder(process, node.Right);
            Console.Write(node.Value + ",");
        }
        private void TraverseHelperOutOrder(Action<Node<T>> process, Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            TraverseHelperOutOrder(process, node.Right);
            Console.Write(node.Value + ",");
            TraverseHelperOutOrder(process, node.Left);

        }

    }
}
