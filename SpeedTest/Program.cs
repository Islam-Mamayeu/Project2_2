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
            bool isInt;
            bool b = true;

            while (b)
            {

                Console.WriteLine("1.Add");
                Console.WriteLine("2.Delete");
                Console.WriteLine("3.Search");
                Console.WriteLine("4.exit\n");
                choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        Util.Add();
                        break;
                    case "2":
                        Util.Delete();
                        break;
                    case "3":
                        Util.Delete();
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
