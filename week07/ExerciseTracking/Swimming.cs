

public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, int minutes, double laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {

        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}

