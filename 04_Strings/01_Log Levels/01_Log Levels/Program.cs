using System;
using System.Text.RegularExpressions;

//[ERROR]: Invalid operation
static class LogLine
{
    public static void Main(string[] args)
    {
        Console.WriteLine(LogLine.Message("[ERROR]: Invalid operation"));
        Console.WriteLine(LogLine.LogLevel("[ERROR]: Disk full"));
        Console.WriteLine(LogLine.Reformat("[ERROR]: Segmentation fault"));
    }
    public static string Message(string logLine)
    {
        Regex match = new Regex("^\\[.*\\]:");
        Match m = match.Match(logLine);
        return logLine.Replace(m.ToString(), "").Trim();
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");

        /*
         * Solution
         * LogLine.Message("[ERROR]: Invalid operation")
         * // => "Invalid operation"
         [ERROR]: Invalid operation
        */
    }

    public static string LogLevel(string logLine)
    {
        Regex match = new Regex("^\\[.*\\]:");
        Match m = match.Match(logLine);
        return m.ToString().Remove(m.Length - 2).Remove(0, 1).ToLower();
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");

        /*
         * LogLine.LogLevel("[ERROR]: Invalid operation")
         * // => "error"
        */
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string insideBrakecteds = LogLevel(logLine);
        return message + $" ({insideBrakecteds})";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");

        /*
         * LogLine.Reformat("[INFO]: Operation completed")
         * // => "Operation completed (info)"
         */
    }
}
