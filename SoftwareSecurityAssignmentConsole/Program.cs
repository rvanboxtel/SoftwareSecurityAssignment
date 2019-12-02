using System;

namespace SoftwareSecurityAssignmentConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
            Console.WriteLine("hello there");
        }
    }
}
