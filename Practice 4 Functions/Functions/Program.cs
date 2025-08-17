namespace Functions
{

    class Test
    {
         public  void something()
        {
            Console.WriteLine("class test");

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class program");
            WelcomeMessage();

            Test test = new Test(); //<--"instance" used when other class that you want to call function from, don't have used (static)
            test.something();

            //Test.something(); <-- (calling funtion) used when "Class Test" have "public static" used
          
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("helloP");
        }
    }
}
