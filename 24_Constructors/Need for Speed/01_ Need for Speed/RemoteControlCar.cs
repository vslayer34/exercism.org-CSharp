using System;

class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int speed;
    private int batteryDrain;

    private int distanceDriven;
    private int batteryCapacity = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        if (batteryDrain > batteryCapacity)
            return true;

        return batteryCapacity <= 0;
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
        if (batteryCapacity > 0 && !BatteryDrained())
        {
            distanceDriven += speed;
            batteryCapacity -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        int speed = 50;
        int batteryDrain = 4;

        return new RemoteControlCar(speed, batteryDrain);
    }
}