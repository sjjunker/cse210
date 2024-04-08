public class Annual : Plant
{
    private string _plantingSeason;
    private int _daysToHarvest;

    public Annual(string plantingSeason, int daysToHarvest, string name, string description) : base(name, description)
    {
        _plantingSeason = plantingSeason;
        _daysToHarvest = daysToHarvest;
    }

    public override string DisplayPlant()
    {
        return $"Name: {_name}\nPlanting Season: {_plantingSeason}\tDays to Harvest: {_daysToHarvest}\nDescription:\n{_description}";
    }

    public override string PlantString()
    {
        return $"Annual|{_name}|{_description}|{_initial}|{_plantingSeason}|{_daysToHarvest}";
    }
}