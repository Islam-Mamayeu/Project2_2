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
        static public void Add()
        {
            ArrayList list = new ArrayList();
            LinkedList<int> linkedList = new LinkedList<int>();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i=0;i<1000000;i++)
            {
                list.Add(i);
            }
            Console.WriteLine("List:" + stopwatch.Elapsed.Seconds+ ":" + stopwatch.Elapsed.Milliseconds);

            stopwatch.Restart();
            for(int i=0;i<1000000;i++)
            {
                linkedList.AddLast(i);
            }

            Console.WriteLine("List:" + stopwatch.Elapsed.Seconds + ":" + stopwatch.Elapsed.Milliseconds);

        }
        static public void Delete()
        {
            ArrayList list = new ArrayList();
        }
        static public void Search()
        {
            ArrayList list = new ArrayList();
        }

        

    }
}
