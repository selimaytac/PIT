namespace DTPersonalInfoTracker.Models;

public class AppSettings
{
    public const string Name = "ApiSettings";
    public string ApiUrl { get; set; }
    public string ActionName { get; set; }
    public string FetchXml { get; set; }
    public string DomainName { get; set; }
}