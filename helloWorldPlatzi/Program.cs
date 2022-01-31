using System;
using System.Collections.Generic;
using System.Globalization;

namespace helloWorldPlatzi
{
    class Program
    {
        static void Main(string[] args)
        {
           //metodos
           float[] pricesArray;
           pricesArray = new float[10];
           pricesArray[0] = 1.5f;
           pricesArray[1] = 2.5f;
           pricesArray[2] = 3f;
           pricesArray[3] = 5f;

           Random rnd = new Random();
           
           Console.WriteLine("Hello world, of random numbers");
           Console.WriteLine($"{rnd.Next(1,10)}");
        }
    }
}