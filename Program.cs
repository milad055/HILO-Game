class HiLoGame
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Hi-Lo game!");

        while (true)
        {
            Console.WriteLine("Choose a difficulty level:");
            Console.WriteLine("1. Easy (numbers 1-10)");
            Console.WriteLine("2. Medium (numbers 1-100)");
            Console.WriteLine("3. Hard (numbers 1-1000)");

            int choice = ReadIntInRange("Enter your choice (1-3): ", 1, 3);

            int maxNumber = 0;

            switch (choice)
            {
                case 1:
                    maxNumber = 10;
                    break;
                case 2:
                    maxNumber = 100;
                    break;
                case 3:
                    maxNumber = 1000;
                    break;
            }

            PlayGame(maxNumber);

            Console.WriteLine("Play again? (y/n)");
            if (Console.ReadLine().ToLower() != "y")
            {
                break;
            }

        }

            Console.WriteLine("Thanks for playing!");

    }

    static void PlayGame(int maxNumber)
    {
        Random random = new Random();
        int number = random.Next(1, maxNumber + 1);

        Console.WriteLine($"I'm thinking of a number between 1 and {maxNumber}. Guess what it is!");

        int numGuesses = 0;
        while (true)
        {
            int guess = ReadIntInRange("Enter your guess: ", 1, maxNumber);

            numGuesses++;

            if (guess == number)
            {
                Console.WriteLine($"Congratulations, you guessed it in {numGuesses} tries!");
                break;
            }
            else if (guess < number)
            {
                Console.WriteLine("Too low, guess again.");
            }
            else
            {
                Console.WriteLine("Too high, guess again.");
            }
        }
    }

    static int ReadIntInRange(string prompt, int min, int max)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int result) && result >= min && result <= max)
            {
                return result;
            }
            Console.WriteLine($"Please enter an integer between {min} and {max}.");
        }
    }
}
