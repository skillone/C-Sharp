using System;
namespace Exercise03
{
    public class Count24
    {
        public void count_24()
        {
            for (int i = 1; i <= 4; i ++)
            {
                for (int j = 0; j <= 24; j += i)
                {
                    if (j % i == 0)
                    {
                        if (j != 24)
                        {
                            Console.Write($"{j}, ");
                        }
                        else
                        {
                            Console.Write($"{j}");
                        }
                    }   
                }
                Console.WriteLine("\n");
            }
        }
    }
}

