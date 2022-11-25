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
                Console.WriteLine("\n Records in the list are:\n");
                Node currentNode;
                currentNode=LAST.next;
                while(currentNode !=LAST)
                {
                    Console.WriteLine(currentNode.rollNumber + "  " + currentNode.name + "\n");
                    currentNode = currentNode.next;
                }
                Console.Write(LAST.rollNumber + " " +LAST.name+"\n");
            }
        }
        
        public void firstNode()
        {
            if(listEmpty())
                Console.WriteLine("\nList is Empty");
            else
                Console.WriteLine("\nThe first record in the list is:\n\n" + LAST.next.rollNumber + " " + LAST.next.name);

        }

        static void Main(string[] args)
        {
            CircularList obj = new CircularList();
            while(true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. View all the records in the list");
                    Console.WriteLine("2. Search for a record in the list");
                    Console.WriteLine("3. Display the first record in the list");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\n Enter your choice(1-4):");
                    char ch=Convert.ToChar(Console.ReadLine());
                    switch(ch)
                    {
                        case '1':
                            {
                                obj.traverse();
                            }
                            break;
                        case '2':
                            {
                                if(obj.listEmpty() == true)
                                {
                                    Console.WriteLine("\nLisy is Empty");
                                    break;
                                }
                                Node prev, curr;
                                prev = curr = null;
                                Console.Write("\nEnter the roll number of the students whose records is to be searched: ");
                                int num =Convert.ToInt32(Console.ReadLine());
                                if(obj.Search(num,ref prev,ref curr)==false)
                                    Console.WriteLine("\nRecord Not found");
                                else
                                {
                                    Console.WriteLine("\nRecord found");
                                    Console.WriteLine("\nRoll Number: " + curr.rollNumber);
                                    Console.WriteLine("\nName"+ curr.name);
                                }
                            }
                            break;
                    }
                }
            }


        }
    }
    
    
}
