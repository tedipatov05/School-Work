using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Динамична_реализация_на_спиък
{
    internal class Node
    {
        private object element;
        private Node next;

        public object Element
        {
            get { return element; }
            set { element = value; }
        }
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }
        public Node(object _element)
        {
            Element = _element;
            Next = null;
        }
        public Node(object _element, Node prevNode)
        {
            Element = _element;
            prevNode.next = this;
        }
        public Node()
        {

        }
    }
}
