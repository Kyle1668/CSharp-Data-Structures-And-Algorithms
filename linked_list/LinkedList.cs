using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.linked_list
{
    class LinkedList
    {
        private ListNode head;
        private ListNode tail;
        private int size;

        public LinkedList()
        {
            size = 0;
        }

        public LinkedList(int inData)
        {
            size = 1;
            head = tail = new ListNode(inData);
        }

        public ListNode getHead()
        {
            return head;
        }

        public ListNode getTail()
        {
            return tail;
        }

        public int getSize()
        {
            return size;
        }

        public void add(int inData)
        {
            if (size == 0)
            {                
                head = tail = new ListNode(inData);
            }
            else
            {
                ListNode newNode = new ListNode(inData);
                tail.nextNode = newNode;
                newNode.prevNode = tail;
                tail = newNode;
            }
            size++;
        }
    }
}
