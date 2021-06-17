using System;

namespace IsItALeapYear
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool IsItALeapYear(int Y)
        {
            if (((Y % 4 == 0) && (Y % 100 != 0))|| (Y % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
