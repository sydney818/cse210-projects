using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;  


    public Journal(string filename = null)
    {
        _entries = new List<Entry>();

  
        if (!string.IsNullOrEmpty(filename))
        {
            LoadFromFile(filename);
        }
    }

 
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("\nEntry saved!");
    }

    // Display all entries
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }


        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    //save entries to a file
    public void SaveToFile(string filename)
    {
        try
        {
            string path = Path.GetFullPath(filename);
            Console.WriteLine($"Saving to: {path}");  

          
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                foreach (Entry entry in _entries)
                {
                  
                    writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
            }
            Console.WriteLine("\nEntries saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }

    // load entries from a file
    public void LoadFromFile(string filename)
    {
        try
        {
            string path = Path.GetFullPath(filename);
            Console.WriteLine($"Loading from: {path}"); 

            if (File.Exists(filename))
            {
                
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        
                        Entry entry = new Entry(parts[0], parts[1], parts[2]);
                        _entries.Add(entry); 
                    }
                }
                Console.WriteLine("\nEntries loaded successfully!");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
}