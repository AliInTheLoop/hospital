namespace Hospital;

internal class Patient
{
    internal string Name { get; set; }
    internal int Age { get; set; }
    internal string Symptoms { get; set; }
    internal string MedicalHistory { get; set; }
    internal DateTime CheckInTime { get; set; }

    internal Patient(string name, int age = 0, string symptoms = "", string medicalHistory = "")
    {
        Name = name;
        Age = age;
        Symptoms = symptoms;
        MedicalHistory = medicalHistory;
        CheckInTime = DateTime.Now;
    }

    internal string PrintInformation()
    {
        return "Name: " + Name + ",\n" +
        "Age: " + Age + ",\n" +
        "Symptoms: " + Symptoms + ",\n" +
        "Medical History: " + MedicalHistory;
    }

    internal string CheckInAtDoctor()
    {
        return $"Patient {Name} checked in at {CheckInTime.ToString("HH:mm")}.";
    }
}