using System.Text.Json.Nodes;

namespace DTPersonalInfoTracker.Models;

public class RawResponse
{
    public string JsonObject { get; set; }
    public int ErrorCode { get; set; }
    public object ErrorMessage { get; set; }
}