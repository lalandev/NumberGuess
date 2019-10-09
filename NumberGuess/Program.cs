using System;
//NameSpace
namespace NumberGuess
{
    //MainClass
    class Program
    {
       //EntryPoint
        static void Main(string[] args)
        {
            //StartHere
            String appName = "NumberGuess";
            String appVersion = "10.0.0.";
            String appAuthor = "Lalan Dev";

            //Change color
            Console.ForegroundColor = ConsoleColor.Green;


            //Write app info
            Console.WriteLine("{0}: Version: {1}: by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();


            //Ask user name 
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            //Set correct number
            int correctNumber = 7;

            //Init guess var
            int guess = 0;

            //Ask user for number
            Console.WriteLine("Guess the number between 0 and 10");

            //While guess is not correct
            while (guess != correctNumber);
            {
                //Get User Input
                string input = Console.ReadLine();

                //Cast to int and put in guess
                guess = Int32.Parse(input);

                //Match Guess to correct number
                if(guess )


            }




        }
    }
}
