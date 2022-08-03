using System;
namespace Exercise03
{
    public class Greetings
    {
        public void greetings()
        {
            int now = (int)DateTime.Now.Hour;
            if (12 > now && now >= 6)
            {
                Console.WriteLine("Good Morning!");
            }
            else if (18 > now && now >= 12)
            {
                Console.WriteLine("Good Afternoon!");
            }
            else if (24 > now && now >= 18)
            {
                Console.WriteLine("Good Evening!");
            }
            else
            {
                Console.WriteLine("Good Night!");
            }
        }
    }
}

