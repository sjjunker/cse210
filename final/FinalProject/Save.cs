public class Save 
{
    private string _fileName;

    public Save(){}

    private string GetFileName()
    {
        Console.WriteLine("Please enter a file name: ");
        return Console.ReadLine();
    }

    public void SavePlot(List<Plant> plants)
    {
        using (StreamWriter outputFile = new StreamWriter(GetFileName()))
        {
            foreach(Plant plant in plants)
            {
                outputFile.WriteLine(plant.PlantString());
            }
        }
    }
}