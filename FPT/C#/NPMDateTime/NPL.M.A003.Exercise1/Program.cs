using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using static System.Console;

/*
 * Write the console application to make the request as follows:
Input: Allows users to enter 1 day in the format: date / month / year.
Output: Print all dates that will send a reminder notice:
Example: Enter date is 08/01/2019, Print out the day:
1
st reminder: 15/01/2019
2
nd reminder: 17/01/2019
3
rd reminder: 18/01/2019
4
th reminder: 19/01/2019
5
th reminder: 20/01/2019
 */
namespace NPL.M.A003.Exercise1
{
    class Program
    {
        static DateTime RemoveNotWorkingDays(DateTime startDate)
        {
            switch (startDate.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                    return startDate.AddDays(2);
                case DayOfWeek.Sunday:
                    return startDate.AddDays(1);
            }
            return startDate;
        }

        static DateTime Reminder(ref DateTime startDay, int day)
        {
            for (int i = 1; i <= day; i++)
            {
                startDay = RemoveNotWorkingDays(startDay.AddDays(1));
            }
            return startDay;
        }
        static void Main(string[] args)
        {

            bool isValidDate = false; 
            DateTime startDate;

            do     
            {

                Console.Write("Enter date (dd/MM/yyyy):");
                isValidDate = DateTime.TryParseExact(ReadLine(),
                                    "dd/MM/yyyy", CultureInfo.InvariantCulture,
                                    DateTimeStyles.AllowWhiteSpaces, out startDate);
                if (!isValidDate)
                    Console.WriteLine("Your input date is invalid format date");

            } while (!isValidDate);

            Console.WriteLine($"1st reminder: {Reminder(ref startDate, 7).ToString("dd/MM/yyyy")}");
            Console.WriteLine($"2nd reminder: {Reminder(ref startDate, 2).ToString("dd/MM/yyyy")}");
            Console.WriteLine($"3rd reminder: {Reminder(ref startDate, 1).ToString("dd/MM/yyyy")}");
            Console.WriteLine($"4th reminder: {Reminder(ref startDate, 1).ToString("dd/MM/yyyy")}");
            Console.WriteLine($"5th reminder: {Reminder(ref startDate, 1).ToString("dd/MM/yyyy")}");
            Console.ReadKey();


        }
       

    }
}
