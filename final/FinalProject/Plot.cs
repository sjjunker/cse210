using System.ComponentModel.DataAnnotations;

public class Plot
{
    private int _length;
    private bool _isFull;
    private List<Plant> _plants = new List<Plant>();

    public Plot()
    {
        _length = 4;
        _isFull = false;
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
        if (!_isFull)
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
        for (int i = 0; i < _plants.Count(); i++)
        {
            if (_plants[i].GetName().ToLower() == plantName.ToLower())
            {
                _plants.Remove(_plants[i]);
                DisplayPlot();
            } else
            {
                Console.WriteLine("Could not remove. Plant is not in the plot.");
            }
        }
    }

    //TODO: Format string style plot display
    public string DisplayPlot()
    {
        string plotString = "";

        foreach(Plant plant in _plants)
        {
            plotString = plotString + "Place holder for displaying the plot.\n";
        }

        return plotString;
    }
}