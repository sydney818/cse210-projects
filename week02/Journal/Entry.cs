using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public string Date => _date;
    public string Prompt => _promptText;
    public string Response => _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        if (!string.IsNullOrWhiteSpace(Prompt))
        {
            Console.WriteLine($"Prompt: {Prompt}");
        }
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine(new string('-', 30));
    }
}