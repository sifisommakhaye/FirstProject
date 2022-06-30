using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstProject.Calc
{
    public class Calculator
    {
        public void RunCalculation()
        {
            // declare variables
            string[] allowedOperator = new string[4] { "+", "-", "*", "/" };
            string type;
            int num1;
            int num2;
            int answer;
            string restartCheck;

            // get the operator type + - * /
            Console.WriteLine("What type of calculation do you want to perform? (+, -, *, /)");
            type = GetCalcType(allowedOperator);

            // get the first number
            Console.WriteLine("Write the first number.");
            num1 = GetCalcNum();

            // get the second number
            Console.WriteLine("Write the second number");
            num2 = GetCalcNum();

            // caculate two numbers using an operator
            answer = Calculate(num1, num2, type);

            // the answer will be...
            Console.WriteLine("The answer is " + answer + " \r\n Write 'yes' to restart application");

            // Check if the user wants to restart the application
            restartCheck = Console.ReadLine();
            if (restartCheck == "yes")
            {
                RunCalculation();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        // get a valid type and return it to the above method
        private string GetCalcType(string[] allowedOperator)
        {
            string type = Console.ReadLine();

            while (!allowedOperator.Contains(type))
            {
                Console.WriteLine("Choose a valid operator type!");
                type = Console.ReadLine();
            }

            return type;
        }
        private int GetCalcNum()
        {
            int num;
            // Checking if the parse is successful
            // Returns as a boolean
           bool parseCheck = Int32.TryParse(Console.ReadLine(), out num);

            // while boolean is false it keep looping the input
            while (!parseCheck)
            {
                Console.WriteLine("Try again! This time with actual numbers...");

                parseCheck = Int32.TryParse(Console.ReadLine(), out num);
            }
            return num;
        }

        public int Calculate(int num1, int num2, string type)
        {
            int result;

            // Check operator type
            if (type == "+")
            {
                result = num1 + num2;
                return result;
            }
            else if (type == "-")
            {
                result = num1 - num2;
                return result;
            }
            else if (type == "*")
            {
                result = num1 * num2;
                return result;
            }
            else
            {
                result = num1 / num2;
                return result;
            }
        }
    }   
}
