using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] referenceBirds = { 0, 2, 5, 3, 7, 8, 4 };
        return referenceBirds;
    }

    public int Today()
    {
        int lastIndex = birdsPerDay.Length - 1;
        return birdsPerDay[lastIndex];
    }

    public void IncrementTodaysCount()
    {
        int lastIndex = birdsPerDay.Length - 1;
        birdsPerDay[lastIndex]++;
    }

    public bool HasDayWithoutBirds()
    {
        return Array.Exists(birdsPerDay, bird => bird == 0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int totalBirds = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            totalBirds += birdsPerDay[i];
        }

        return totalBirds;
    }

    public int BusyDays()
    {
        int[] busydaysPerWeek;
        busydaysPerWeek = Array.FindAll(birdsPerDay, bird => bird >= 5);

        return busydaysPerWeek.Length;
    }
}