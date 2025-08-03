namespace Hospital;

internal class Nurse
{
    internal string NurseName { get; set; }
    internal string Station { get; set; }
    internal string ShiftPlan { get; set; }
    internal string PatientCare { get; set; }
    internal string MedicationDispensing { get; set; }
    internal DateTime NurseShiftStart { get; set; }
    internal DateTime? ActualTimeStartNurse { get; set; }



    internal Nurse(string name, string station, string shiftplan, string patientcare, string medicationdispensing, DateTime nurseshiftstarrt)
    {
        NurseName = name;
        Station = station;
        ShiftPlan = shiftplan;
        PatientCare = patientcare;
        MedicationDispensing = medicationdispensing;
        NurseShiftStart = nurseshiftstarrt;
        ActualTimeStartNurse = null;
    }

    internal string GetInformationNurse()
    {
        return $"{NurseName} at the Station: {Station}\n" +
               $"Nurse Shift will be {ShiftPlan}\n" +
               $"Nurse take care of Patient {PatientCare}\n" +
               $"Give the patient {MedicationDispensing}";
    }

    internal string GetNurseTime()
    {
        if (ActualTimeStartNurse != null)
        {
            TimeSpan delayNurse = ActualTimeStartNurse.Value - NurseShiftStart;

            return delayNurse.TotalMinutes <= 0
                ? $"Nurse: {NurseName} shift start at {NurseShiftStart}"
                : $"{NurseName} arrived at: {ActualTimeStartNurse.Value:HH:mm}\n{NurseName}: {(int)delayNurse.TotalMinutes} minute(s) to late.";
        }
        else
        {
            return $"{NurseName} didn't started yet!";
        }
    }
}