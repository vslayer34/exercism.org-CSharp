using System;

internal class ClassName
{
    public static void Main(string[] args)
    {
        // Task 1
        Helper.DisplayTask("I", "Parse log level");
        Helper.DisplayExample
        (
            "LogLine.ParseLogLevel(\"[INF]: File deleted\")",
            LogLevel.Info.ToString()
        );
        Console.WriteLine(LogLine.ParseLogLevel("[INF]: File deleted"));
        Console.WriteLine();


        
        // Task 2
        Helper.DisplayTask("II", "Support unknown log level");
        Helper.DisplayExample
            (
                "LogLine.ParseLogLevel(\"[XYZ]: Overly specific, out of context message\")",
                LogLevel.Unknown.ToString()
            );
        Console.WriteLine(LogLine.ParseLogLevel("[XYZ]: Overly specific, out of context message"));
        Console.WriteLine();



        // Task 3
        Helper.DisplayTask("III", "Convert log line to short format");
        Helper.DisplayExample(
            "LogLine.OutputForShortLog(LogLevel.Error, \"Stack overflow\")",
            "6:Stack overflow"
            );
        Console.WriteLine(LogLine.OutputForShortLog(LogLevel.Error, "Stack overflow"));
        Console.WriteLine();
    }
}