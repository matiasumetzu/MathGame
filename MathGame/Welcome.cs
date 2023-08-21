using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Welcome
    {
        internal static void WelcomeScreen()
        {
            Console.WriteLine(@"

 /$$      /$$           /$$                                            
| $$  /$ | $$          | $$                                            
| $$ /$$$| $$  /$$$$$$ | $$  /$$$$$$$  /$$$$$$  /$$$$$$/$$$$   /$$$$$$ 
| $$/$$ $$ $$ /$$__  $$| $$ /$$_____/ /$$__  $$| $$_  $$_  $$ /$$__  $$
| $$$$_  $$$$| $$$$$$$$| $$| $$      | $$  \ $$| $$ \ $$ \ $$| $$$$$$$$
| $$$/ \  $$$| $$_____/| $$| $$      | $$  | $$| $$ | $$ | $$| $$_____/
| $$/   \  $$|  $$$$$$$| $$|  $$$$$$$|  $$$$$$/| $$ | $$ | $$|  $$$$$$$
|__/     \__/ \_______/|__/ \_______/ \______/ |__/ |__/ |__/ \_______/
                                                                      
");
            Helpers.SlowPrint("Loading.", 20);
            Thread.Sleep(500);
            Helpers.SlowPrint("Done.");
            Thread.Sleep(200);
            Console.Clear();
        }
    }
}
