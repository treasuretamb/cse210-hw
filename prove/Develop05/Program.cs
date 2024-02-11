using System;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;
    static void Main(string[] args)
    {
        LoadData();

        while (true)
        {
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show list of goals");
            Console.WriteLine("4. Show current score");
            Console.WriteLine("5. Save and exit");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ShowGoalList();
                    break;
                case "4":
                    ShowScore();
                    break;
                case "5":
                    SaveData();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();

        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");

        string typeChoice = Console.ReadLine();
        GoalType type = GoalType.Simple;

        switch (typeChoice)
        {
            case "2":
                type = GoalType.Eternal;
                break;
            case "3":
                type = GoalType.Checklist;
                break;
        }

        Goal goal = null;

        switch (type)
        {
            case GoalType.Simple:
                Console.WriteLine("Enter points for completing the goal:");
                int points = int.Parse(Console.ReadLine());
                goal = new SimpleGoal(name, points);
                break;
            case GoalType.Eternal:
                Console.WriteLine("Enter points for each recording of the goal:");
                int eternalPoints = int.Parse(Console.ReadLine());
                goal = new EternalGoal(name, eternalPoints);
                break;
            case GoalType.Checklist:
                Console.WriteLine("Enter points for each recording of the goal:");
                int checklistPoints = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the desired number of completions for the goal:");
                int desiredCompletions = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter bonus points for achieving the desired completions:");
                int bonusPoints = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, checklistPoints, desiredCompletions, bonusPoints);
                break;
        }

        goals.Add(goal);
        Console.WriteLine("Goal created successfully!");
    }

    static void RecordEvent()
    {
        Console.WriteLine("Enter the name of the goal you want to record an event for:");
        string name = Console.ReadLine();

        Goal goal = goals.FirstOrDefault(g => g.Name == name);

        if (goal != null)
        {
            goal.RecordEvent();
            score += goal.GetPoints();
            Console.WriteLine("Event recorded successfully!");
        }
        else
        {
            Console.WriteLine("Goal not found. Please create the goal first.");
        }
    }

    static void ShowGoalList()
    {
        Console.WriteLine("Goal List:");
        foreach (var goal in goals)
        {
            Console.Write($"[{(goal.IsCompleted ? 'X' : ' ')}] {goal.Name}");

            if (goal.Type == GoalType.Checklist)
            {
                var checklistGoal = (ChecklistGoal)goal;
                Console.Write($" (Completed {checklistGoal.Completions}/{checklistGoal.DesiredCompletions} times)");
            }

            Console.WriteLine();
        }
    }

    static void ShowScore()
    {
        Console.WriteLine($"Current Score: {score}");
    }

    static void SaveData()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.ToString());
            }
        }

        Console.WriteLine("Data saved successfully!");
    }

    static void LoadData()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    string name = parts[0];
                    GoalType type = (GoalType)Enum.Parse(typeof(GoalType), parts[1]);

                    Goal goal = null;

                    switch (type)
                    {
                        case GoalType.Simple:
                            int points = int.Parse(parts[2]);
                            goal = new SimpleGoal(name, points);
                            break;
                        case GoalType.Eternal:
                            int eternalPoints = int.Parse(parts[2]);
                            goal = new EternalGoal(name, eternalPoints);
                            break;
                        case GoalType.Checklist:
                            int checklistPoints = int.Parse(parts[2]);
                            int completions = int.Parse(parts[3]);
                            int desiredCompletions = int.Parse(parts[4]);
                            int bonusPoints = int.Parse(parts[5]);
                            goal = new ChecklistGoal(name, checklistPoints, desiredCompletions, bonusPoints);
                            ((ChecklistGoal)goal).Completions = completions;
                            break;
                    }

                    bool isCompleted = bool.Parse(parts[6]);
                    goal.IsCompleted = isCompleted;
                    goals.Add(goal);
                }
            }

            Console.WriteLine("Data loaded successfully!");
        }
    }
}

enum GoalType
{
    Simple,
    Eternal,
    Checklist
}
    