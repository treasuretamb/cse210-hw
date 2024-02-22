using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("96 Banket Street", "Hillbrow", "Johannesburg","South Africa");
        Lecture lecture = new Lecture("Mastering Life Path", "Growing Beyond Our Environments", DateTime.Now, TimeSpan.FromHours(2), address1, "Ruben and Kelly Van Roos, James Derick", 100);

        Address address2 = new Address("58 Schuller Street", "Forest Hill", "Johanneburg", "South Africa");
        Reception reception = new Reception("Helping Hands", "Visiting the elderly and orphans and sharing talents anad time with them.", DateTime.Now, TimeSpan.FromHours(3), address2, "helpinghands@gmail.com");

        Address address3 = new Address("56 Minors Street", "Yeoville", "Johannnesburg", "South Africa");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Art Gallore", "Artists gathering to paint murals for the community", DateTime.Now, TimeSpan.FromHours(4), address3, "Sunny");

        // Generate marketing messages for each event
        Console.WriteLine("Lecture Marketing Messages:");
        Console.WriteLine("---------------------------");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception Marketing Messages:");
        Console.WriteLine("-----------------------------");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Marketing Messages:");
        Console.WriteLine("------------------------------------");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetShortDescription());
    
    }
}