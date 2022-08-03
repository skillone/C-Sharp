using System;
namespace Exercise03
{
    public class PrintAPyramid
    {
        public void print_a_pyramid(int level)
        {
            for (int i = 0; i < level; i++)
            {
                for (int j = 0; j < level - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }
    }
}

