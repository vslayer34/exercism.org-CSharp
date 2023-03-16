using System;

public class TelemetryClient
{
    private RemoteControlCar car;

    public TelemetryClient(RemoteControlCar car)
    {
        this.car = car;
    }

    public string GetBatteryUsagePerMeter(int serialNum)
    {
        bool telemetryData = car.GetTelemetryData(ref serialNum, out int batteryPercentage, out int distanceDriven);

        if (telemetryData && distanceDriven != 0)
        {
            int usage = (100 - batteryPercentage) / distanceDriven;
            return $"usage-per-meter={usage}";
        }

        return "no data";
    }
}

