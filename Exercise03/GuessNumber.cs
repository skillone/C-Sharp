using System;
namespace Exercise03
{
    public class GuessNumber
    {
        public void Guessnumber(int guessedNumber)
        {
            int correctNumber = new Random().Next(3) + 1;

            if (guessedNumber > 3)
            {
                Console.WriteLine("Your guessed number is out of range");
            }
            else if (guessedNumber < 1)
            {
                Console.WriteLine("Your guessed number is out of range");
            }
            else if (guessedNumber < correctNumber)
            {
                Console.WriteLine("Your guessed number is lower");
            }
            else
            {
                Console.WriteLine($"You guessed the correct number.");
            }
        }
    }
}

