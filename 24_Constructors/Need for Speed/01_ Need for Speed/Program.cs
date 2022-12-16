using System;

internal class ClassName
{
    public static void Main(string[] args)
    {
        // Task 1
        Helper.DisplayTask("I", "Creating a remote controlled car");
        int speed = 5;
        int batteryDrain = 2;
        RemoteControlCar car = new RemoteControlCar(speed, batteryDrain);
        Console.WriteLine();


        // Task 2
        Helper.DisplayTask("II", "Creating a race track");
        int distance = 100;
        RaceTrack raceTrack = new RaceTrack(distance);
        Console.WriteLine();



        // Task 3
        Helper.DisplayTask("III", "Drive the car");
        Helper.DisplayExample(
            "car.DistanceDriven();",
            5.ToString()
            );

        car.Drive();
        Console.WriteLine(car.DistanceDriven());
        Console.WriteLine();



        // Task 4
        Helper.DisplayTask("IV", "Check for a drained battery");
        Helper.DisplayExample(
            "car.BatteryDrained();",
            false.ToString()
            );

        Console.WriteLine(car.BatteryDrained());
        Console.WriteLine();



        // Task 5
        Helper.DisplayTask("V", "Create the Nitro remote control car");
        RemoteControlCar nitroCar = RemoteControlCar.Nitro();
        nitroCar.Drive();
        Console.WriteLine(nitroCar.DistanceDriven());
        Console.WriteLine();



        // Task 6
        Helper.DisplayTask("VI", "Check if a remote control car can finish a race");
        Console.WriteLine(raceTrack.TryFinishTrack(car));
        Console.WriteLine();
    }
}