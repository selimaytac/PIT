namespace DTPersonalInfoTracker.Models;

public class LogModel
{
    public int Id { get; set; }
    public string Message { get; set; }
    public string OperationName { get; set; }
    public DateTime Date { get; set; }
}