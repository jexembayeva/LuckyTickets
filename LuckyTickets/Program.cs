using LuckyTicketsBase;
using System;

namespace LuckyTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\algorithms\A01_Lucky_Tickets\1.Tickets\";

            Console.WriteLine("-------------------BruteForce------------------------");
            ITask bruteForceTask = new LuckyTicketsBruteForceTask();

            Tester bruteForceTester = new Tester(bruteForceTask, path);
            bruteForceTester.RunTests();

            Console.WriteLine("-------------------Dynamic------------------------");
            ITask dynamicTask = new LuckyTicketsDynamicTask();

            Tester dynamicTester = new Tester(dynamicTask, path);
            dynamicTester.RunTests();

            Console.WriteLine("-------------------Recursion------------------------");
            ITask recursionTask = new LuckyTicketsRecursionTask();

            Tester recursionTester = new Tester(recursionTask, path);
            recursionTester.RunTests();

            Console.ReadKey();
        }
    }
}
