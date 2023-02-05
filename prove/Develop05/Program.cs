using System;

class Program
{
    static void Main(string[] args)
    {
        int  Menuchoice = 0;
        
        Menu Menu = new Menu();
        Menu.displayMainMenu();
        Menuchoice = Menu.returnMainMenuChoice();

        switch (Menuchoice)
        {
        case 1:
            Menu.displayGoalMenu();

        break;

        case 2:
        //
        break;

        case 3:
        //
        break;

        case 4:
        //
        break;

        case 5:
        //
        break;

        case 6:
        //
        break;

        default:
        Console.WriteLine("Invalid input please enter a number from 1-6");
        break;
        }
    }
}