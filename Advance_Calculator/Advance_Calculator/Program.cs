using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string option, area_option, basic_option = "";
            double firstNumber, secondNumber, ans = 0;
            double pie = Math.PI;

            Console.WriteLine("Hello this is a advanced calculator please enter "+ "\n" +
                "(a) for calculating the area of a shape or (b) for basic mathematic calculations");

            option = (Console.ReadLine()).ToLower();

            if (option == "a" || option == "b")
            {
                if (option == "a")
                {
                    Console.WriteLine("Do you want to want to calculate the area of a " +
                        "(s)quare/rectangle, (c)ircle or (t)riangle ");
                    area_option = Console.ReadLine();
                    switch (area_option.ToLower()) {
                        case "s":
                            Console.WriteLine("Please enter height");
                            firstNumber = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter width");
                            secondNumber = Convert.ToDouble(Console.ReadLine());
                            ans = firstNumber * secondNumber;
                            Console.WriteLine("The area of your shape is: "+ ans);
                            Console.Read();
                            break;
                        case "c":
                            Console.WriteLine("Please enter the radius of the circle");
                            firstNumber = Convert.ToDouble(Console.ReadLine());
                            ans = pie*(firstNumber * firstNumber);
                            Console.WriteLine("The area of your shape is: " + ans);
                            Console.Read();
                            break;
                        case "t":
                            Console.WriteLine("Please enter height");
                            firstNumber = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter width");
                            secondNumber = Convert.ToDouble(Console.ReadLine());
                            ans = (firstNumber * secondNumber) / 2;
                            Console.WriteLine("The area of your shape is: " + ans);
                            Console.Read();
                            break;
                        default:
                            Console.WriteLine("Enter a valid input");
                            Console.Read();
                            break;
                    }
                        

                }else
                {
                    Console.WriteLine("Please select an operator (+,-,/,*)");
                        basic_option = Console.ReadLine();
                        switch (basic_option)
                    {
                        case "+":
                            Console.WriteLine("Please enter first number");
                            firstNumber = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter second number");
                            secondNumber = Convert.ToDouble(Console.ReadLine());
                            ans = firstNumber + secondNumber;
                            Console.WriteLine(firstNumber + " + " + secondNumber + " = " + ans);
                            Console.Read();
                            break;

                        case "-":
                            Console.WriteLine("Please enter first number");
                            firstNumber = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter second number");
                            secondNumber = Convert.ToDouble(Console.ReadLine());
                            ans = firstNumber - secondNumber;
                            Console.WriteLine(firstNumber + " - " + secondNumber + " = " + ans);
                            Console.Read();
                            break;

                        case "/":
                            Console.WriteLine("Please enter first number");
                            firstNumber = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter second number");
                            secondNumber = Convert.ToDouble(Console.ReadLine());
                            ans = firstNumber / secondNumber;
                            Console.WriteLine(firstNumber + " / " + secondNumber + " = " + ans);
                            Console.Read();
                            break;

                        case "*":
                            Console.WriteLine("Please enter first number");
                            firstNumber = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter second number");
                            secondNumber = Convert.ToDouble(Console.ReadLine());
                            ans = firstNumber * secondNumber;
                            Console.WriteLine(firstNumber + " * " + secondNumber + " = " + ans);
                            Console.Read();
                            break;

                        default:
                            Console.WriteLine("Enter a valid input");
                            Console.Read();
                            break;

                    }
                            
                }

            }
            else
            {
                Console.WriteLine("You have selected an invalid input");
                Console.Read();
            }

        }
    }
}
