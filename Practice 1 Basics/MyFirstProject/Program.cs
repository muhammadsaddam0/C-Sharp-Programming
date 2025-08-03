using System;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //""""PRACTICE QUESTION 1"""" 

            //*Create & initalise two ints
            //*Make a variable to work out the remainder
            //*Output remainder to the screen
            //*Change the first int variable to another number
            //* and recalculate the remainder
            //* output new remainder to the screen

            /*
            var name = "Saddam";
            var number = "03123456789";
            var age = 23;

            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(age);
            */

            //""""PRACTICE QUESTION 2""""

            //*Create & initalise two ints
            //*Make a variable to work out the remainder
            //*Output remainder to the screen
            //    *Change the first int variable to another number
            //    * and recalculate the remainder
            //    * output new remainder to the screen

            /*
                int num1 = 21;
                int num2 = 2;

                var remainder = num1 % num2;
                Console.WriteLine(remainder);

                num1 = 20;
                remainder = num1 % num2;
                Console.WriteLine(remainder);
            */

            //""""PRACTICE QUESTION 3""""

            //getting input from user and print

            /* Console.Write("Enter your name : ");
             string name = Console.ReadLine();

             Console.Write("Enter your age : ");
             string ageInput = Console.ReadLine(); // Since readline only returns string and we want to store int value,
             int age = Convert.ToInt32(ageInput); // so we have to convert string datatype to int by convert.int32(variable name of string)

             Console.WriteLine();// Console.WriteLine(); gap of 1 line

             Console.WriteLine("Your name is " + name);// Console.WriteLine(); print in same line
             Console.WriteLine("Your age is " + age);

             Console.WriteLine();

             Console.Write("Your name is " + name + " and your age is " + age); // Console.Write(); print in same line
             Console.WriteLine();
            */


            //""""PRACTICE QUESTION 4""""

            //if else statements 

            /*  Console.Write("Enter first number: ");
              string numberAinput = Console.ReadLine();
              int numberA = Convert.ToInt32(numberAinput);

              Console.Write("Enter Second number: ");
              string numberBinput = Console.ReadLine();
              int numberB = Convert.ToInt32(numberBinput);

              int answer = (numberA * numberB);

              Console.WriteLine();
              Console.Write("value of " + numberA + " x " + numberB + ": ");
              string answerInput = Console.ReadLine();
              int finalanswer = Convert.ToInt32(answerInput);

              if (finalanswer == answer)
              {
                  Console.WriteLine("correct answer");
              }
              else
              {
                  Console.WriteLine();
                  Console.WriteLine("not correct, the correct answer is: " + answer);

              }
              */

            //""""PRACTICE QUESTION 5""""

            // printing day name on input of day number by switch and if else

            /* 
             Console.Write("Enter the day of the week: ");
             string dayInput = Console.ReadLine();
             int day = Convert.ToInt32(dayInput);
            
            // By switch case

             switch (day)
             {
                 case 1:
                     Console.WriteLine("Mon");
                     break;
                 case 2:
                     Console.WriteLine("Tue");
                     break;
                 case 3:
                     Console.WriteLine("Wed");
                     break;
                 case 4:
                     Console.WriteLine("Thu");
                     break;
                 case 5:
                     Console.WriteLine("Fri");
                     break;
                 case 6:
                     Console.WriteLine("Sat");
                     break;
                 case 7:
                     Console.WriteLine("Sun");
                     break;

                 default:
                     Console.WriteLine("Invalid, enter a value between 1 and 7");
                     break;
             }


            // By if else Statements

             if (day == 1)
             {
                 Console.WriteLine("monday");
             }
             else if (day == 2)
             {
                 Console.WriteLine("Tuesday");
             }
             else if (day == 3)
             {
                 Console.WriteLine("Wednesday");
             }
             else if (day == 4)
             {
                 Console.WriteLine("Thursday");
             }
             else if (day == 5)
             {
                 Console.WriteLine("Friday");
             }
             else if (day == 6)
             {
                 Console.WriteLine("Saturday");
             }
             else if (day == 7)
             {
                 Console.WriteLine("Sunday");
             }
             else
             {
                 Console.WriteLine("Invalid, enter a value between 1 and 7");
             }
            */

            //"""" PRACTICE QUESTION 6 ( For loop practice ) """"

            // For loop practice

            /*    Console.Write("Enter your message: ");
                string message = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter how many times you want to repeat your message: ");
                int loopCounter = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();


                if (loopCounter <= 0)
                {
                    Console.WriteLine("Enter number greater than 0 ");
                }
                else {
                    for (int i = 0; i < loopCounter; i++)
                    {

                        Console.WriteLine(message);
                    }
                }

                */


            //""""EXERCISE QUESTION 1""""

            //*Ask the user for a number for the table
            //*Write a for loop to print X times table

            /* Console.Write("Enter number of table : ");
            int table = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(table + " x " + i + " = " + i * table);
                //OR 
                Console.WriteLine("{0} x {1} = {2}", table, i, i * table);
                //OR              
                Console.WriteLine($" {table} * {i} = {i * table}");

            }
            */

            //""""PRACTICE QUESTION 7   (EMPTY STRING) """"

            /*
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                if (name != string.Empty) //OR      if (name != "") do not show empty string
                {
                    Console.WriteLine($"Your name is {name}");
                }
                else
                {
                    Console.WriteLine("Name is empty");
                }
            */


            //""""PRACTICE QUESTION 8   (STRING ITERATION LOOPING) """"

            /*
            string message = "C# is awesome";

            for (int i = 0; i < message.Length; i++)
                {
                    Console.Write(message[i]);  
                    Thread.Sleep(100);
                }
                Console.WriteLine();

                //Console.WriteLine(message.Contains("C"));

                bool contains = false;

                for (int i = 0; i < message.Length; i++)
                {
                    if (message[i].Equals('C'))
                    {
                        contains = true;
                    }
                }
                Console.WriteLine(contains);
            */


            // FINDING CHARACTER IN STRING

            /*
                Console.Write("Enter your message : ");
                string message = Console.ReadLine();

                Console.Write("Find Character in your message : ");
                string messagefind = Console.ReadLine();

                if (messagefind.Length != 1)
                {
                    Console.WriteLine("Enter only single character");
                }
                else
                {
                    if (message.Contains(messagefind))
                    {
                        Console.WriteLine("Character is found");

                    }
                    else
                    {
                        Console.WriteLine("Character not found");
                    }
                }
            */


            // Advanced version of finding character in string
            /*
                Console.Write("Enter your message : ");
                string message = Console.ReadLine();

                string messagefind;

                while (true)
                {
                    Console.Write("Find Character in your message : ");
                    messagefind = Console.ReadLine();

                    if (messagefind.Length != 1)
                    {
                        Console.WriteLine("Enter only a single character");
                        continue;
                    }

                    // Check if it’s a digit (if you want to disallow digits)
                    if (char.IsDigit(messagefind[0]))
                    {
                        Console.WriteLine("Please enter a character, not a number");
                        continue;
                    }

                    break; // valid input
                }

                // Now check if the character exists in the message
                if (message.Contains(messagefind))
                {
                    Console.WriteLine("Character is found");
                }
                else
                {
                    Console.WriteLine("Character not found");
                }
            */


            //""""EXERCISE QUESTION   (STRING REVERSE) """"


            //*Ask user to input message
            //*Print in order
            //* Print in reverse order

            /*
              Console.Write("Enter Your Message : ");
              string message = Console.ReadLine();

              Console.WriteLine( $"the message length is : {message.Length}" );

              Console.Write("The message in Order is : "); 
              for (int i = 0; i < message.Length; i++)
              {

                  Console.Write(message[i]);
              }

              Console.WriteLine();
              Console.Write("The message in Reverse Order is : ");

              for (int j = message.Length-1 ; j >= 0; j--)
              {
                  Console.Write(message[j]);
              }
            */

            //""""EXERCISE QUESTION   (PASSWORD CHECKER) """"

            /*

              Console.Write("Enter a Password : ");
              string password = Console.ReadLine();

              Console.Write("Confirm Password : ");
              string cpassword = Console.ReadLine();

              if (!password.Equals(string.Empty))
              {
                  if (!cpassword.Equals(string.Empty))
                  {
                      if (password.Equals(cpassword))
                      {
                          if (password.Length < 6 || cpassword.Length < 6)
                          {
                              Console.WriteLine("Password should be more than 6 characters");
                          }
                          else
                          {
                              Console.WriteLine("Password match");
                          }
                      }
                      else
                      {
                          Console.WriteLine("Password does not match");
                      }
                  }
                  else
                  {
                      Console.WriteLine("Please Enter a Confirmation Password");
                  }
              }
              else
              {
                  Console.WriteLine("Please Enter a Password");
              }
            */

            //My SOLUTION

        /*
            Console.Write("Enter a Password : ");
            string password = Console.ReadLine();

            if (password == "" || password.Length < 6)
            {
                Console.WriteLine("Password should be more than 6 characters");
            }
            else 
            {
                Console.Write("Confirm Password : ");
                string cpassword = Console.ReadLine();

                if (cpassword == "")
                {
                    Console.WriteLine("Please enter a confirmation password");

                }

                if (password == cpassword)
                {
                    Console.WriteLine("Password matched");
                }
                else
                {
                    Console.WriteLine("Password does not match");
                }
            }

           */

        }

    }

}

