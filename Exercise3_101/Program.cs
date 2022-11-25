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
        
    }

}
    
