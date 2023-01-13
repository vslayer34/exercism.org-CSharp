using System;

class WeighingMachine
{
    public const string errorMessage = "the weight can't be in negative";

    private double weight;

    // TODO: define the 'Precision' property
    public int Precision { get; }

    // TODO: define the 'Weight' property
    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < 0.0f) throw new ArgumentOutOfRangeException(errorMessage);
            weight = value;
        }
    }

    // TODO: define the 'DisplayWeight' property
    public string DisplayWeight
    {
        get { return $"{(Weight - TareAdjustment).ToString($"N{Precision}")} kg"; }
    }

    // TODO: define the 'TareAdjustment' property
    public double TareAdjustment { get; set; }

    public WeighingMachine(int precision)
    {
        Precision = precision;
        TareAdjustment = 5.0f;
    }
}
