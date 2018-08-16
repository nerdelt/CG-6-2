using System;


namespace UpperCaseGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for input
            Console.WriteLine("Welcome to the UPPER CASE GENERATOR!");
            Console.WriteLine("We take regular sentences and turn them into all UPPER CASE for you.\n");
            Console.Write("Please type in your sentence: ");

            //converts user input to string
            string userSentence = Console.ReadLine();
            //converts string to all upper case
            userSentence = userSentence.ToUpper();

            //prints user input
            Console.WriteLine($"\nYour ugraded sentence: {userSentence}");
            Console.ReadLine();

        }
    }
}
