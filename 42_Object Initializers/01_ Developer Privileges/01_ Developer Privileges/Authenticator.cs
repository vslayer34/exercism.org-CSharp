using System;
using System.Collections.Generic;
using System.Security.Principal;

public class Authenticator
{
    // TODO: Implement the Authenticator.Admin property
    public Identity Admin { get; } = 
        new Identity
        {
            Email = "admin@ex.ism",
            FacialFeatures = new FacialFeatures
            {
                EyeColor = "green",
                PhiltrumWidth = 0.9m
            },
            NameAndAddress = new List<string> { "Chanakya", "Mumbai", "India" }
        };

    // TODO: Implement the Authenticator.Developers property
    public IDictionary<string, Identity> Developers { get; } = new Dictionary<string, Identity>
    {
        ["Bertrand"] = new Identity
        {
            Email = "bert@ex.ism",
            FacialFeatures = new FacialFeatures
            {
                EyeColor = "blue",
                PhiltrumWidth = 0.8m
            },
            NameAndAddress = new List<string> { "Bertrand", "Paris", "France" }
        },
        ["Anders"] = new Identity
        {
            Email = "anders@ex.ism",
            FacialFeatures = new FacialFeatures
            {
                EyeColor = "brown",
                PhiltrumWidth = 0.85m
            },
            NameAndAddress = new List<string> { "Anders", "Redmond", "USA" }
        }
    };
}