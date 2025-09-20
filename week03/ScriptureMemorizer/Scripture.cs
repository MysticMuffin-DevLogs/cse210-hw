using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random(); 

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

       
        var parts = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (var p in parts)
        {
            _words.Add(new Word(p));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
    

        for (int i = 0; i < numberToHide; i++)
        {
            int idx = _random.Next(_words.Count);
            _words[idx].Hide();
        }
    }

    public string GetDisplayText()
    {
        string refText = _reference.GetDisplayText();

        
        List<string> rendered = new List<string>();
        foreach (var w in _words)
            rendered.Add(w.GetDisplayText());

        string text = string.Join(" ", rendered);
        return $"{refText}\n{text}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (var w in _words)
            if (!w.IsHidden()) return false;
        return true;
    }
}
