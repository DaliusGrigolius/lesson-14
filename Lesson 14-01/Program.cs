using Services;
using System;

namespace Lesson_14_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ivesk zmogaus numeri:");
                int personId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ivesk vartu numeri:");
                int gateId = Convert.ToInt32(Console.ReadLine());

                AllEntries allEntries = new AllEntries();
                bool result = allEntries.Check(personId, gateId);
                Console.WriteLine(result);

            }
        }
    }
}
