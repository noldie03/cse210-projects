using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public PromptGenerator()
    {
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("What was the worst part of your day?");
        _prompts.Add("What did you learn today?");
        _prompts.Add("What are you grateful for?");
        _prompts.Add("What is something that made you smile today?");
        _prompts.Add("What is something that made you sad today?");
        _prompts.Add("What is something you want to remember about today?");
    }
    public string GetRandomPrompt()
    {
        // return "";
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

}