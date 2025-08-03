namespace Hospital;

internal class WorkerID
{
    internal string WorkerName { get; set; }
    internal int ID { get; set; }

    internal WorkerID(string name, int id)
    {
        WorkerName = name;
        ID = id;
    }

    public override string ToString()
    {
        return $"{WorkerName}" + ": ID-NUmber: " + ID;
    }
}