/* using System;

class TimeZones{
    public static void Main(){
        DateTimeOffset currentTime = DateTimeOffset.UtcNow;
        Console.WriteLine("Current Times in Different Time Zones:");
        Console.WriteLine("GMT: "+currentTime);
        Console.WriteLine("IST: "+currentTime.ToOffset(TimeSpan.FromHours(5.5)));
        Console.WriteLine("PST: "+currentTime.ToOffset(TimeSpan.FromHours(-8)));
    }
}
 */