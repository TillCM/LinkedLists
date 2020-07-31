using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLinkedList.Node
{
    public class CustomNode
    {
        /* this class is the Node class that allows us to create and delete Nodes
         * it has two constructors - one that accepts data and one that does not
         * It also creates a node that will serve as our next value*/


      public CustomNode Next;
      public CustomNode Previous;
      public string data;

        public CustomNode()
        {

        }
        public CustomNode(string data)
        {
            this.data = data;
            
        }
    }
}
