using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_058
{
    class Node
    {
        //creates Nodes for the circular nexted list
        public int rollNumber;
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

        public bool Search(int rollNo, ref Node previous,ref Node current)
        //search for the specified node
        {
            for (previous = current = LAST.next; current != LAST; previous = current, current = current.next)
            {
                if (rollNo == current.rollNumber)
                    return (true); //return true if node is found
            }
            if(rollNo==LAST.rollNumber) //if yhe node is presents at the end
                    return true; 
                else
                    return (false); //return false if node not found
        }

        public bool listEmpty()
        {
            if(LAST==null) 
                return true;
            else
                return false;
        }

        public void traverse()  //traverse att the node of the list
        {
            if(listEmpty())
                Console.WriteLine("\n List is Empty");
            else
            {
                Console.WriteLine("\n Records in the list are:\n);
                node currentNode;
                currentNode=LAST.next;
                while(currentNode !=LAST)
                {
                    Console.WriteLine(currentNode.rollNumber + "  " + cureentNode.name + "\n");
                    currentNode = currentNode.next;
                }
                Console.Write(LAST.rollNumber + " " +LAST.name+"\n");
            }
        }
        

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
