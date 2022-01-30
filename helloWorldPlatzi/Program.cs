using System;
using System.Globalization;

namespace helloWorldPlatzi
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays
            //se definen los arreglos
            string[] coffeTypes;
            float[] coffePrices;

            //se inicializan los arreglos
            coffeTypes = new string[]
            {
                "Expresso",
                "Largo",
                "Filrado",
                "Latte"
            };
            
            coffePrices = new float[] {1.2f, 1.5f, 5.0f, 5.5f};

            coffeTypes[1] = "Big";
            for (int i = 0; i < coffeTypes.Length; i++)
            {
                Console.WriteLine(coffeTypes[i] + " Coffe $" + coffePrices[i]);
            }
        }
    }
}