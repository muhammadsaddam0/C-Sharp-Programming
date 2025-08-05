using System.Diagnostics.Metrics;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //""""PRACTICE QUESTION 9   (ARRAYS) """"



            //Console.Write("How many items you want to add in list: ");
            //int list = Convert.ToInt32(Console.ReadLine());

            //int[] numbers = new int[list];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"Enter list value {i + 1}");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine();

            //}
            //Console.Write("The list values are : ");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}
            //Console.WriteLine();

            //""""PRACTICE QUESTION 10   (ADDING ARRAYS) """"

            /*
                Console.Write("Enter no of angles : ");
                int anglecount = Convert.ToInt32(Console.ReadLine());


                int[] angles = new int [anglecount];


                for (int i = 0; i < angles.Length; i++)
                {
                    Console.WriteLine($"Enter angle {i + 1} : ");
                    angles[i] = Convert.ToInt32(Console.ReadLine());

                }
                int anglesum2 = 0;

                foreach (int angle in angles)
                {
                    anglesum2 += angle;
                }
                 Console.WriteLine($"The sum of the angles is : {anglesum2}" );

                    // OR for loop

                int anglesum = 0;

                for (int i = 0; i < angles.Length; i++)
                {
                  anglesum += angles[i];

                }
                Console.WriteLine($"The sum of the angles is : {anglesum}");



            */

            //""""PRACTICE QUESTION 11   (SORTING & REVERSING ARRAYS) """"

            /*
                Console.Write("How many items you want to add in list: ");
                int list = Convert.ToInt32(Console.ReadLine());


                int[] listvalues = new int[list];

                for (int i = 0; i < listvalues.Length; i++)
                {

                    Console.Write($"Enter list values {i + 1} : ");
                    listvalues[i] = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine();

                Console.Write("The list values are : ");
                foreach (int i in listvalues) //normal list print
                {
                    Console.Write($"{i} ");
                }

                Console.WriteLine();
                Array.Reverse(listvalues);

                Console.Write("The Reverse list values are : ");
                foreach (int i in listvalues)
                {
                    Console.Write($"{i} ");  // Reverse list print
                }

                Console.WriteLine();
                Array.Sort(listvalues);

                Console.Write("The sorted  list values are : ");
                foreach (int i in listvalues)
                {
                    Console.Write($"{i} ");  // sorted list print
                }
                */

            //""""PRACTICE QUESTION 12   (ARRAYS INDEXING) """"

            /*

                int[]  numbers = new int[]
                {
                    90,199,22,50,30
                };

                Console.Write("Enter number to search : ");
                int search = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //int variableName = Array.IndexOf(ArrayVaribleName, search, index from you want to start searching, index you want to stop searching );
                //int position = Array.IndexOf(numbers, search,0,3);

                int position = Array.IndexOf(numbers, search);      // search all array items

                //int position = -1; // this code works same as above function (.IndexOf)

                //for (int i = 0; i < numbers.Length; i++)
                //{
                //    if (numbers[i] == search)
                //    {
                //        position = i;
                //    }
                //}
                if (position == -1)
                {
                    Console.WriteLine($"The number {search} not found on the list");
                }
                else
                {
                    Console.WriteLine($"The number {search} is at the positon {position + 1}");
                }
                */



            //""""EXERCISE QUESTION    (ARRAY OF MULTIPLES) """"

        /*
            Console.Write("Enter the table you want to print : ");
            int table = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Multiplications you want from the table : ");
            int multiplication = Convert.ToInt32(Console.ReadLine());


            int[] result = new int[multiplication];
            
            int counter = 0; 
            for (int i = 1; i <= result.Length ; i++)
            {
                result[counter] = table * i;
                counter++;
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"{table} x {i + 1} = {result[i]} ");
            }
            */
        }
    }
}
