using System;
using System.Transactions;

/*The extra creativity part of my program includes a list of first letters
for each currently hidden word. When you type "Hint" this list will appear, but only until the next time you hit enter.*/
class Program
{
    static void Main(string[] args)
    {
        //Create a new reference
        string book = "2 Nephi";
        int chapter = 22;
        int verse = 11;
        int endVerse = 13;
        Reference reference = new Reference(book, chapter, verse, endVerse);

        //Create a new scripture
        string scriptureText = "O thou afflicted, tossed with tempest, and not comforted! Behold, I will lay thy stones with fair colors, and lay thy foundations with sapphires. And I will make thy windows of agates, and thy gates of carbuncles, and all thy borders of pleasant stones. And all thy children shall be taught of the Lord; and great shall be the peace of thy children.";
        Scripture scripture = new Scripture(reference, scriptureText);

        while(!scripture.IsCompletelyHidden())
        {
            //Display Menu
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Please choose from the following:");
            Console.WriteLine("Enter: Hide Words");
            Console.WriteLine("Hint: Get a Hint");
            Console.WriteLine("Quit: To Quit");
            string userInput = Console.ReadLine();

            //Respond to user input
            switch(userInput)
            {
                case "":
                    Console.Clear();
                    scripture.HideRandomWords(5);
                    break;
                case "Hint":
                    Console.Clear();
                    Console.WriteLine(scripture.GetHintText());
                    break;
                case "Quit":
                    Environment.Exit(0);
                    break;
            }

        }

    }
}