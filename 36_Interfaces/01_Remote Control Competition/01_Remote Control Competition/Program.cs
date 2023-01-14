using System;

internal class ClassName
{
    public static void Main(string[] args)
    {
        // Task 1
        Helper.DisplayTask("I", "Enable cars to be driven on the same test track");
        TestTrack.Race(new ProductionRemoteControlCar());
        TestTrack.Race(new ExperimentalRemoteControlCar());
        // this should execute without an exception being thrown
        Console.WriteLine();



        // Task 2
        Helper.DisplayTask("II", "Enable the distance travelled by different models on the test track to be compared");
        var prod = new ProductionRemoteControlCar();
        TestTrack.Race(prod);
        var exp = new ExperimentalRemoteControlCar();
        TestTrack.Race(exp);

        Helper.DisplayExample(
            "prod.DistanceTravelled",
            "10"
            );
        Console.WriteLine(prod.DistanceTravelled);
        Console.WriteLine();

        Helper.DisplayExample(
            "exp.DistanceTravelled",
            "20"
            );
        Console.WriteLine(exp.DistanceTravelled);
        Console.WriteLine();



        // Task 3
        Helper.DisplayTask("III", "Allow the production cars to be ranked");
        var prc1 = new ProductionRemoteControlCar();
        var prc2 = new ProductionRemoteControlCar();
        prc1.NumberOfVictories = 3;
        prc2.NumberOfVictories = 2;

        var rankings = TestTrack.GetRankedCars(prc1, prc2);
        Helper.DisplayExample(
            "rankings[1] == prc1",
            "prc1"
            );
        Console.WriteLine(rankings[1].NumberOfVictories);
        Console.WriteLine();
    }
}