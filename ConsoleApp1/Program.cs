using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int num1;
            int num2;
            string answer;

            int result;


            Console.WriteLine("hi , this is calculator program without GUI");

            Console.WriteLine("enter first Num: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second Num: ");
            num2 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("choose what operatoin do you want to use ? ");
            Console.WriteLine("please enter + for Addition , - for Subtraction , * for Multiplication or any other  key for Division .  ");



            answer = Console.ReadLine();


            if (answer == "+")
            {
                result = num1 + num2;
            }
            else if (answer == "-")
            {
                result = num1 - num2;
            }

            else if (answer == "*")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }


            Console.WriteLine("result =  " + result);

            Console.ReadKey();


        }
    }
}

