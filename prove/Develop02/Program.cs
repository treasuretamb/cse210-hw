using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Prompt promptGenerator = new Prompt();
        Journal journal = new Journal();
        int menuUserInput = 0;

        List<string> menu = new List<string>
        {
            "Please select one of the following choices: ",
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Close Journal",
            "What would you like to do?"
        };

        Console.WriteLine("Welcome to the Journal Program.");

        Console.WriteLine();

        while (menuUserInput != 5)
        {
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            
            if (int.TryParse(Console.ReadLine(), out menuUserInput))
            {
                switch (menuUserInput)
                {
                    case 1:
                        string question = promptGenerator.GetPrompt();
                        Console.WriteLine(question);
                        Console.Write("> ");
                        string response = Console.ReadLine();
                        string date = DateTime.Now.Date.ToString("MM dd, yyyy");

                        Entry entry = new Entry(date, question, response);
                        journal.AddEntry(entry);
                        break;

                    case 2:
                        journal.DisplayEntries();
                        break;

                    case 3:
                        Console.WriteLine("Name of file to load?");
                        string fileNameLoad = Console.ReadLine();
                        journal.LoadFile(fileNameLoad);
                        break;

                    case 4:
                        Console.WriteLine("Name of file to save?");
                        string fileNameSave = Console.ReadLine();
                        journal.SaveFile(fileNameSave);
                        break;

                    case 5:
                        // Add any closing operations if needed
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.ReadLine(); // Consume the invalid input
            }
        }
    }
}