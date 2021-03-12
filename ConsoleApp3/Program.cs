using System;

namespace ConsoleApp3
{
    public class Program
    {
        public static int Calculate(string expression)
        {
            string[] stringArray = expression.Split(" ");
            Int32.TryParse(stringArray[1], out int number1);
            Int32.TryParse(stringArray[2], out int number2);
            if(stringArray[0] == "/")
            {
                return number1 / number2;
            }
            else if(stringArray[0] == "*")
            {
                return number1 * number2;
            }
            else if(stringArray[0] == "-")
            {
                return number1 - number2;
            }
            else
            {
                return number1 + number2;
            }
        }
        static void Main(string[] args)
        {
         
            Console.WriteLine(Calculate("/ 20 -5"));
        }
    }
}
