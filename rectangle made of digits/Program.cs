using System;

namespace rectangle_made_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Build a rectangle.");
            Console.WriteLine("What integer would you like to use? ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0}{0}{0}", number);



            Console.ReadLine();



        }
    }
}
