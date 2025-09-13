using System;

public class PromptGenerator
{
  string[] prompts = {
    "Who was the most interesting person I interacted with today?",

    "What was the best part of my day?",

    "How did I see the hand of the Lord in my life today?",

    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",

    "What is something new I learned today, big or small?",

    "Describe a moment when you felt grateful today.",

    "What challenge did I face today and how did I handle it?",

    "What is one thing I’m looking forward to tomorrow?",

    "If I could send a message to my future self, what would it say about today?",
  };

  public string PromptUser()
  {
    Random rnd = new Random();
    int index = rnd.Next(prompts.Length);

    string prompt = prompts[index];

    return prompt;
  }

}