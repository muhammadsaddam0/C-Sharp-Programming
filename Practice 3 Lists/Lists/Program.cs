using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // LIST PRACTICE 1

            /*
                List<int> listNumbers = new List<int>
                {
                    4,6,3,1,5
                };

                Console.Write("The normal List Values : ");
                foreach (var item in listNumbers)
                {
                    Console.Write(item);
                }
                Console.WriteLine();

                //listNumbers.Add(1); Adds 1 in the list at the last


                Console.Write("The Sorted List Values : ");
                listNumbers.Sort();
                foreach (var item in listNumbers)
                {
                    Console.Write(item);
                }
            */



            // LIST PRACTICE 2 printing
            /*
                        List<int> ListNumber = new List<int>();

                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write($"Enter the list value {i+1} : ");
                            int number = Convert.ToInt32(Console.ReadLine());
                            ListNumber.Add(number);
                        }

                        Console.WriteLine();

                        for (int i = 0; i < ListNumber.Count; i++)
                        {
                            Console.WriteLine($" The List value {i+1} is : {ListNumber[i]} ");
                        }

                        */

            // LIST PRACTICE 3

            //Console.Write("how many items you want to add : ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < number; i++)
            //{
            //    Console.WriteLine("Enter the items value : ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    ListNumber.Add(num);
            //}

            //Console.Write("The Added List items are : ");
            //foreach (int item in ListNumber)
            //{
            //    Console.Write(item);
            //}

            //List<int> ListNumber = new List<int>()
            //{
            //    5,4,3,1,2,7
            //};

            //Console.Write("The List items are : ");
            //foreach (int item in ListNumber)
            //{
            //    Console.Write(item);
            //}

            //Console.WriteLine();
            //Console.Write("Enter the item you want to remove : ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();
            //Console.Write($"The List items after removing {num1} are : ");
            //ListNumber.Remove(num1);
            //for (int i = 0;i < ListNumber.Count; i++)
            //{
            //    if (num1 == i)
            //    {
            //        foreach (int item in ListNumber)
            //        {
            //            Console.Write(item);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("not found");
            //    }
            //}








            //List<int> ListNumber = new List<int>()
            //{
            //    5, 4, 3, 1, 2, 7
            //};

            //        Console.Write("The List items are: ");
            //        foreach (int item in ListNumber)
            //        {
            //            Console.Write(item + " ");
            //        }

            //        Console.WriteLine();
            //        Console.Write("Enter the item you want to remove: ");
            //        int num1 = Convert.ToInt32(Console.ReadLine());

            //        bool removed = ListNumber.Remove(num1);

            //        if (removed)
            //        {
            //            Console.Write($"The List items after removing {num1} are: ");
            //            foreach (int item in ListNumber)
            //            {
            //                Console.Write(item + " ");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{num1} was not found in the list.");
            //        }

            //EXERCISE QUESTION LIST


                    /*
                        * Create two lists with integer data type, one for even numbers, one for odd
                        * Loop from 0 - 20
                        * if number is even, add to even list
                        * if number is odd, add to odd list
                        *Print even list
                        *Print odd list
                    */

            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    evenList.Add(i);
                }
                else
                {
                    oddList.Add(i);
                }
            }

            Console.WriteLine("Printing Even numbers : ");
            foreach (int item in evenList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            Console.WriteLine(Environment.NewLine + "Printing Odd numbers : ");//Environment.NewLine for newline 
            foreach (int item in oddList)
            {
                Console.Write($"{item} ");
            }



        }
    }

    }
