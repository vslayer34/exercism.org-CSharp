using System;

class ElonsToys
{
    public static void Main(string[] args)
    {
        // Task 1
        Helper.DisplayTask("I", "Buy a brand-new remote controlled car");
        RemoteControlCar car = RemoteControlCar.Buy();
        Console.WriteLine();


        // Task 2
        Helper.DisplayTask("II", "Display the distance driven");
        Helper.DisplayExample("car.DistanceDisplay();", "Driven 0 meters");
        Console.WriteLine(car.DistanceDisplay());
        Console.WriteLine();


        // Task 3
        Helper.DisplayTask("III", "Display the battery percentage");
        Helper.DisplayExample("car.BatteryDisplay();", "Battery at 100%");
        Console.WriteLine(car.BatteryDisplay());
        Console.WriteLine();


        // Task 4
        Helper.DisplayTask("IV", "Update the number of meters driven when driving");
        Helper.DisplayExample("var car = RemoteControlCar.Buy();\r\ncar.Drive();\r\ncar.Drive();\r\ncar.DistanceDisplay();"
            , "Driven 40 meters");
        car.Drive();
        car.Drive();
        Console.WriteLine(car.DistanceDisplay());
        Console.WriteLine();


        // Task 5
        Helper.DisplayTask("V", "Update the battery percentage when driving");
        Helper.DisplayExample("var car = RemoteControlCar.Buy();\r\ncar.Drive();\r\ncar.Drive();\r\ncar.BatteryDisplay();"
            , "Battery at 98%");
        Console.WriteLine(car.BatteryDisplay());
        Console.WriteLine();


        // Task 6
        Helper.DisplayTask("VI", "Prevent driving when the battery is drained");

        // car driven till batter is empty
        for (int i = 0; i < 98; i++)
        {
            car.Drive();
        }

        Helper.DisplayExample("car.DistanceDisplay();", "Driven 2000 meters");
        Console.WriteLine(car.DistanceDisplay());
        Console.WriteLine();

        Helper.DisplayExample("car.BatteryDisplay();", "Battery empty");
        Console.WriteLine(car.BatteryDisplay());
        Console.WriteLine();

    }
}


class RemoteControlCar
{
    private float distanceDriven;
    private int battery = 100;

    public static RemoteControlCar Buy()
    {
        Console.WriteLine("New instance of RemoteControlCar created");
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {distanceDriven} meters";
    }

    public string BatteryDisplay()
    {
        if (battery == 0)
            return "Battery empty";

        return $"Battery at {battery}%";
    }

    public void Drive()
    {
        if (battery == 0)
            return;
        distanceDriven += 20;
        battery -= 1;
    }
}