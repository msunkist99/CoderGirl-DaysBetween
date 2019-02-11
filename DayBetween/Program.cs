using System;

namespace DaysBetween
{
    public static class Program
    {
        public static void Main()
        {
            // TODO:  Get two dates from the user.
            Console.WriteLine("enter your first date as mm/dd/yyyy");
            DateTime firstDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("enter your second date as mm/dd/yyyy");
            DateTime secondDate = Convert.ToDateTime(Console.ReadLine());

            int daysDiff = DaysBetween(firstDate, secondDate);

            Console.WriteLine(daysDiff);

            Console.ReadLine();
        }

        // TODO: Create that has a method that counts the number of days between two different dates.
        /// <summary>
        /// returns absolute value number of days between two dates mm/dd/yyyy
        /// </summary>
        /// <param name="firstDate"></param>
        /// <param name="secondDate"></param>
        /// <returns>absolute value number of days between two dates mm/dd/yyyy</returns>
        public static int DaysBetween(DateTime firstDate, DateTime secondDate)
        {
            int daysDiff = 0; 

            if (firstDate < secondDate)
            {
                daysDiff = (secondDate - firstDate).Days;
            }
            else
            {
                daysDiff = (firstDate - secondDate).Days;
            }

            return daysDiff;
        }
    }
}
