using System;


namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            long tick;
            Console.WriteLine("Enter the date in DD:MM:YY:HH:MM:SS format\n");
            string date = Console.ReadLine();
            string[] s = date.Split(":");
            int day, month, year, hour, min, sec;
            int days_in_feb;
            int.TryParse(s[0], out day);
            int.TryParse(s[1], out month);
            int.TryParse(s[2], out year);
            int.TryParse(s[3], out hour);
            int.TryParse(s[4], out min);
            int.TryParse(s[5], out sec);
            Console.WriteLine("Enter the no of ticks ranging from 10000000 to 999999999999\n");
            string t = Console.ReadLine();
            long.TryParse(t, out tick);
            double second = tick * Math.Pow(10, -7);
            Console.WriteLine("Ticks in seconds:\n" + second);
            sec += (int)second;
            while (sec >= 60)
            {
                int temp = sec / 60;
                sec = sec % 60;
                min += temp;
            }
            while (min >= 60)
            {
                int temp = min / 60;
                min = min % 60;
                hour += temp;
            }
            while (hour >= 24)
            {
                int temp = hour / 24;
                hour = hour % 24;
                day += temp;
            }
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                days_in_feb = 29;
            }
            else
            {
                days_in_feb = 28;
            }
            int[] no_of_days = { 31,days_in_feb, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day > no_of_days[month - 1])
            {
                day -= no_of_days[month - 1];
                month += 1;


            }
            if (month > 12)
            {
                month = 1;
                year += 1;
            }

            Console.WriteLine("the result date is {0}:{1}:{2}:{3}:{4}:{5}", day, month, year, hour, min, sec);
        }
    }
}
