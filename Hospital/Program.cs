using Hospital.Employees.Workers;

class Program
{
    // static Doctor d1 = new Doctor("Ali", 12345, 01);
    static void Main(string[] args)
    {
        while (true)
        {
            switch (Menu())
            {
                case "0":
                    Exit();
                    break;
                case "1":
                    DoctorClass();
                    break;
            }
        }
        
    }

    static void DoctorClass()
    {
        var d1 = new Doctor("Ali", 234, 0)
        {
            StartTime = DateTime.Today.AddHours(8),
            EndTime   = DateTime.Today.AddHours(16) 
        };

        var overTime = d1.GetWorkTime();         
        var pretty   = d1.FormatSigned(overTime);  
        Console.WriteLine($"{d1} worked {pretty}");
    }

    static string Menu()
    {
        Console.WriteLine("=== Menu ===");
        Console.WriteLine("1) Doctor Class");
        return Console.ReadLine();
    }

    static void Exit() => Environment.Exit(0);
}