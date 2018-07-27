using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Node
    {
        public Node()
        {
            Data = 0;
            Next = null;
        }
        public int Data { get; set; }
        public Node Next { get; set; } 
    }
}
