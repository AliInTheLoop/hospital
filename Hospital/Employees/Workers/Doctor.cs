namespace Hospital.Employees.Workers;

public class Doctor(string name, int ssn, int id) : WorkerInformation(name, ssn, id)
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    private TimeSpan WorkingTime => EndTime - StartTime;
    private TimeSpan ContractHours => TimeSpan.FromHours(8);

    public TimeSpan GetWorkTime()
    {
        if (WorkingTime > ContractHours || WorkingTime < ContractHours)
        {
            return    WorkingTime - ContractHours;
        }
        else
        {
            return TimeSpan.Zero;
        }
    }
    
    public string FormatSigned(TimeSpan ts)
    {
        var sign = ts.Ticks >= 0 ? "+" : "-";
        ts = GetWorkTime(); 
        return $"{sign}{(int)ts.TotalHours}h {ts.Minutes}m";
    }

    public override string ToString() => $"Doctor {Name}";
}