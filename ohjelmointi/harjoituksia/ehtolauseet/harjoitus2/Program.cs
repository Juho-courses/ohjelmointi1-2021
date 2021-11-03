using System;

namespace harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = false;
            int temp = 31;

            if (temp > 30)
            {
                isRunning = true;
            }

            if (isRunning == true)
            {
                Console.WriteLine("motor is running");
            }
            else
            {
                Console.WriteLine("motor not running");
            }
        }
    }
}
