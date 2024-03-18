using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Console.WriteLine("New Assignment");
        Assignment newAssignment = new Assignment("Jessica Kurzawa", "C#");
        Console.WriteLine(newAssignment.GetSummary());

        Console.WriteLine();

        Console.WriteLine("New Math Assignment");
        MathAssignment newMathAssignment = new MathAssignment("Chapter 4", "Questions 6-10", "Mark Chrysler", "Fractions");
        Console.WriteLine(newMathAssignment.GetSummary());
        Console.WriteLine(newMathAssignment.GetHomeworkList());

        Console.WriteLine();

        Console.WriteLine("New Writing Assignment");
        WritingAssignment newWritingAssignment = new WritingAssignment("The Woes of Burnout", "Phillip Harbaugh", "Theological Essay");
        Console.WriteLine(newWritingAssignment.GetSummary());
        Console.WriteLine(newWritingAssignment.GetWritingInformation());

        Console.WriteLine();
    }

    
}