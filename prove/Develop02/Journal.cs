public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveFile(string file)
    {
        List<string> records = new List<string>();
        foreach (Entry entry in entries)
        {
            string entryAsCSV = $"{entry.Date} | {entry.Question} | {entry.UserEntry}";
            records.Add(entryAsCSV);
        }

        File.WriteAllLines(file, records);
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFile(string file)
    {
        if (File.Exists(file))
        {
            List<string> records = File.ReadAllLines(file).ToList();
            foreach (string record in records)
            {
                string[] splitString = record.Split('|');
                Entry entry = new Entry(splitString[0].Trim(), splitString[1].Trim(), splitString[2].Trim());

                entries.Add(entry);
            }

            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found. Please make sure the file exists.");
        }
    }
}