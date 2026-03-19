using System;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the highlight of your day?",
        "Describe something you learned today.",
        "What are you grateful for right now?",
        "Write about a challenge you faced and how you handled it.",
        "What made you smile today?",
        "Is there something you wish you had done differently today?",
        "Who did you connect with today and how did it make you feel?",
        "What is one goal you have for tomorrow?",
        "Describe a moment when you felt at peace today.",
        "What is something you are looking forward to?"
    };

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int n = rnd.Next(1,_prompts.Count());
        return _prompts[n];   
    }
}
