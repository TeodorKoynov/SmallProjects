using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryThree
{
    public class BinaryTree<T>
    {
        private BinaryTreeNode<T> root;
        public class BinaryTreeNode<T>
        {
            private T value = default;
            private bool hasParent = false;
            private BinaryTreeNode<T> rightChild = null;
            private BinaryTreeNode<T> leftChild = null;

            public BinaryTreeNode<T> RighChild
            {
                get
                {
                    return this.rightChild;
                }
                set
                {
                    if (value == null)
                    {
                        return;
                    }
                    if (value.hasParent == true)
                    {
                        throw new ArgumentException("The node has a parent!");
                    }
                    value.hasParent = true;
                    this.rightChild = value;
                }
            }

            public BinaryTreeNode<T> LeftChild
            {
                get
                {
                    return this.leftChild;
                }
                set
                {
                    if (value == null)
                    {
                        return;
                    }
                    if (value.hasParent == true)
                    {
                        throw new ArgumentException("The node has a parent!");
                    }
                    value.hasParent = true;
                    this.leftChild = value;
                }
            }

            public T Value

            {
                get
                {
                    return this.value;
                }
                set
                {
                    this.value = value;
                }
            }

            public BinaryTreeNode(T value, BinaryTreeNode<T> rightNode, BinaryTreeNode<T> leftNode)
            {
                if (value == null)
                {
                    throw new ArgumentException("Value cannot be null!");
                }
                this.value = value;
                this.rightChild = rightNode;
                this.leftChild = leftNode;
            }
            public BinaryTreeNode(T value)
                : this(value, null, null)
            {
            }
        }

        public BinaryTreeNode<T> Root
        {
            get
            {
                return this.root;
            }
        }

        public BinaryTree(T value, BinaryTree<T> leftChild, BinaryTree<T> rightChild)
        {
            if (value == null)
            {
                throw new ArgumentException("Value cannot be null!");
            }

            BinaryTreeNode<T> leftChildNode = leftChild != null ? leftChild.root : null;
            BinaryTreeNode<T> rightChildNode = rightChild != null ? rightChild.root : null;
            this.root = new BinaryTreeNode<T>(
            value, leftChildNode, rightChildNode);
        }

        public BinaryTree(T value)
        :this(value, null, null)
        { 
        }

        private void PrintInOrder(BinaryTreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }

            PrintInOrder(root.RighChild);

            Console.Write(root.Value + " ");

            PrintInOrder(root.LeftChild);

        }

        public void PrintInOrder()
        {
            PrintInOrder(this.root);
        }
    }
}
