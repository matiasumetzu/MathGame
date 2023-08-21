namespace MathGame
{
    internal class Helpers
    {

        static List<string> games = new();

        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Previous Games");
            Console.WriteLine("------------------------------------------");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("------------------------------------------\n");
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadKey();
            Console.Clear();
        }

        internal static void AddToHistory(int gameScore, string gameType)
        {
            games.Add($"{DateTime.Now} - {gameType}: {gameScore} pts");
        }

        internal static int[] GetDivisionNumbers()
        {
            Random random = new Random();
            int firstNumber = random.Next(0, 99);
            int secondNumber = random.Next(0, 99);

            int[] result = new int[2];


            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static void SlowPrint(string text, int speed = 40)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }
    }
}
