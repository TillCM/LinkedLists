using BasicLinkedList.Node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLinkedList.LinkedList
{
    class DList
    {

        CustomNode head;
        int NodeCount = 0;
        public int check;
        CustomNode current;
        CustomNode temp;
        List<string> previousList;
        List<string> nextlist;
        CustomNode tail;


        public void append(string data)
        {
            /*This method walks through the list (from at head) and 
             * continually checks if there is a node next 
             * to the current node in the list 
             * it adds a new node with data if there are no nodes next to the current node
             * appending data :-)*/

            CustomNode customNode = new CustomNode(data);

            // check if there is a head 
            if (head == null)
            {
                // create a head if there is not one 
                head = new CustomNode(data);
                head.Next = null;
                head.Previous = null;
                NodeCount++;
                return;
            }
            // if there is a head -> start walking through the list staring at the head 
            current = head;
            //Check if there is node next to the current node (taversing the list)
            while (current.Next != null)
            {
                // keep moving through the list one node at a time 

                current = current.Next;

            }

            //create a new node if current.next is empty :-)
            current.Next = customNode;
            customNode.Previous = current;
            tail = customNode;
           

            NodeCount++;

        }

        public void insert(string data, int after)
        {
            CustomNode customNode = new CustomNode(data);
            current = head;
            int ithNode=1;

            while (ithNode != after)
            {
                current = current.Next;
                ithNode++;
            }

            temp = current.Next;
            current.Next = customNode;
            customNode.Next = temp;
            temp.Previous = customNode;
            customNode.Previous = current;
        }

        public List<string> showNext(int count, int listSize)
        {
            nextlist = new List<string>();
            current = head;

            nextlist.Add(current.data);

            while (current.Next != null)
            {

                nextlist.Add(current.Next.data);
                current = current.Next;

            }



            return nextlist;

        }


        public List<string> showPrevious()
        {
            previousList = new List<string>();
            current = tail;

            previousList.Add(current.data);

            while (current.Previous != null)
            {

                previousList.Add(current.Previous.data);
                current = current.Previous;

            }
            return previousList;

        }
    }
}
