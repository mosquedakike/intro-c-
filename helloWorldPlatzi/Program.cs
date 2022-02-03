using System;
using static System.Console;

namespace helloWorldPlatzi
{
    class Program
    {
        static void Main(string[] args)
        {
            int anyValue = 1;
            string message = "";

            if (anyValue == 7)
            {
                message = "OMG, it's a miracle any value is 7";
            }
            else if (anyValue == 1)
            {
                message = "the value is 1";
            }
            else
            {
                message = "puff, the value wasn't 7 ";
            }
            WriteLine($"The answer is: {message}");
        }
    }
}