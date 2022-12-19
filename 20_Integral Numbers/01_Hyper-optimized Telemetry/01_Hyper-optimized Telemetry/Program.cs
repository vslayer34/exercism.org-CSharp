using System;

internal class ClassName
{
    public static void Main(string[] args)
    {
        // Task 1
        Helper.DisplayTask("I", "Encode an integral value ready to send");
        Helper.DisplayExample(
            "TelemetryBuffer.ToBuffer(5)",
            "{ 0x2, 0x5, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 }"
            );
        Console.WriteLine(TelemetryBuffer.ToBuffer(5));
        Console.WriteLine();


        Helper.DisplayExample(
            "TelemetryBuffer.ToBuffer(Int32.MaxValue)",
            "{ 0xfc, 0xff, 0xff, 0xff, 0x7f, 0x0, 0x0, 0x0, 0x0 }"
            );
        Console.WriteLine(TelemetryBuffer.ToBuffer(Int32.MaxValue));
        Console.WriteLine();
    }
}