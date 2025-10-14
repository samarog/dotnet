namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game: Guess The Number

            // variables
            int result = 0;
            int attempts = 0;

            // Machine number generator (at startup)
            Random random = new Random();
            int machineNumber = random.Next(1, 10);

            // game flow 

            Console.WriteLine("> Guess The Number!");
            Console.WriteLine("");

            Console.WriteLine("You have to guess the right number (1-9). Try until you make it. Go ahead:");

            result = PlayGame();
            attempts = 1;

            // Console.WriteLine(machineNumber); // Uncomment for test mode

            while (result != machineNumber)
            {
                Console.WriteLine("You lost... Gotta keep trying.");
                result = PlayGame();
                attempts++;
            }

            Console.WriteLine($"You WON! It only took you {attempts} {(attempts <= 1 ? "attempt" : "attempts")}.");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            // endgame
        }

        // separation of concerns - game mech outside of main program.
        // game mechanics
        static int PlayGame()
        {
            string? userGuess = Console.ReadLine();
            int.TryParse(userGuess, out int result);
            return result;
        }
    }
}