using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string star = "*";
            // string space = " ";
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= i;j++)
                {
                    Console.Write(star);
                }
            }
        }
    }
}