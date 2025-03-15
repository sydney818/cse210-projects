using System;
using System.Collections.Generic;


public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of your day and why?",
        "What challenges did you face today, and how did you handle them?",
        "What are three things you’re grateful for today?",
        "What’s something you learned today?",
        "Describe your ideal day from start to finish.",
        "What’s a happy memory from your childhood?",
        "What’s one way you can improve your relationships with others?",
        "Write about a person who influenced your life positively.",
        "What motivates you to keep going when things get tough?",
        "Describe a moment when you felt completely at peace."
};
    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
} 