using System;

internal class ClassName
{
    public static void Main(string[] args)
    {
        Helper.DisplayTask("I", "Enable the remote control car to display sponsor names");
        var car = RemoteControlCar.Buy();
        car.SetSponsors("Exercism", "Walker Industries", "Acme Co.");
        var sp2 = car.DisplaySponsor(1);
        Console.WriteLine($"Sponser: {sp2}");
        Console.WriteLine();

        //----------------------------------------------------------------------------------------------------

        Helper.DisplayTask("II", "Get the car's telemetry data");
        car.Drive();
        car.Drive();
        int serialNum = 4;
        Console.WriteLine($"{car.GetTelemetryData(ref serialNum, out int batteryPercentage, out int distanceDrivenInMeters)}, {serialNum}L, {batteryPercentage}, {distanceDrivenInMeters}");

        serialNum = 1;
        Console.WriteLine($"{car.GetTelemetryData(ref serialNum, out int batteryPercentage1, out int distanceDrivenInMeters1)}, {serialNum}L, {batteryPercentage1}, {distanceDrivenInMeters1}");
        Console.WriteLine();

        //----------------------------------------------------------------------------------------------------

        Helper.DisplayTask("III", "Add functionality so that the telemetry system can get battery usage per meter");
        var tc = new TelemetryClient(car);
        serialNum = 4;
        Console.WriteLine(tc.GetBatteryUsagePerMeter(serialNum));
        serialNum = 1;
        Console.WriteLine(tc.GetBatteryUsagePerMeter(serialNum));
        Console.WriteLine();
    }
}