using System;
using System.IO;

public class Journal
{

  private List<Entry> _entries = new List<Entry>();

  public Journal()
  {

  }

  public void AddEntry(Entry entry)
  {
    _entries.Add(entry);
  }

  public void DisplayAll()
  {
    foreach (Entry entry in _entries)
    {
      entry.DisplayEntry();
    }
  }

  public void SaveEntry(string filename)
  {
    using (StreamWriter writer = new StreamWriter(filename, append: true))
    {
      foreach (Entry entry in _entries)
      {
        writer.WriteLine($"{entry._todaysDate} | {entry._prompt} | {entry._response}");
      }
    }
  }

public void LoadFromFile(string filename)
{
    _entries.Clear();

    string[] lines = File.ReadAllLines(filename);
    foreach (string line in lines)
    {
        if (string.IsNullOrWhiteSpace(line)) continue;

        string[] parts = line.Split('|');
        if (parts.Length < 3) continue; // guard against bad lines

        var e = new Entry
        {
            _todaysDate = parts[0].Trim(),
            _prompt     = parts[1].Trim(),
            _response   = parts[2].Trim()
        };

        _entries.Add(e); // don't forget this!
    }
}
}