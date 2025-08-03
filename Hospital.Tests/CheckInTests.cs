using NUnit.Framework;
using Hospital;

namespace Hospital.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        Doctor doc =  new Doctor("Thobias", "Radiology","Ali", DateTime.Now);
        doc.ActualCheckInTime = DateTime.Now;
        doc.GetCheckInStatus(22);
    }
    
    [Test]
    public void GetCheckInStatusTest()
    {
        Assert.That(doc.GetCheckInStatus(22), Is.EqualTo("Thobias has not checked in yet."));
    }
}