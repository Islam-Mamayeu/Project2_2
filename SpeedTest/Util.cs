using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTest
{
     class Util
    {
       public static ArrayList list = new ArrayList();
       public static LinkedList<int> linkedList = new LinkedList<int>();



        static public void Add()
        {
            for (int i = 0; i < 1000000; i++)
            {
                list.Add(i);
                linkedList.AddLast(i);

            }

        }


        static public void AddLast(int countofElements)
        {
            Console.WriteLine("Adding to end...\n");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i=0;i<countofElements;i++)
            {
                list.Add(i);

            }
            Console.WriteLine("ArrayList:" + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds);
            stopwatch.Restart();

            for (int i=0;i<countofElements;i++)
            {
                linkedList.AddLast(i);
            }

            Console.WriteLine("LinkedList:" + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds);


        }


    

        static public void AddMiddle()
        {
            Console.WriteLine("Adding to middle...\n");

            int listCapacity = list.Count / 2;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int i = 0;
            for (i = 0; i < 10000; i++)
            {
                list.Insert(listCapacity, i);
            }

            Console.WriteLine("ArrayList:" + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds);

            


            stopwatch.Restart();

            for(int k = 0; k<10000;k++)
            {
                var curNode = linkedList.First;

                for (i = 0; i < listCapacity; i++)
                {
                    curNode = curNode.Next;
                }

                linkedList.AddAfter(curNode, i);
            }
            Console.WriteLine("LinkedList:" + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds);
            Console.WriteLine();
        
        }

        static public void AddTop()
        {
            Console.WriteLine("Adding to top...\n");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int i = 0;
            for (i = 0; i < 1000; i++)
            {
                list.Insert(0, i);
            }

            Console.WriteLine("ArrayList:" + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds);

            stopwatch.Restart();

            for (i = 0; i < 1000; i++)
            {
                linkedList.AddFirst(i);

            }
            Console.WriteLine("LinkedList:" + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds);



        }

        static public void DeleteFirst()
        {
            Stopwatch stopwatch = new Stopwatch();
            ArrayList listforRemove = list;
            LinkedList<int> linkedListforRemove = linkedList;

            stopwatch.Start();

            int i = 0;
            for (i = 0; i < 1000; i++)
            {
                list.Remove(0);
            }

            Console.WriteLine("ArrayList:" + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds);

            stopwatch.Restart();


            for (i = 0; i < 1000; i++)
            {
                linkedList.RemoveFirst();

            }
            Console.WriteLine("LinkedList:" + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds);


        }
        static public void DeleteMiddle()
        {
            ArrayList listforRemove = list;
            LinkedList<int> linkedListforRemove = linkedList;
            int i = 0;

            int listCapacity = list.Count / 2;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();


            for (i = 0; i < 1000; i++)
            {
                listforRemove.Remove(listCapacity + i);
            }
            Console.WriteLine("ArrayList:" + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds);

            stopwatch.Restart();

            for (int k = 0; k < 1000; k++)
            {
                var curNode = linkedList.First;

                for (i = 0; i < listCapacity; i++)
                {
                    curNode = curNode.Next;
                }

                linkedListforRemove.Remove(curNode);
            }
            Console.WriteLine("LinkedList:" + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds);
            Console.WriteLine();

        }
        static public void DeleteLast()
        {
            ArrayList listforRemove = list;
            LinkedList<int> linkedListforRemove = linkedList;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i <1000; i++)
            {
                listforRemove.Remove(listforRemove.Count-1);

            }
            Console.WriteLine("ArrayList:" + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds);
            stopwatch.Restart();


            for (int i = 0; i < 1000; i++)
            {
                linkedListforRemove.RemoveLast();
            }

            Console.WriteLine("LinkedList:" + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds);


        }

        static public void Search()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();



            for (int i=0;i<10000;i++)
            {
                list.IndexOf(87535);


            }
            Console.WriteLine("ArrayList:" + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds);

            stopwatch.Restart();

            for (int i = 0; i < 10000; i++)
            {
                linkedList.Find(87535);

                

            }
            Console.WriteLine("LinkedList:" + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds);










        }
    }
}
