public class Perennial : Plant
{
    private string _harvestSeason;
    private int _yearLifeSpan;

    public Perennial(string name, string description, string harvestSeason, int yearLifeSpan) : base(name, description)
    {
        _harvestSeason = harvestSeason;
        _yearLifeSpan = yearLifeSpan;
    }

    public override string DisplayPlant()
    {
        return $"Name: {_name}\nHarvest Season: {_harvestSeason}\tLifespan in Years: {_yearLifeSpan}\nDescription:\n{_description}";
    }

    public override string PlantString()
    {
        return $"perennial|{_name}|{_description}|{_initial}|{_harvestSeason}|{_yearLifeSpan}";
    }
}