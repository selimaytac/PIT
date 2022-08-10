using DTPersonalInfoTracker.DbContexts;
using DTPersonalInfoTracker.Models;
using Serilog;
using Serilog.Core;

namespace DTPersonalInfoTracker.Helpers;

public class LoggerHelper
{
    static LoggerHelper()
    {
        DTLogger = InitilalizeLogger(SettingsHelper.GetLogPath());
    }

    public static Logger DTLogger { get; set; }

    public static Logger InitilalizeLogger(string logPath)
    {
        return new LoggerConfiguration().WriteTo
            .File(logPath + $"DTPIT/{DateTime.Today.ToShortDateString()}.txt")
            .CreateLogger();
    }

    public static void Warning(string message)
    {
        DTLogger.Warning(message);
    }

    public static void Error(string message)
    {
        DTLogger.Error(message);
    }

    public static void Information(string message)
    {
        DTLogger.Information(message);
    }

    public static void LogToDb(PITDbContext context, LogModel log)
    {
        context.Logs.Add(log);
        context.SaveChanges();
    }
}