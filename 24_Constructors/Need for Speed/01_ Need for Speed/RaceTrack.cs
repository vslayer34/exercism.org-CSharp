using System;


class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        bool hasFinished = false;
        while (car.DistanceDriven() < distance && !car.BatteryDrained())
        {
            car.Drive();
            
            if (car.DistanceDriven() >= distance)
            {
                hasFinished = true;
                break;
            }
        }

        return hasFinished;
    }
}