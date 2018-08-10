using System;


namespace UpperCaseGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the UPPER CASE GENERATOR!");
            Console.WriteLine("We take regular sentences and turn them into all UPPER CASE for you.\n");
            Console.Write("Please type in your sentence: ");

            string userSentence = Console.ReadLine();
            userSentence = userSentence.ToUpper();

            Console.WriteLine($"\nYour ugraded sentence: {userSentence}");
            Console.ReadLine();

        }
    }
}
