class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    // Define the Lasagna.ExpectedMinutesInOven() method that does not take any parameters and returns how many minutes the lasagna should be in the oven. According to the cooking book, the expected oven time in minutes is 40:
    public int ExpectedMinutesInOven()
    {
        return 40;
    }


    // TODO: define the 'RemainingMinutesInOven()' method
    // Define the Lasagna.RemainingMinutesInOven() method that takes the actual minutes the lasagna has been in the oven as a parameter and returns how many minutes the lasagna still has to remain in the oven, based on the expected oven time in minutes from the previous task.
    public int RemainingMinutesInOven(int timeInOven)
    {
        return 40 - timeInOven;
    }


    // TODO: define the 'PreparationTimeInMinutes()' method
    // Define the Lasagna.PreparationTimeInMinutes() method that takes the number of layers you added to the lasagna as a parameter and returns how many minutes you spent preparing the lasagna, assuming each layer takes you 2 minutes to prepare.
    public int PreparationTimeInMinutes(int layersNum)
    {
        return layersNum * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    // Define the Lasagna.ElapsedTimeInMinutes() method that takes two parameters: the first parameter is the number of layers you added to the lasagna, and the second parameter is the number of minutes the lasagna has been in the oven. The function should return how many minutes you've worked on cooking the lasagna, which is the sum of the preparation time in minutes, and the time in minutes the lasagna has spent in the oven at the moment.
    public int ElapsedTimeInMinutes(int layerNum, int timeInOven)
    {
        return timeInOven + (layerNum * 2);
    }
}
