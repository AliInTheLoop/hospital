namespace Hospital;

public class Doctor
{
    public string DoctorName { get; set; }
    public string AreaOfExpertise { get; set; }
    public string TreatPatient { get; set; }
    public DateTime PlannedStartTime { get; set; }
    public DateTime? ActualCheckInTime { get; set; }
    public DateTime? Leave { get; set; }

    public Doctor(string doctorname, string areaofexpertise, string treatpatient, DateTime starttime)
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

    public string GetCheckInStatus(int time)
    {
        if (ActualCheckInTime != null)
        {
            TimeSpan delay = ActualCheckInTime.Value - PlannedStartTime;
            int delayMinutes = (int)delay.TotalMinutes;

            if (delayMinutes <= 0)
            {
                return $"{DoctorName} arrived at {ActualCheckInTime.Value:HH:mm}";
            }
            else
            {
                return $"{DoctorName} actual check in time: {ActualCheckInTime.Value:HH:mm} ({delayMinutes} minutes late)";
            }
        }
        
        return $"{DoctorName} has not checked in yet.";
    }
}