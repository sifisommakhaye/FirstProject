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
            string[] allowedOper = new string[4] { "+", "-", "*", "/" };
            string type;
            int num1;
            int num2;
            int answer;
            string restartCheck;

            // get the operator type
            Console.WriteLine("What type of calculation do you want to perform? (+, -, *, /)");
            type = GetCalcType(allowedOper);


            Console.WriteLine("Write the first number.");
            num1 = GetCalcNum();

            Console.WriteLine("Write the second number");
            num2 = GetCalcNum();

            answer = Calculate(num1, num2, type);

            Console.WriteLine("The answer is" + answer + " \r\n Write 'yes' to restart application");

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

        private string GetCalcType(string[] allowedOper)
        {
            string type = Console.ReadLine();

            while (!allowedOper.Contains(type))
            {
                Console.WriteLine("Choose a valid operator type!");
                type = Console.ReadLine();
            }

            return type;
        }
        private int GetCalcNum()
        {
            int num;

            bool parseCheck = Int32.TryParse(Console.ReadLine(), out num);

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
