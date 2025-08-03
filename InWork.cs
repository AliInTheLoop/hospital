namespace Hospital;


internal class AtWork
{
    internal bool Begin = false;
    internal WorkerID Worker { get; set; }

    internal AtWork(WorkerID worker, bool begin)
    {
        Worker = worker;
        Begin = begin;
    }

    internal void CheckInAtWork()
    {
        if (Begin)
        {
            Console.WriteLine($"{Worker.WorkerName} has Checked in to work!");
        }
        else
        {
            Console.WriteLine($"{Worker.WorkerName} your shift doesn't started yet!");
        }
    }

    public override string ToString()
    {
        return $"{Worker.WorkerName}";
    }
}