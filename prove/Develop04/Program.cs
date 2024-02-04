using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness App!");

        while (true)
        {
            DisplayMenu();

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    StartActivity(new BreathingActivity());
                    break;
                case "2":
                    StartActivity(new ReflectionActivity());
                    break;
                case "3":
                    StartActivity(new ListingActivity());
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness App!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
    }
}

static void DisplayMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Enter the number corresponding to your choice:");
    }

    static void StartActivity(Activity activity)
    {
        Console.Clear();
        activity.Start();
        Console.Clear();
    }
}