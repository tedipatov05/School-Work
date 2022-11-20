using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Динамична_реализация_на_спиък
{
    internal class DynamicList
    {
        private Node head;
        private Node tail;
        private int count;

        

        public DynamicList()

        {
            head = null;
            tail = null;
            Count = 0;

        }
        public int Count
        { private set; get; }
        public object this[int index]
        {
            set
            {
                if(index< Count || index >=Count)
                {
                    throw new ArgumentOutOfRangeException("index Out of Range");
                }
                int i = 0;
                Node current = head;
                while(current != null && i < index)
                {
                    current = current.Next;
                    i++;
                }
                current.Element = value;

            }
            get
            {
                if (index < Count || index >= Count)
                {
                    throw new ArgumentOutOfRangeException("index Out of Range");
                }
                int i = 0;
                Node current = head;
                while (current != null && i < index)
                {
                    current = current.Next;
                    i++;
                }
                return current.Element;

            }
        }

        public void Add(object item)
        {
            Node node = new Node(item);
            if(head==null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;

            }
            tail = node;    
            Count++;
        }
        public int Remove(object item )

        {
            if(head==null || tail==null)
            {
                throw new InvalidOperationException("The list is empty!");
            }
            int index = -1, i = 0;
            Node current = head;
            Node prevCurrent = null;
            if(Count == 1 && current.Element.Equals(item))
            {
                head = null;
                tail = null;
                index = 0;
            }
            else
            {
                while (current != null && !current.Element.Equals(item))
                {
                    prevCurrent = current;
                    current = current.Next;
                    i++;
                }
            }
            
            if(current.Element.Equals(item))
            {
                prevCurrent.Next = current.Next;
                index = i;
            }
            return index;
           

            
        }
        public object RemoveAt(int index)
        {
            if(head ==null || tail ==null)
            {
                throw new InvalidOperationException("Empty list!");
            }
            Node current = head;
            Node prev = null;
            for(int i= 0; i < Count; i++)
            {
                prev = current;
                current=current.Next;

                if(i == index)
                {
                    prev.Next = current.Next;
                    Count--;
                    break;
                }
            }
            return current;

        }
        public int IndexOf(object item)
        {
            int i = 0;
            Node currNode = head;
            while(currNode != null && !currNode.Element.Equals(item))
            {
                currNode = currNode.Next;
                i++;
            }
            if(currNode == null)
            {
                return -1;

            }
            return i;

        }
        public bool Contains(object item)
        {
            if(IndexOf(item)!=-1 )
            {
                return true;
            }
            return false;
        }

       


    }
}
