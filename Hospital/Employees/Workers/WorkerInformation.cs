namespace Hospital.Employees.Workers;

public abstract class WorkerInformation
{
    internal string Name { get; private set; }
    internal string Address { get;  set; }
    internal int Ssn { get; private set; }
    internal int Id { set; private get; }
    internal string Phone { get; private set; }
    internal string Email { get; private set; }
    internal int Age { get; private set; }

    protected WorkerInformation(string name, int ssn, int id)
    {
        Name = name;
        Ssn = ssn;
        Id = id;
    }
}