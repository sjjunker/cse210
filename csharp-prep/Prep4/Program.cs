using System;

class Program
{
    static void Main(string[] args)
    {
        //Instantiate a new list
        List<int> enteredList = new List<int>();
        
        //Have user input a list of numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userInput = 1;
        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput != 0)
            {
                enteredList.Add(userInput);
            } 
        }

        //Compute sum, max, and minPositive
        float sum = 0;
        int max = Int32.MinValue;
        int minPositive = Int32.MaxValue;

        foreach (int number in enteredList) 
        {
            sum += number;

            if (number > max)
            {
                max = number;
            }

            if (number > 0 && number < minPositive) 
            {
                minPositive = number;
            }
        }

        //Compute the average
        float average = sum / enteredList.Count;

        //Sort the list
        enteredList.Sort();

        //Display Results
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Largest Number: {max}");
        Console.WriteLine($"Smallest Positive Number: {minPositive}");

        //Display List
        Console.WriteLine("Sorted List:");

        foreach (int listItem in enteredList) 
        {
            Console.Write($"|{listItem}| ");
        }

    }
}