using System;
namespace Exercise03
{
    public class CalculateAge
    {
        public int calculate_age(DateTime birthdate)
        {
            var today = DateTime.Today;
            TimeSpan span = today.Subtract(birthdate);
            Console.WriteLine($"{(int)span.TotalDays}");
            return (int)span.TotalDays;
        }
    }
}

