using System.Threading;

namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new();
  
        internal void ShowMenu(string name)
        {
            bool isGameOn = true;
            do
            {
                Greeting.Greet(name);
               Helpers.SlowPrint(@$"What game would you like to play today?
         A - Addition
         S - Substraction
         M - Multiplication
         D - Division
         P - Previous Games
         Q - Quit",15);
                Console.WriteLine("------------------------------------------");

                ConsoleKeyInfo gameSelected = Console.ReadKey();

                switch (gameSelected.KeyChar)
                {
                    case 'p':
                        Helpers.GetGames();
                        break;
                    case 'a':
                        gameEngine.AdditionGame("Addition game");
                        break;
                    case 's':
                        gameEngine.SubstractionGame("Substraction game");
                        break;
                    case 'm':
                        gameEngine.MultiplicationGame("Multiplication game");
                        break;
                    case 'd':
                        gameEngine.DivisionGame("Division game");
                        break;
                    case 'q':
                        Console.Clear();
                        Helpers.SlowPrint("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("\n Invalid Input.\n");
                        Console.WriteLine("Wait 2 seconds and try again.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Wait 1 second and try again.. \n");
                        Thread.Sleep(1000);
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (isGameOn);

        } 
    }
}
