using System;
using System.Threading;

namespace _1303_ClientServer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Assignment1 a = new Assignment1();
            a.Run();


            //Console.WriteLine("Hello World!");
            //var assignment1 = new Assignment1();
            //assignment1.Run();

            //TestThreads();

            //Console.WriteLine();
            //Console.WriteLine("hit enter key to terminate");
            //Console.ReadLine();
        }

        /*
        public static void TestThreads()
        {
            Thread t1 = new Thread(MyFunction);
            t1.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write('m');
            }
        }

        private static void MyFunction()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("f");
            }
        }
        */
    }
}
