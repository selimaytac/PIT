using System.Reflection;
using DTPersonalInfoTracker.Models;
using Microsoft.Extensions.Configuration;

namespace DTPersonalInfoTracker.Helpers;

public class SettingsHelper
{
    private static IConfigurationRoot? _configuration;

    public static IConfigurationRoot Configuration =>
        _configuration ?? (_configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables()
            .Build());

    public static AppSettings GetSettings()
    {
        return Configuration.GetSection(AppSettings.Name).Get<AppSettings>();
    }

    public static string GetLogPath()
    {
        return Configuration.GetSection("LogPath").Value;
    }
    
    public static string GetConnectionString()
    {
        return Configuration.GetSection("ConnectionStrings").GetSection("DefaultConnectionString").Value;
    }
}