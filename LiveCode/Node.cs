namespace LiveCode
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal class Node<T>
    {
        private T data;
        private Node<T> next;
        private Node<T> previous;

        public Node(T data)
        {
            Data = data;
            next = null;
            previous = null;
        }

        public T Data
        {
            get => data;
            set => data = value;
        }

        public Node<T> Next => next;

        public Node<T> Previous => previous;

        public void Add(Node<T> node)
            => next = node;

        public void AddPrevious(Node<T> node)
            => previous = node;

        public void Traverse()
        {
            var currentNode = this;
            while (currentNode.Next != null)
            {
                Console.WriteLine(currentNode);
                currentNode = currentNode.Next;
            }
        }

        public Node<T> Traverse(int iterations)
        {
            var currentNode = this;
            for (int i = 1; i < iterations; i++)
            {
                if (currentNode.Next == null)
                {
                    throw new ArgumentOutOfRangeException($"Invalid operation!{Environment.NewLine}Please insert iterations which are within the range!");
                }
                currentNode = currentNode.Next;
            }

            return currentNode;
        }

        public Node<T> TraverseBackwards(int iterations)
        {
            var currentNode = this;
            for (int i = iterations; i > 1; i--)
            {
                if (currentNode.Previous == null)
                {
                    throw new ArgumentOutOfRangeException($"Invalid operation!{Environment.NewLine}Please insert iterations which are within the range!");
                }
                currentNode = currentNode.Previous;
            }

            return currentNode;
        }

        public Node<T> Find(T data)
        {
            var currentNode = this;

            while (true)
            {
                if (data.Equals(currentNode.Data))
                {
                    return currentNode;
                }
                else if (currentNode.Next == null)
                {
                    return currentNode;
                }

                currentNode = currentNode.Next;
            }
        }

        public override string ToString()
            => data.ToString();
    }
}
