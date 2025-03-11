public class PromptGenerator
{
    public List<string> _prompts = new List<string> {
            "Who was the most interesting person I interacted with today?", 
            "What was the best part of my day?", 
            "How did I see the hand of the Lord in my life today?", 
            "What was the strongest emotion I felt today?", 
            "If I had one thing I could do over today, what would it be?", 
            "What are three things you're grateful for today, and why do they matter to you right now?", 
            "How are you feeling right now? What do you think is influencing your emotions at this moment?", 
            "Imagine you're talking to your younger self. What advice would you give them? What would you want to say to reassure them?",
            "What’s a small win you’re proud of?",
            "What’s one thing you want to let go of?"
        };

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int rndNum = rnd.Next(_prompts.Count);
        string rndPrompt = _prompts[rndNum];
        _prompts.Remove(rndPrompt);

        return rndPrompt;
    }
}