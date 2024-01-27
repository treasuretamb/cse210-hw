using System;

class Program
{
    static void Main(string[] args)
    {
       string scriptureText = "There is no fear in love; but perfect love casteth out fear: because fear hath torment. He that feareth is not made perfect in love.";
        ScriptureReference scriptureRef = new ScriptureReference("1 John", 4, 18);
        Scripture scripture = new Scripture(scriptureRef, scriptureText);
        WordHider wordHider = new WordHider(scripture);

        Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
        Console.WriteLine(scripture.GetFullScripture());

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            Console.Clear();
            wordHider.HideRandomWord();
            Console.WriteLine("\n");

            if (wordHider.IsScriptureHidden())
                break;
        }

        Console.WriteLine("Scripture hidden completely.");
        Console.ReadKey();
    }
       
}