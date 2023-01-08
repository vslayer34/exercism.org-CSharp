using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string job = "OWNER";

        if (id == null)
            return $"{name} - {department?.ToUpper() ?? job}";

        return $"[{id}] - {name} - {department?.ToUpper() ?? job}";
    }
}
