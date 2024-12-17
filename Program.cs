using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 24;
            if (a % 4 == 0 || a % 5 == 0)
            {
                Console.WriteLine("bolunur");

            }
            else { Console.WriteLine("bolunmur"); }
        }

    }
}