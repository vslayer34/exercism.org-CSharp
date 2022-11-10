using System;

class PhoneNumber
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Analyze("631-555-1234"));
        Console.WriteLine(IsFake(Analyze("631-555-1234")));
    }

    public static (bool isNewYork, bool isFake, string localNumber) Analyze(string phoneNumber)
    {
        bool isNewYork = phoneNumber.StartsWith("212") ? true : false;
        bool isFake = phoneNumber.Substring(4, 3) == "555" ? true : false;
        string localNumber = phoneNumber.Substring(8, 4);
        return (isNewYork, isFake, localNumber);

        /*
         * PhoneNumber.Analyze("631-555-1234");
         * // => (false, true, "1234")
         */
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        bool isFake = phoneNumberInfo.IsFake ? true : false;
        return isFake;
    }
}