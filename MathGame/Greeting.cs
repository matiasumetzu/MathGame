namespace MathGame
{
    internal class Greeting
    {
      static bool isFirstTime = true;

        internal static void Greet(string name)
        {
            DateTime date = DateTime.Now;

            if (isFirstTime)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------");
                Helpers.SlowPrint($"Hello {name}. Today it's {date}.\n",15);
                isFirstTime = false;
            }
            else
            {
                Helpers.SlowPrint($"Hello Again {name}. Today is still {date}. \n",15);
            }
        }

    }
}
