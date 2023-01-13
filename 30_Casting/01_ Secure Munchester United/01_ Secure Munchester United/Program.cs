using System;

internal class ClassName
{
    public static void Main(string[] args)
    {
        // Task 1
        Helper.DisplayTask("I", "Get display name for a member of the support team as long as they are staff members");
        var spm = new SecurityPassMaker();

        Helper.DisplayExample("spm.GetDisplayName(new Manager())",
            "Too Important for a Security Pass"
            );
        Console.WriteLine(spm.GetDisplayName(new Manager()));
        
        Console.WriteLine();

        Helper.DisplayExample(
            "spm.GetDisplayName(new Physio())",
            "The Physio"
            );
        Console.WriteLine(spm.GetDisplayName(new Physio()));
        Console.WriteLine();



        // Task 2
        Helper.DisplayTask("II", "Customize the display name for the security team");
        var spm2 = new SecurityPassMaker();

        Helper.DisplayExample("spm2.GetDisplayName(new Security())",
            "Security Team Member Priority Personnel"
            );
        Console.WriteLine(spm2.GetDisplayName(new Security()));
        Console.WriteLine();



        // Task 3
        Helper.DisplayTask("III", "Only designate principal security team members as priority personnel");
        Helper.DisplayExample("spm2.GetDisplayName(new SecurityJunior())",
            "Security Junior"
            );
        Console.WriteLine(spm2.GetDisplayName(new SecurityJunior()));
        Console.WriteLine();
    }
}