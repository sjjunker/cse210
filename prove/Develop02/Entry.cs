public class Entry 
{
    public string _date;
    public string _prompt;
    public string _response;
    
    //Methods
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
    }
}