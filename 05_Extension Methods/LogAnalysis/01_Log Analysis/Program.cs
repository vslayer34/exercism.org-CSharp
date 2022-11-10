using System;

class LogAnalysis
{
    public static void Main(string[] args)
    {
        // test 1
        string str1 = "[INFO]: File Deleted.".SubstringAfter(": ");
        Console.WriteLine(str1);

        // test 2
        // first case
        string str2 = "[INFO]: File Deleted.".SubstringBetween("[", "]");
        Console.WriteLine(str2);
        // second case
        string str3 = "FIND >>> SOMETHING <===< HERE".SubstringBetween(">>> ", " <===<");
        Console.WriteLine(str3);

        // test 3
        string str4 = "[WARNING]: Library is deprecated.".Message();
        Console.WriteLine(str4);

        // test 4
        string str5 = "[WARNING]: Library is deprecated.".LogLevel();
        Console.WriteLine(str5);
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
}

public static class StringExtension
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string after)
    {
        int index = str.IndexOf(after) + after.Length;
        return str.Remove(0, index);

        /*
         * var log = "[INFO]: File Deleted.";
         * log.SubstringAfter(": "); // => returns "File Deleted."
         */
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string braket1, string braket2)
    {
        int index1 = str.IndexOf(braket1) + braket1.Length;
        int stringLength = str.IndexOf(braket2) - index1;

        return str.Substring(index1, stringLength);

        /*
         * var log = "[INFO]: File Deleted.";
         * log.SubstringBetween("[", "]"); // => returns "INFO"
         */
    }

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");

        /*
         * var log = "[ERROR]: Missing ; on line 20.";
         * log.Message(); // => returns "Missing ; on line 20."
         */
    }

    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");

        /*
         * var log = "[ERROR]: Missing ; on line 20.";
         * log.LogLevel(); // => returns "ERROR"
         */
    }
}