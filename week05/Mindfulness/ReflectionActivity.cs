class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection", "This activity helps you reflect on times of strength and resilience.") { }

    public override void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine($"\nPrompt: {_prompts[rand.Next(_prompts.Count)]}\n");
        Console.Write("Please press enter key when ready to reflect on the prompt.");
        Console.ReadLine();

        int timeElapsed = 0;
        while (timeElapsed < GetDuration())
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine($"> {question}");
            _questions.Remove(question); // Remove the selected question to avoid repetition
            ShowSpinner(7);
            timeElapsed += 7;
        }

        End();
    }
}