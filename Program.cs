using System;
using data_structures_and_algorithms.linked_list;

namespace data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            testLinkedList();
        }

        static void testLinkedList()
        {
            LinkedList testList = new LinkedList();

            for (int i = 0; i < 10; i++)
            {
                testList.add(i);
            }


            ListNode iterator = testList.getHead();

            while (iterator != null)
            {
                Console.WriteLine(iterator.getData());
                iterator = iterator.nextNode;
            }

            Console.WriteLine(testList.getSize().ToString());
            Console.WriteLine("Hello World!");
        }
    }
}
