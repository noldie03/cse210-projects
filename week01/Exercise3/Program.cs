using System;

class Program
{
    static void Main(string[] args)
    {   
        // Console.Write("What is the magic number? ");
        //     string ansNum = Console.ReadLine();
        Random randomGenerator = new Random ();
        int num = randomGenerator.Next(1, 101);
        //int num = int.Parse(ansNum);

        int guess = -1;

        while (guess != num)
        {
            
            Console.Write("What is your guess? ");
            string ansGuess = Console.ReadLine();
            guess = int.Parse(ansGuess);

            if (guess < num)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > num)
            {
                Console.WriteLine("Lower");
            }
            else if(guess == num)
            {
                Console.WriteLine("Correct");
            }
        
        } 


    }
}