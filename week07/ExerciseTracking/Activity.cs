

public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    
    public int GetMinutes()
    {
        return _minutes;
    }

        public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

        public virtual string GetSummary()
    {
        return $"{_date} Activity ({_minutes} min) - Distance {GetDistance():0.0}, Speed {GetSpeed():0.0}, Pace: {GetPace():0.0}";
    }
}