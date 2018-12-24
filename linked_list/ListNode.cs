using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms.linked_list
{
    class ListNode
    {
        private int data;
        public ListNode prevNode;
        public ListNode nextNode;
        
        public ListNode(int inData)
        {
            data = inData;
            prevNode = null;
            nextNode = null;
        }

        public int getData()
        {
            return data;
        }

        public void printNode()
        {
            int prevData = 0;
            int nextData = 0;
            Console.WriteLine("{data: {0}, pevNode.data: {1}, nextNode.data: {2}}", data, prevData, nextData);
        }

    }
}
