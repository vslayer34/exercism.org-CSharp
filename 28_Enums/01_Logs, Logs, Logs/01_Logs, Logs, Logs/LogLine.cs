using System;
using System.Runtime.CompilerServices;

// TODO: define the 'LogLevel' enum
enum LogLevel
{
    Unknown,
    Trace,
    Debug,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42
};


static class LogLine
{

    private static readonly string[] logMessages = { "TRC", "DBG", "INF", "WRN", "ERR", "FTL" };
    private const string errorMessage = "Please check the log message type for an error";

    public static LogLevel ParseLogLevel(string logLine)
    {
        string logLvlString = logLine.Substring(1, 3);

        return logLvlString switch
        {
            "TRC" => LogLevel.Trace,
            "DBG" => LogLevel.Debug,
            "INF" => LogLevel.Info,
            "WRN" => LogLevel.Warning,
            "ERR" => LogLevel.Error,
            "FTL" => LogLevel.Fatal,
            _ => LogLevel.Unknown,
        };
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{(int)logLevel}:{message}";
    }
}
