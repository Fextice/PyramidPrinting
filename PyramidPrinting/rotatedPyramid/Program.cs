using System;

namespace rotatedPyramid
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string star = "*";
            string space = " ";
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine();
                for (int j = num; j > i; j--)
                {
                    Console.Write(space);
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write(star);
                }
            }
        }
    }
}