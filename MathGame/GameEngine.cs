namespace MathGame
{
    internal class GameEngine
    {

        internal void AdditionGame(string message)
        {
            Random random = new Random();
            int score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                string result = Console.ReadLine();
                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for next question.");
                    score++;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for next question.");
                    Console.ReadKey();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to return to the main menu.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            Helpers.AddToHistory(score, "Addition");
        }

        internal void SubstractionGame(string message)
        {
            Random random = new Random();
            int score = 0;

            int firstNumber;
            int secondNumber;


            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                string result = Console.ReadLine();

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for next question.");
                    score++;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for next question.");
                    Console.ReadKey();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to return to the main menu.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            Helpers.AddToHistory(score, "Substraction");
        }

        internal void MultiplicationGame(string message)
        {
            Random random = new Random();
            int score = 0;

            int firstNumber;
            int secondNumber;


            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                string result = Console.ReadLine();

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for next question.");
                    score++;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for next question.");
                    Console.ReadKey();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to return to the main menu.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            Helpers.AddToHistory(score, "Multiplication");
        }

        internal void DivisionGame(string message)
        {
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int[] divisionNumbers = Helpers.GetDivisionNumbers();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();


                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for next question.");
                    score++;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for next question.");
                    Console.ReadKey();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to return to the main menu.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            Helpers.AddToHistory(score, "Division");
        }
    }
}
