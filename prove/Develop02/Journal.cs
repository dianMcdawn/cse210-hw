public class Journal
{
    public string _name;
    public string _filename;
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        if (_entries.Count > 0)
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Entries:");
            foreach (Entry e in _entries)
            {
                Console.WriteLine($"Date {e._date} - Promt {e._question}");
                Console.WriteLine($"{e._entry}");
                Console.WriteLine("");
            }
        }
        else
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Entries:");
            Console.WriteLine("There are no entries.");
            Console.WriteLine("");
        }
    }

    public void Save()
    {
        //Lets check if the entry list have elements, if not, it will show that.
        bool fileexist = File.Exists(_filename);
        if (fileexist == true)
        {
            if (_entries.Count > 0)
            {
                using (StreamWriter outputFile = new StreamWriter(_filename))
                {
                    foreach (Entry e in _entries)
                    {
                        // Savind data
                        outputFile.WriteLine($"{_name};{e._date};{e._question};{e._entry}");
                    }
                }
            }
            else
            {
                Console.WriteLine("There are nothing to save.");
                Console.WriteLine("");
            }
        }
        else
        {
            Console.WriteLine("The File does not exist. Please try again.");
            Console.WriteLine("");
        }
    }
}