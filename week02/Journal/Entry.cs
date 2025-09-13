using System;

public class Entry
{
  public string _todaysDate = "";
  public string _prompt = "";
  public string _response = "";

  public Entry()
  {

  }

  public void DisplayEntry()
  {
    Console.WriteLine($"{_todaysDate} - {_prompt}");
    Console.WriteLine($"{_response}");
  }



}