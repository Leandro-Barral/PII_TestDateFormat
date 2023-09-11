using Ucu.Poo.TestDateFormat;

namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void RightFormat()
    {
        string date = "25/05/1986";
        string dateConverted = DateFormatter.ChangeFormat(date);
        Assert.IsTrue(dateConverted=="1986-05-25");  
    }

    [Test]
    public void TooLong()
    {
        string date = "255/05/1986";
        string dateConverted = DateFormatter.ChangeFormat(date);
        Assert.IsTrue(dateConverted=="255/05/1986");  
    }

    [Test]
    public void NotNumbers()
    {
        string date = "2d/05/1986";
        string dateConverted = DateFormatter.ChangeFormat(date);
        Assert.IsTrue(dateConverted=="2d/05/1986");  
    }

    [Test]
    public void MissingSlash()
    {
        string date = "25/05-1986";
        string dateConverted = DateFormatter.ChangeFormat(date);
        Assert.IsTrue(dateConverted=="25/05-1986");  
    }

    [Test]
    public void EmptyDate()
    {
        string date = "";
        string dateConverted = DateFormatter.ChangeFormat(date);
        Assert.IsTrue(dateConverted=="");  
    }

}