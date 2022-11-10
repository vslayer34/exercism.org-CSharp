using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Text.Encodings.Web;

public interface ITuringContainer
{
    string Data { get; set; }
}


class Dev
{

}

class M :Dev
{

}

class Program
{
    public static void Main(string[] args)
    {
        List<int> elements = new List<int>
        {
            200, 150, 50
        };

        var result = from i in elements where i > 0 select i;
        Console.WriteLine(result);
    }

    public static void Convert(float price)
    {
        object objPrice = price;
        int newPrice = (int) (double) objPrice;
        Console.WriteLine(newPrice);
    }

    public static void I<T> (T target) where T : Dev, new(){

}