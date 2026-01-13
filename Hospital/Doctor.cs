namespace Hospital;

public class Doctor
{
    internal string DoctorName { get; set; }
    internal string AreaOfExpertise { get; set; }
    internal string TreatPatient { get; set; }
    internal DateTime PlannedStartTime { get; set; }
    internal DateTime? ActualCheckInTime { get; set; }
    internal DateTime? Leave { get; set; }

    internal Doctor(string doctorname, string areaofexpertise, string treatpatient, DateTime starttime)
    {
        DoctorName = doctorname;
        AreaOfExpertise = areaofexpertise;
        TreatPatient = treatpatient;
        PlannedStartTime = starttime;
        ActualCheckInTime = null;
        Leave = null;
    }


    internal string GetInformationDoc()
    {
        return $"Doctor: {DoctorName}:\nExpertise: {AreaOfExpertise}\nTreated Patient: {TreatPatient}";
    }

    public string GetCheckInStatus()
    {
        if (ActualCheckInTime != null)
        {
            TimeSpan delay = ActualCheckInTime.Value - PlannedStartTime;
            int delayMinutes = (int)delay.TotalMinutes;

            if (delayMinutes <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return $"{DoctorName} arrived at {ActualCheckInTime.Value:HH:mm}";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return $"{DoctorName} actual check in time: {ActualCheckInTime.Value:HH:mm} ({delayMinutes} minutes late)";
            }
        }
        return $"{DoctorName} has not checked in yet.";
    }
}