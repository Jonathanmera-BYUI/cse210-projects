using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    

{
    "What was the best part of my day?",
    "Who was the most interesting person I interacted with today?",
    "What made me smile today?",
    "What challenge did I overcome today?",
    "What am I grateful for today?"
};

    public string GetRandomPrompt()
    
    {
       Random randomGenerator = new Random();

       int randomNumber = randomGenerator.Next(_prompts.Count);

       return _prompts[randomNumber];
      
    }
}