using System;

static class QuestLogic
{
    // Check if a fast attack can be made
    // Implement the(static) QuestLogic.CanFastAttack() method that takes a boolean value that indicates if the knight is awake.This method returns true if a fast attack can be made based on the state of the knight.Otherwise, returns false:
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return (!knightIsAwake) ? true : false;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return (knightIsAwake || archerIsAwake || prisonerIsAwake) ? true : false;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return (prisonerIsAwake && !archerIsAwake) ? true : false;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (knightIsAwake && !archerIsAwake && prisonerIsAwake && petDogIsPresent)
            return true;
        else if (knightIsAwake && !archerIsAwake && !prisonerIsAwake && petDogIsPresent)
            return true;
        else if (!knightIsAwake && !archerIsAwake && prisonerIsAwake && !petDogIsPresent)
            return true;
        else if (!knightIsAwake && !archerIsAwake && prisonerIsAwake && petDogIsPresent)
            return true;
        else if (!knightIsAwake && !archerIsAwake && !prisonerIsAwake && petDogIsPresent)
            return true;
        else
            return false;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
    }
}
