using System;

class Program
{
    static void Main(string[] args)
    {   
        int guess;
        int num;
        do
        {
            Console.Write("What is the magic number? ");
            string ansNum = Console.ReadLine();
            num = int.Parse(ansNum);

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
        
        } while (guess != num);


    }
}