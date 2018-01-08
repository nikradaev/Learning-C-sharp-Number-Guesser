using System;

// namespace
namespace NumberGuesser
{
 
    class Program
    {
         // method to cange color of text
        void ColorMessage(string message, string color)
        {
        // change textcolor
        switch (color)
        {
            case "Red":
                Console.ForegroundColor = ConsoleColor.Red;
                break;

            case "Green":
                Console.ForegroundColor = ConsoleColor.Green;
                break;

            case "Yellow":
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;

            case "Blue":
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
        }

        //write message
        Console.WriteLine(message);

        //change color to basic
        Console.ResetColor();
    }

        //entry point method
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            // set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Nik Radaev";

            //write app info
            myProgram.ColorMessage(appName + " Version " + appVersion + " by " + appAuthor, "Green");

            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}! Let's play a game . . .", inputName);

            while (true)
            {
                //create a Random object
                Random random = new Random();

                // make a random int number
                int correctNumber = random.Next(1, 10);

                // init guess var
                int guess = 0;

                while (guess != correctNumber)
                {
                    Console.WriteLine();
                    // ask user for number
                    myProgram.ColorMessage("Guess a number from 1 to 10.", "Blue");

                    // get users input
                    string input = Console.ReadLine();

                    //make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        myProgram.ColorMessage("Please enter an actual number", "Red");

                        //keep going, go back on top while 
                        continue;
                    }

                    // cast to int and put into guess variable
                    guess = Int32.Parse(input);

                    // match guess to correct number
                    if (guess != correctNumber)
                    {
                        myProgram.ColorMessage("Wrong number. Please try again!", "Red");
                    }
                }

                //Output Success message
                myProgram.ColorMessage("Success! You quessed the number " + correctNumber, "Yellow");

                //ask to play again
                Console.WriteLine("Do you want to try again? Y for Yes");

                string response = Console.ReadLine();

                // check if user puts Y
                if (response == "Y" || response == "y") continue;
                else break;
            }
        }
    }
}
