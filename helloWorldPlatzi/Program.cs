using System;
using static System.Console;

namespace helloWorldPlatzi
{
    class Program
    {
        private void IntegerAddition(int a, int b)
        {
            int Addition = a + b;
            WriteLine($"El resultado es {Addition}");
        }

        public int IntegerMultiplication(int a, int b)
        {
            int Multiplication = a * b;
            return Multiplication;
        }

        public float FloatDivision(float a, float b)
        {
            float Division = a / b;
            return Division;
        }
        
        static void Main(string[] args)
        {
            WriteLine("Hello world!");
            
            Program MyProgram = new Program();
            MyProgram.IntegerAddition(3,6);

            int result = MyProgram.IntegerMultiplication(12, 2);
            WriteLine($"El resultado de la multiplicacion es: {result}");

            float resultDivision = MyProgram.FloatDivision(6.5f, 2);
            WriteLine($"El resultado de la division es: {resultDivision}");
        }
    }
}