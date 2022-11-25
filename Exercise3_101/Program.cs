using Exercise3_101;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_101
{
    class Node
    {
         /*creates Nodes for the circular nexted list*/
           public int rollNumber;
           public bool Search;
           public string name;
           public Node next;
    }
    class CircularList
    {
        Node LAST;

        public CircularList()
        {
            LAST = null;
        }

        public bool Search()
        {
            if (LAST == null)
                return true;
            else
                return false;
        }
        public bool listEmpty()
        {
            if (LAST == null)
                return true;
            else
                return false;
        }
        
        public void traverse()
        {
            if (listEmpty())
                return;
            else
                LAST = LAST.next;
        }
        public void firstNode()
        {
            if (listEmpty())
                return;
            else
                LAST.next.rollNumber = 0;
        }
        static void Main(string[] args)
        {
            CircularList list = new CircularList();
            int pilihanmenu;
            char ch;

            Console.WriteLine("\nMenu");
            Console.WriteLine("1. View all the records in the list");
            Console.WriteLine("2. Search for a record in the list");
            Console.WriteLine("3. Display the first record in the list");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your Choice (1,2,3,4) :");

        }
    }

}
    
