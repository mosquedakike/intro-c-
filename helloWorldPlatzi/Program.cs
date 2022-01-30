using System;
using System.Globalization;

namespace helloWorldPlatzi
{
    class Program
    {
        static void Main(string[] args)
        {
            //strings
            // Console.WriteLine("What's your name? Please write your full name");
            // string fullUserName = Console.ReadLine();
            // Console.WriteLine($"hello {fullUserName} welcome to Platzi");
            
            //NumericCalculator
            // int number1;
            // int number2;
            //
            // Console.WriteLine("Input the first number");
            // number1 = Convert.ToInt32(Console.ReadLine());
            //
            // Console.WriteLine("Input the second number");
            // number2 = Convert.ToInt32(Console.ReadLine());
            //
            // int result = number1 * number2;
            // Console.WriteLine($"The result is: {result}");
            
            //Manejo de strings
            // int height = 170;
            // int age = 27;
            // string name = "Enrique Hernandez";
            // string placeHolderText = "The information you requested is:";
            // string information = $"{placeHolderText} \n user name:{name} \n user age:{age} \n user height:{height}";
            // Console.WriteLine(information);
            
            //Trabajando con numeros y oreperadores aritmeticos
            // float sideA = 10.0f;
            // int sideB = 1;
            // sideB++;
            // sideB++;
            //
            // //rectagle area formula is a*b
            // float area = sideA * sideB;
            //
            // Console.WriteLine($"The reactangle area is: {area}");

            // bool value1 = true;
            // bool value2 = false;

            //&& || !
            // bool result = value1 && value2;
            // Console.WriteLine("The result of the logical AND is: " + result);

            // int value1 = 3;
            // int value2 = 18;
            // int value3 = -18;
            //
            // == igual a 
            // != no igual a
            // > mayor que 
            // < menor que
            // >= mayor o igual que
            // <= menor o igual que 
            
            Console.WriteLine("please enter the side a of the rectangle, you can use decimals");
            float sideA = float.Parse(Console.ReadLine() ?? string.Empty);
            
            Console.WriteLine("please enter the side b of the rectangle, you can use decimals");
            float sideB = float.Parse(Console.ReadLine() ?? string.Empty);
            
            //rectangle area formula is a*b
            float area = sideA * sideB;
            
            Console.WriteLine("The rectangle area is: " + area);
        }
    }
}