namespace DTPersonalInfoTracker.Helpers;

public class FetchDataHelper
{
    public static async Task<string> FetchXmlData(string url, string action, string fetchXml, string domainName)
    {
        var httpClient = new HttpClient();
        try
        {
            var requestUri =
                url
                + action
                + "?fetchXml=" + fetchXml
                + "&domainName=" + domainName;

            var result = await httpClient.PostAsync(requestUri, null);

            var response = await result.Content.ReadAsStringAsync();

            return response;
        }
        catch (Exception e)
        {
            LoggerHelper.Error(e.Message);
            return string.Empty;
        }
    }
}