public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "How did you see God's hand in your life today?",
        "What did you think about when you first woke up this morning?",
        "If you could visit any planet in the solar system, which would it be and why?",
        "What food cravings did you have today?",
        "Which do you prefer? Sunrise, or sunset?",
        "What is your favorite thing to do in your free time?",
        "What was one of your favorite movies growing up?",
        "If you could have one exoctic pet, what would it be?",
        "What's one thing you're looking forward to for Christmas this year?"
    };

    //Get a random prompt from the list of prompts
    public string GetPrompt()
    {
        System.Random random = new Random();
        int index = random.Next(0, _prompts.Count - 1);

        return _prompts[index];
    }
}