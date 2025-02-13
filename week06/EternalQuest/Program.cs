using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(goalManager);
                    break;
                case "2":
                    RecordEvent(goalManager);
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    break;
                case "4":
                    goalManager.DisplayScore();
                    break;
                case "5":
                    Console.Write("Enter filename to save: ");
                    goalManager.SaveGoals(Console.ReadLine());
                    break;
                case "6":
                    Console.Write("Enter filename to load: ");
                    goalManager.LoadGoals(Console.ReadLine());
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CreateNewGoal(GoalManager goalManager)
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose goal type: ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                goalManager.AddGoal(new SimpleGoal(name, description, points));
                break;
            case "2":
                goalManager.AddGoal(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void RecordEvent(GoalManager goalManager)
    {
        Console.Write("Enter goal number to record: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        goalManager.RecordEvent(index);
    }
}