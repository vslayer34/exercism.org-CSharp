using System;


public struct CurrencyAmount : IComparable<CurrencyAmount>
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }


    // Icompareable, Equal and GetHashCode implemntation
    public int CompareTo(CurrencyAmount other)
    {
        if (other == null) { return 1; }

        return amount.CompareTo(other.amount);
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is CurrencyAmount)) return false;

        return this == (CurrencyAmount)obj;
    }

    public override int GetHashCode()
    {
        return Tuple.Create(amount, currency).GetHashCode();
    }

    // TODO: implement equality operators
    public static bool operator ==(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency == rhs.currency)
            return lhs.amount == rhs.amount;
        else
            throw new ArgumentException("Can't compare different currencies");
    }

    public static bool operator !=(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency == rhs.currency)
            return lhs.amount != rhs.amount;
        else
            throw new ArgumentException("Can't compare different currencies");
    }


    // TODO: implement comparison operators
    public static bool operator >(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency != rhs.currency) { throw new ArgumentException("Can't compare different currencies"); }
        
        return lhs.CompareTo(rhs) > 0;
    }

    public static bool operator <(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency != rhs.currency) { throw new ArgumentException("Can't compare different currencies"); }
        
        return lhs.CompareTo(rhs) < 0;
    }

    public static bool operator >=(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency != rhs.currency) { throw new ArgumentException("Can't compare different currencies"); }
        
        return lhs.CompareTo(rhs) >= 0;
    }

    public static bool operator <=(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency != rhs.currency) { throw new ArgumentException("Can't compare different currencies"); }
        
        return lhs.CompareTo(rhs) <= 0;
    }

    // TODO: implement arithmetic operators
    public static CurrencyAmount operator +(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency != rhs.currency) { throw new ArgumentException("Can't compare different currencies"); }
        return new CurrencyAmount(lhs.amount + rhs.amount, lhs.currency);
    }
        

    public static CurrencyAmount operator -(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency != rhs.currency) { throw new ArgumentException("Can't compare different currencies"); }
        return new CurrencyAmount(lhs.amount - rhs.amount, lhs.currency);
    }

    public static CurrencyAmount operator *(CurrencyAmount lhs, decimal rhs) => new CurrencyAmount(lhs.amount * rhs, lhs.currency);

    public static CurrencyAmount operator /(CurrencyAmount lhs, decimal rhs) => new CurrencyAmount(lhs.amount / rhs, lhs.currency);

    // TODO: implement type conversion operators


    public static explicit operator double(CurrencyAmount instance) => (double)instance.amount;

    public static implicit operator decimal(CurrencyAmount instance) => instance.amount;


    // over ToString() Method
    public override string ToString() => $"{{{amount}, {currency}}}";
}


internal class ClassName
{
    public static void Main(string[] args)
    {
        // Task 1
        Helper.DisplayTask("I", "Enable the currency amount to be tested for equality");
        {
            CurrencyAmount amountA = new CurrencyAmount(55, "HD");
            CurrencyAmount amountB = new CurrencyAmount(55, "HD");
            CurrencyAmount amountC = new CurrencyAmount(55, "USD");

            Helper.DisplayExample("amountA == amountB", "True");
            Console.WriteLine(amountA == amountB);
            Console.WriteLine();

            Helper.DisplayExample("amountA != amountB", "False");
            Console.WriteLine(amountA != amountB);
            Console.WriteLine();

            //Helper.DisplayExample("amountA == amountC", "ArgumentException");
            //Console.WriteLine(amountA == amountC);
            //Console.WriteLine();

            //Helper.DisplayExample("amountA != amountC", "ArgumentException");
            //Console.WriteLine(amountA != amountC);
            //Console.WriteLine();

        }



        // Task 2
        Helper.DisplayTask("II", "Compare currency amounts");
        {
            CurrencyAmount amountA = new CurrencyAmount(55, "HD");

            Helper.DisplayExample("amountA > new CurrencyAmount(50, \"HD\")", "True");
            Console.WriteLine(amountA > new CurrencyAmount(50, "HD"));
            Console.WriteLine();

            Helper.DisplayExample("amountA < new CurrencyAmount(50, \"HD\")", "False");
            Console.WriteLine(amountA < new CurrencyAmount(50, "HD"));
            Console.WriteLine();

            //Helper.DisplayExample("amountA > new CurrencyAmount(50, \"USD\")", "ArgumentException");
            //Console.WriteLine(amountA > new CurrencyAmount(50, "USD"));
            //Console.WriteLine();
        }



        // Task 3
        Helper.DisplayTask("III", "Add and subtract currency amounts");
        {
            CurrencyAmount amountA = new CurrencyAmount(55, "HD");
            CurrencyAmount amountB = new CurrencyAmount(100, "HD");
            CurrencyAmount amountC = new CurrencyAmount(55, "USD");

            Helper.DisplayExample("amountA + amountB", "{155, HD}");
            Console.WriteLine(amountA + amountB);
            Console.WriteLine();

            Helper.DisplayExample("amountB - amountA", "{45, HD}");
            Console.WriteLine(amountB - amountA);
            Console.WriteLine();

            //Helper.DisplayExample("amountA + amountC", "ArgumentException");
            //Console.WriteLine(amountA + amountC);
            //Console.WriteLine();
        }


        // Task 4
        Helper.DisplayTask("IV", "Multiply and divide currency amounts");
        {
            CurrencyAmount amountA = new CurrencyAmount(10, "HD");

            Helper.DisplayExample("amountA * 2m", "{20, HD}");
            Console.WriteLine(amountA * 2m);
            Console.WriteLine();

            Helper.DisplayExample("amountA / 2m", "{5, HD}");
            Console.WriteLine(amountA / 2m);
            Console.WriteLine();
        }



        // Task 5
        Helper.DisplayTask("V", "Convert the currency amount to a double");
        {
            CurrencyAmount amountA = new CurrencyAmount(55.5m, "HD");

            Helper.DisplayExample("(double)amountA", "55.5d");
            Console.WriteLine((double)amountA);
            Console.WriteLine();
        }



        // Task 6
        Helper.DisplayTask("VI", "Convert the currency amount to a decimal");
        {
            CurrencyAmount amountA = new CurrencyAmount(55.5m, "HD");

            Helper.DisplayExample("decimal d = amountA", "d == 55.5m");
            decimal d = amountA;
            Console.WriteLine(d);
        }
    }
}