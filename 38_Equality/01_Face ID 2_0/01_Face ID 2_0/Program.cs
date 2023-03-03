using System;

// URL: https://exercism.org/tracks/csharp/exercises/faceid-2
internal class ClassName
{
    public static void Main(string[] args)
    {
        // Task 1
        Helper.DisplayTask("I", "Ensure that facial features match");
        Helper.DisplayExample(
            "Authenticator.AreSameFace(new FacialFeatures(\"green\", 0.9m), new FacialFeatures(\"green\", 0.9m)",
            "True"
            );
        Console.WriteLine(Authenticator.AreSameFace(new FacialFeatures("green", 0.9m), new FacialFeatures("green", 0.9m)));
        Console.WriteLine();

        Helper.DisplayExample(
            "Authenticator.AreSameFace(new FacialFeatures(\"blue\", 0.9m), new FacialFeatures(\"green\", 0.9m)",
            "False"
            );
        Console.WriteLine(Authenticator.AreSameFace(new FacialFeatures("blue", 0.9m), new FacialFeatures("green", 0.9m)));
        Console.WriteLine();



        // Task 2
        Helper.DisplayTask("II", "Authenticate the system administrator");
        var authenticator = new Authenticator();

        Helper.DisplayExample(
            "authenticator.IsAdmin(new Identity(\"admin@exerc.ism\", new FacialFeatures(\"green\", 0.9m)))",
            "True"
            );
        Console.WriteLine(authenticator.IsAdmin(new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m))));
        Console.WriteLine();

        Helper.DisplayExample(
            "authenticator.IsAdmin(new Identity(\"admin@thecompetition.com\", new FacialFeatures(\"green\", 0.9m)))",
            "False"
            );
        Console.WriteLine(authenticator.IsAdmin(new Identity("admin@thecompetition.com", new FacialFeatures("green", 0.9m))));
        Console.WriteLine();



        // Task 3
        Helper.DisplayTask("III", "Register new identities");

        Helper.DisplayExample(
            "authenticator.Register(new Identity(\"tunde@thecompetition.com\", new FacialFeatures(\"blue\", 0.9m)));",
            "True"
            );
        Console.WriteLine(authenticator.Register(new Identity("tunde@thecompetition.com", new FacialFeatures("blue", 0.9m))));
        Console.WriteLine();


        Helper.DisplayExample(
            "authenticator.IsRegistered(new Identity(\"tunde@thecompetition.com\", new FacialFeatures(\"blue\", 0.9m)));",
            "True"
            );
        Console.WriteLine(authenticator.IsRegistered(new Identity("tunde@thecompetition.com", new FacialFeatures("blue", 0.9m))));
        Console.WriteLine();


        Helper.DisplayExample(
            "authenticator.Register(new Identity(\"tunde@thecompetition.com\", new FacialFeatures(\"blue\", 0.9m)));",
            "False"
            );
        Console.WriteLine(authenticator.Register(new Identity("tunde@thecompetition.com", new FacialFeatures("blue", 0.9m))));
        Console.WriteLine();
    }
}