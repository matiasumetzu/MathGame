using MathGame;

Menu menu = new Menu();

Welcome.WelcomeScreen();

string GetName()
{
    Helpers.SlowPrint("What is your name?");
    string name = Console.ReadLine();
    return name;
}

string name = GetName();

menu.ShowMenu(name);











