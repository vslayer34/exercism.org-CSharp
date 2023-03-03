using System;

// URL: https://exercism.org/tracks/csharp/exercises/faceid-2
public class FacialFeatures : IEquatable<FacialFeatures>
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }

    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object? obj) => this.Equals(obj as FacialFeatures);
    public bool Equals(FacialFeatures? other)
    {
        return EyeColor == other.EyeColor && PhiltrumWidth == other.PhiltrumWidth;
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
}

public class Authenticator
{
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
        throw new NotImplementedException("Please implement the Authenticator.Register() method");
    }

    public bool IsRegistered(Identity identity)
    {
        throw new NotImplementedException("Please implement the Authenticator.IsRegistered() method");
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        throw new NotImplementedException("Please implement the Authenticator.AreSameObject() method");
    }
}
