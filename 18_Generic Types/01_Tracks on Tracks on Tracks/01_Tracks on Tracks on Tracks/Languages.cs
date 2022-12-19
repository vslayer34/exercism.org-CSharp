using System;
using System.Collections.Generic;
using System.Linq;

public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        var list = new List<string>();
        list.Add("C#");
        list.Add("Clojure");
        list.Add("Elm");
        return list;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Sort();
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        string excitingLanguage = "C#";
        if (languages.Count == 0)
            return false;
        else if (languages.First() == excitingLanguage)
            return true;
        else if (languages[1] == excitingLanguage && languages.Count >= 2 && languages.Count <= 3)
            return true;
        else
            return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        return languages.Distinct().Count() == Languages.CountLanguages(languages);
    }
}
