// Base class for all mindfulness activities
public abstract class MindfulnessActivity
{
    protected int Duration { get; set; }

    public void StartActivity(string name, string description)
    {
        Console.WriteLine($"Welcome to the {name} Activity.");
        Console.WriteLine(description);
        Console.Write("Enter the duration of the activity in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void EndActivity(string name)
    {
        Console.WriteLine("Great job!");
        Console.WriteLine($"You have completed the {name} activity for {Duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void RunActivity();
}

// Derived class for the Breathing Activity
public class BreathingActivity : MindfulnessActivity
{
    public override void RunActivity()
    {
        StartActivity("Breathing", "This activity will help you relax by guiding you through deep breathing.");
        for (int i = 0; i < Duration; i += 2)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000);
        }
        EndActivity("Breathing");
    }
}

// Derived class for the Reflection Activity
public class ReflectionActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public override void RunActivity()
    {
        StartActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.");
        string prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner(3);

        foreach (string question in questions)
        {
            Console.WriteLine(question);
            ShowSpinner(5);
        }

        EndActivity("Reflection");
    }
}

// Derived class for the Listing Activity
public class ListingActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override void RunActivity()
    {
        StartActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        string prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner(5);

        Console.WriteLine("Start listing items...");
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {items.Count} items.");
        EndActivity("Listing");
    }
}