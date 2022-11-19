using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Identifier
{
    public static string Clean(string identifier)
    {
        string cleanedIdentifier = "";

        foreach (char character in identifier)
        {
            if (character.ToString() == " ")
            {
                cleanedIdentifier = identifier.Replace(character, '_');
            }

            if (char.IsControl(character))
            {
                cleanedIdentifier = identifier.Replace(character.ToString(), "CTRL");
            }
        }

        return cleanedIdentifier;
    }
}
