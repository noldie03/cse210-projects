using System.Diagnostics;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through slow breathing.") { }

    public override void Run()
    {
        Start();

        // Stopwatch stopwatch = new Stopwatch();
        // stopwatch.Start();
        // while (stopwatch.Elapsed.TotalSeconds < GetDuration())
        // {
        //     if (stopwatch.Elapsed.TotalSeconds + 6 > GetDuration())
        //     {
        //         // Not enough time left for a full cycle, so break
        //         break;
        //     }
        //     Console.Write("\nBreathe in...");
        //     ShowCountdown(3);
        //     Console.Write("\nBreathe out...");
        //     ShowCountdown(3);
        // }
        // stopwatch.Stop();

        int timeElapsed = 0;
        while (timeElapsed < GetDuration())
        {
            Console.Write("\nDeep breathe in...");
            ShowCountdown(4);
            Console.Write("\nThen slowly breathe out...");
            ShowCountdown(4);
            timeElapsed += 8;
        }

        End();
    }
}