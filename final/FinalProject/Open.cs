public class Open
{
    private List<Plant> _plants = new List<Plant>();
    private string _fileName;

    public Open() { }

    private void GetFileName()
    {
        Console.WriteLine("Please enter a file to open: ");
        _fileName = Console.ReadLine();
    }

    public List<Plant> OpenPlants()
    {
        GetFileName();
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts[0] == "annual")
            {
                Annual newAnnual = new Annual(parts[1], parts[2], parts[4], int.Parse(parts[5]));
                _plants.Add(newAnnual);
            }
            else
            {
                Perennial newPerennial = new Perennial(parts[1], parts[2], parts[4], int.Parse(parts[5]));
                _plants.Add(newPerennial);
            }
        }

        return _plants;
    }
}