using System.Text;


public static class Identifier
{
    private static bool IsGreekLowerCase(char c) => (c > 'α' && c <= 'ω');

    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();
        bool isAfterDash = false;

        foreach (char c in identifier)
        {
            sb.Append(c switch
            {
                _ when IsGreekLowerCase(c) => default,
                _ when isAfterDash => Char.ToUpperInvariant(c),
                _ when Char.IsLetter(c) => c,
                _ when Char.IsControl(c) => "CTRL",
                _ when Char.IsWhiteSpace(c) => '_',
                _ => default,
            });

            isAfterDash = c.Equals('-');
        }
        
        return sb.ToString();
    }
}
