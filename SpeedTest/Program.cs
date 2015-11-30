using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            bool b = true;

            while (b)
            {
                Util.Add();
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Delete");
                Console.WriteLine("3.Search");
                Console.WriteLine("4.exit\n");
                choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Adding:\n");
                        Util.AddLast(100000);
                        Util.AddMiddle();
                        Util.AddTop();

                        break;
                    case "2":
                        Console.WriteLine("Remove:\n");
                        Console.WriteLine("Delete First:\n");
                        Util.DeleteFirst();
                        Console.WriteLine("Delete Middle:\n");
                        Util.DeleteMiddle();
                        Console.WriteLine("Delete Last:\n");
                        Util.DeleteLast();


                        break;
                    case "3":

                        Console.WriteLine("Search:\n");
                        Util.Search();
                        break;
                    case "4":
                        b = false;
                        break;

                    default:
                        break;

                }
            }



        }
    }
}
