using System;

namespace _02UnderstandingTypes
{

    public class convertCenturies
    {
        public void convert_centuries(int century)
        {
            int years = century * 100;
            int days = years * 365 + years / 4 - 1;
            int hours = days * 24;
            ulong minutes = (ulong)hours * 60;
            ulong seconds = minutes * 60;
            ulong millseconds = seconds * 1000;
            ulong nanoseconds = millseconds * 1000;


            Console.WriteLine($"{century} centuries = {years} years" +
                $" = {days} days = {hours} hours" +
                $" = {minutes} minutes" +
                $" = {seconds} seconds" +
                $" = {millseconds} millseconds" +
                $" = {nanoseconds} nanoseconds");
        }
    }

}