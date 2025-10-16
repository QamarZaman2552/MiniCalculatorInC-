// See https://aka.ms/new-console-template for more information
namespace MiniCalculatorInC_
{
    class Program
    {
        public static void addition(int nuber1, int number2)
        {
            int result = nuber1 + number2;
            Console.WriteLine("Addtion of two numbers is: = {0}", result);
        }
        public static void subtraction(int nuber1, int number2)
        {
            int result = nuber1 - number2;
            Console.WriteLine("Subtraction of two numbers is: = {0}", result);
        }
        public static void Multiplication(int nuber1, int number2)
        {
            int result = nuber1 * number2;
            Console.WriteLine("Multiplication of two numbers is: ={} ", result);
        }
        public static void divide(int nuber1, int number2)
        {
            int result = nuber1 + number2;
            Console.WriteLine("Divisions of two numbers is: ={} ", result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator like(- , + , * , /) : ");
            string op = Console.ReadLine();

            if (op.Equals("+"))
            {
                Program.addition(num1, num2);
            }
            else if (op.Equals("-"))
            {
                Program.subtraction(num1, num2);
            }
            else if (op.Equals("*"))
            {
                Program.Multiplication(num1, num2);
            }
            else if (op.Equals("/"))
            {
                Program.divide(num1, num2);
            }
            else
            {
                Console.WriteLine("Invalid Oprator");
            }
        }


    }
}
