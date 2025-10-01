namespace Hospital.Appointment;

public class Status
{
    internal string PatientName { get; set; }
    internal string DoctorName { get; set; }
    internal string AreaOfExpertise { get; set; }
    
    
    public Status(string patientName)
    {
        PatientName = patientName;
    }


}