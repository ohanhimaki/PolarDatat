namespace AnnanPolariDatat.Api.Models;
    
public class DailyOhr
{
    public DeviceDays[] deviceDays { get; set; }
}

public class DeviceDays
{
    public int userId { get; set; }
    public string deviceId { get; set; }
    public Date date { get; set; }
    public Samples[] samples { get; set; }
}

public class Date
{
    public int year { get; set; }
    public int month { get; set; }
    public int day { get; set; }
}

public class Samples
{
    public int heartRate { get; set; }
    public int secondsFromDayStart { get; set; }
    public string source { get; set; }
}


public class OhrDto
{
    public DateTime Date { get; set; }
    public int HeartRate { get; set; }
    public int Hour { get; set; }
    public int Minutes { get; set; }
}
