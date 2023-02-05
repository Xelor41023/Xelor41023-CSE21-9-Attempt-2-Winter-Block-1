using System;

class Menu
{
    private List<string> MainMenu;
    private List<string> GoalMenu;

    public Menu()
    {
        MainMenu = new List<string>{

            "Main Menu\n",
            "1. Create New Goal",
            "2. List Goals",
            "4. Load Goals",
            "3. Save Goals",
            "5. Record Event",
            "6. Quit\n"
        };

        GoalMenu = new List<string>{

            "1. Goal Menu\n",
            "2. Add New Simple Goal",
            "3. Add New Eternal Goal",
            "4. Add NewChecklist Goal",
            "5. Previous Menu\n"
        };

    }

    public void displayMainMenu()
    {
        foreach (string line in MainMenu)
        {
            Console.WriteLine(line);
        }
    }

    public void displayGoalMenu()
    {
        foreach (string line in GoalMenu)
        {
            Console.WriteLine(line);
        }
    }

    public int returnMainMenuChoice()
    {
        Console.WriteLine("Choose a Menu Option");
        return int.Parse(Console.ReadLine());


    }

}



















    
