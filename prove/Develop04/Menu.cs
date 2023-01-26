using System;

class Menu
{
    
    private string _menuWelcome ="Welcome to the Mindfulness Program.";
    
    private string _menu0 = "Menu Options:";
    private string _menu1 = "1. Start breathing activity";
    private string _menu2 = "2. Start reflecting activity";
    private string _menu3 = "3. Start listing activity";
    private string _menu4 = "4. Quit";
    private string _menu5 = "Select a choice from the menu: ";
    public Menu()
    {
        DisplayMenu();
    }

    private void DisplayMenu()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(_menuWelcome);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(_menu0);
        Console.WriteLine(_menu1);
        Console.WriteLine(_menu2);
        Console.WriteLine(_menu3);
        Console.WriteLine(_menu4);
        Console.Write(_menu5);
    }
}