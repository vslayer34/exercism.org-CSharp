using System;
using System.Collections.Generic;

internal class ClassName
{
    public static void Main(string[] args)
    {
        // Task 1
        Helper.DisplayTask("I", "Create a new dictionary");
        Dictionary<int, string> newDict = DialingCodes.GetEmptyDictionary();
        if (newDict != null )
            Console.WriteLine("New Dicitionary is created");
        Console.WriteLine();



        // Task 2
        Helper.DisplayTask("II", "Create a pre-populated dictionary");
        Dictionary<int, string> prePopulatedDict = DialingCodes.GetExistingDictionary();
        if (prePopulatedDict != null)
            DisplayDict(prePopulatedDict);
        Console.WriteLine();



        // Task 3
        Helper.DisplayTask("III", "Add a country to an empty dictionary");
        var emptyDictWithAdd = DialingCodes.AddCountryToEmptyDictionary(44, "United Kingdom");
        if (emptyDictWithAdd != null)
            DisplayDict(emptyDictWithAdd);
        Console.WriteLine();



        // Task 4
        Helper.DisplayTask("IV", "Add a country to an existing dictionary");
        DisplayDict(DialingCodes.AddCountryToExistingDictionary(DialingCodes.GetExistingDictionary(), 44, "Unite Kingdom"));
        Console.WriteLine();



        // Task 5
        Helper.DisplayTask("V", "Get the country name matching a dialing code");
        Console.WriteLine(DialingCodes.GetCountryNameFromDictionary(DialingCodes.GetExistingDictionary(), 55));
        Console.WriteLine(DialingCodes.GetCountryNameFromDictionary(DialingCodes.GetExistingDictionary(), 999));
        Console.WriteLine();



        // Task 6
        Helper.DisplayTask("VI", "Check that a country exists in the dictionary");
        Console.WriteLine(DialingCodes.CheckCodeExists(DialingCodes.GetExistingDictionary(), 55));
        Console.WriteLine();



        // Task 7
        Helper.DisplayTask("VII", "Update a country name");
        DisplayDict(DialingCodes.UpdateDictionary(DialingCodes.GetExistingDictionary(), 1, "Les États-Unis"));
        Console.WriteLine();
        DisplayDict(DialingCodes.UpdateDictionary(DialingCodes.GetExistingDictionary(), 999, "Newlands"));
        Console.WriteLine();



        // Task 8
        Helper.DisplayTask("VIII", "Remove a country from the dictionary");
        DisplayDict(DialingCodes.RemoveCountryFromDictionary(DialingCodes.GetExistingDictionary(), 91));
        Console.WriteLine();



        // Task 9
        Helper.DisplayTask("IX", "Find the country with the longest name");
        Console.WriteLine(DialingCodes.FindLongestCountryName(DialingCodes.GetExistingDictionary()));
        Console.WriteLine();
    }


    public static void DisplayDict(Dictionary<int, string> dict)
    {
        foreach (int key in dict.Keys)
        {
            Console.WriteLine($"{key} is the Country code of {dict[key]}");
        }
    }
}