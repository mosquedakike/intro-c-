using System;
using System.Collections.Generic;
using System.Globalization;

namespace helloWorldPlatzi
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando e inicializando la lista
            List<string> tacoShoppingList = new List<string>();
            tacoShoppingList.Add("Cinco tacos de suadero");
            tacoShoppingList.Add("Cuatro tacos de tripa");
            tacoShoppingList.Add("Cinco tacos de pastor");
            tacoShoppingList.Add("Cuatro coca colas");

            for (int i = 0; i < tacoShoppingList.Count; i++)
            {
                Console.WriteLine(tacoShoppingList[i]);
            }
            
            Console.WriteLine("----------------Remove-----------------------");

            tacoShoppingList.Remove("Cinco tacos de suadero");
            //tacoShoppingList.RemoveAt(0);
            
            for (int i = 0; i < tacoShoppingList.Count; i++)
            {
                Console.WriteLine(tacoShoppingList[i]);
            }
        }
    }
}