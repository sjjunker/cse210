using System.ComponentModel.DataAnnotations;

public class Plot
{
    private int _length;
    private List<Plant> _plants = new List<Plant>();

    public Plot()
    {
        _length = 4;
    }

    public List<Plant> GetPlants()
    {
        return _plants;
    }

    public void SetPlants(List<Plant> plants)
    {
        _plants.Clear();
        _plants = plants;
    }

    public void SetPlotLength(int length)
    {
        _length = length;
    }

    public int GetPlotLength()
    {
        return _length;
    }

    public bool IsFull()
    {
        if(_plants.Count() == _length)
        {
            return true;
        } else
        {
            return false;
        }
    }

    public void AddPlant(Plant plant)
    {
        if (!IsFull())
        {
            _plants.Add(plant);
            DisplayPlot();
        } else
        {
            Console.WriteLine("Plot is full. Cannot add anymore plants.");
        }
    }

    public void RemovePlant(string plantName)
    {
        //Get index of plant to remove (so array isn't changed during loop)
        int index = 0;
        for (int i = 0; i < _plants.Count(); i++)
        {
            if (_plants[i].GetName().ToLower() == plantName.ToLower())
            {
                index = i;
            } else
            {
                Console.WriteLine("Could not remove. Plant is not in the plot.");
            }
        }

        //remove the plant
        _plants.Remove(_plants[index]);
        DisplayPlot();
    }

    //TODO: Format string style plot display
    public void DisplayPlot()
    {
        

        foreach(Plant plant in _plants)
        {
            Console.WriteLine(plant.GetName());
        }

        
    }
}