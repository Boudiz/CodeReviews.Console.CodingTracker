using System.Globalization;
using Spectre.Console;

namespace CodingTracker;

public class CodingSession
{
    private int Id { get; set; }
    private DateTime StartTime { get; set; }
    private DateTime EndTime { get; set; }
    private TimeSpan Duration { get; set; }

    public CodingSession(int id, DateTime startTime, DateTime endTime, TimeSpan duration)
    {
        Id = id;
        StartTime = startTime;
        EndTime = endTime;
        Duration = duration;
    }

    public void AddRowToTable(Table table)
    {
        table.AddRow(Id.ToString(),
            StartTime.ToString(CultureInfo.CurrentCulture),
            EndTime.ToString(CultureInfo.CurrentCulture),
            Duration.ToString());
    }
    
}