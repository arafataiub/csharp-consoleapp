using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] details = new string[4]; 
            Console.WriteLine("Full Name:");
            details[0]= Console.ReadLine();
            Console.WriteLine("Age:");
            details[1] =  Console.ReadLine();
            Console.WriteLine("Contact:");
            details[2] =  Console.ReadLine();
            Console.WriteLine("Address:");
            details[3] =  Console.ReadLine();

            
            Console.WriteLine("Your Full details are following...");

            for(int i=0; i<4; i++)
            {
                Console.WriteLine(details[i]);
            }
            Console.ReadKey();

        }
    }
}
