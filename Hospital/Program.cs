using Hospital;

var doc = new Doctor("Thobias", "Radiology", "Alex", DateTime.Today);
Console.WriteLine(doc.GetInformationDoc());


doc.ActualCheckInTime = DateTime.Today.AddHours(9); // heute um 09:00 Uhr
Console.WriteLine(doc.ActualCheckInTime?.ToString("HH:mm"));
