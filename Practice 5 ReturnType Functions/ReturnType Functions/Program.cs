using System.Threading.Channels;

namespace ReturnType_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReadNumberFromConsole();
            }

            foreach (int item in numbers)
            {
                Console.Write($" {item} ");
            }
            
        }
        static int ReadNumberFromConsole()
        {
            Console.Write("Enter no : ");
            return Convert.ToInt32(Console.ReadLine());
        }



    }
}
