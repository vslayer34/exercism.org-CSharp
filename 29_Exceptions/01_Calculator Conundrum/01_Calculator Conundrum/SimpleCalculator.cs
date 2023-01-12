using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        return operation switch
        {
            "/" when operand2 == 0 => "Division by zero is not allowed.",
            "/" => $"{operand1} {operation} {operand2} = {SimpleOperation.Division(operand1, operand2)}",
            "*" => $"{operand1} {operation} {operand2} = {SimpleOperation.Multiplication(operand1, operand2)}",
            "+" => $"{operand1} {operation} {operand2} = {SimpleOperation.Addition(operand1, operand2)}",
            "" => throw new ArgumentException("operation can't be empty"),
            null => throw new ArgumentNullException("Operation can't be null"),
            _ => throw new ArgumentOutOfRangeException("Operation must be \"+\", \"/\" or \"*\"")
        };
    }
}
