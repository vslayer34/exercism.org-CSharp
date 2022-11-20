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
        
        if (identifier == null)
            return cleanedIdentifier;


        for (int i = 0; i < identifier.Length; i++)
        {
            if (identifier[i].ToString() == " ")
            {
                cleanedIdentifier = identifier.Replace(identifier[i], '_');
            }

            if (char.IsControl(identifier[i]))
            {
                cleanedIdentifier = identifier.Replace(identifier[i].ToString(), "CTRL");
            }

            if (identifier[i] == '-')
            {
                cleanedIdentifier = identifier.Replace(identifier[i].ToString(), "");
                cleanedIdentifier[i + 1].ToString().ToUpper();
            }
        }

        return cleanedIdentifier;
    }
}
