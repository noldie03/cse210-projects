using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices.Marshalling;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of number, type 0 when finished.");

        int numInput = 1;
        int sum = 0;
        int max = 0;
        int minPositive = 99999;

        while (numInput != 0)
        {
            Console.Write("Enter number: ");
            string ansInput = Console.ReadLine();
            numInput = int.Parse(ansInput);

            if (numInput != 0)
            {
                numbers.Add(numInput);
            }
        }
      
        foreach (int num in numbers)
        {
            sum += num;

            if (num > max)
            {
                max = num;
            }
            if (num > 0 && num < minPositive)
            {
                minPositive = num;
            }
        }
        
        float avg = ((float)sum) / numbers.Count;
        
        Console.WriteLine($"Total is: {sum}");
        // Console.WriteLine($"Count is: {numbers.Count}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is : {max}");
        Console.WriteLine($"The smallest positive number is {minPositive}");
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        numbers.ForEach(Console.WriteLine);
    }
}