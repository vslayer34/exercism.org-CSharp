using System;
using System.Collections.Generic;

// URL: https://exercism.org/tracks/csharp/exercises/faceid-2
public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }

    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        if (this.GetType() != obj.GetType()) return false;
        FacialFeatures other = obj as FacialFeatures;
        return EyeColor == other.EyeColor && PhiltrumWidth == other.PhiltrumWidth;
    }

    public override int GetHashCode()
    {
        return Tuple.Create(EyeColor, PhiltrumWidth).GetHashCode();
    }
}

public class Identity : IEquatable<Identity>
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object? obj) => this.Equals(obj as Identity);

    public bool Equals(Identity? other)
    {
        return FacialFeatures.Equals(other.FacialFeatures) && Email == other.Email;
    }

    public override int GetHashCode()
    {
        return Tuple.Create(Email, FacialFeatures).GetHashCode();
    }
}

public class Authenticator
{
    private HashSet<Identity> registeredUsers = new HashSet<Identity>();

    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }

    public bool IsAdmin(Identity identity)
    {
        return identity.Equals(new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m)));
    }

    public bool Register(Identity identity)
    {
        if (!registeredUsers.Contains(identity))
        {
            registeredUsers.Add(identity);
            return true;
        }
        return false;
    }

    public bool IsRegistered(Identity identity)
    {
        return registeredUsers.Contains(identity);
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return ReferenceEquals(identityA, identityB);
    }
}
