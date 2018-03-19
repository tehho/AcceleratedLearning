using System;

namespace S4L26
{
    public class Stack
    {
        internal class Node
        {
            public Node _next;
            public object _obj;
            public Node(object obj, Node next)
            {
                _next = next;
                _obj = obj;
            }
        }

        private Node first;
        public Stack()
        {
            first = null;
        }

        public void Push(object obj)
        { 
            if (obj == null)
            {
                throw (new InvalidOperationException("Input can't be null"));
            }
            first = new Node(obj, first);
        }

        public object Pop()
        {
            if (first == null)
            {
                throw (new InvalidOperationException("Stack is empty"));
            }

            object ret = first._obj;

            first = first._next;

            return ret;
        }

        public void Clear()
        {
            first = null;   
        }
    }
}
