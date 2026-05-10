using System.Collections.Generic;
using System;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
    
     int userNumber = -1;
     int sum = 0;
        while (userNumber != 0)
        {
           Console.Write("Enter a number: "); 

           string response = Console.ReadLine();
           userNumber = int.Parse(response);

        if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        } 

        foreach (int number in numbers)
        {
             sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");   
    }
}