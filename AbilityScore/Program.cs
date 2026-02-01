using AbilityScore;

AbilityScoreCalculator calculator = new AbilityScoreCalculator();

while (true)
{
    calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
    calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
    calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
    calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
    calculator.CalculateAbilityScore();
    Console.WriteLine("Calculated ability score: " + calculator.Score);
    Console.WriteLine("Press Q to quit, any other key to continue");
    char keyChar = Console.ReadKey(true).KeyChar;
    if (keyChar == 'q' || keyChar == 'Q') return;
}

double ReadDouble(double defaultValue, string prompt)
{
    Console.Write(prompt + " [" + defaultValue + "] ");
    string? input = Console.ReadLine();
    if (double.TryParse(input, out double value))
    {
        Console.WriteLine(" using value " + value);
        return value;
    }
    else
    {
        Console.WriteLine(" using default value " + defaultValue);
        return defaultValue;
    }
}

int ReadInt(int defaultValue, string prompt)
{
    Console.Write(prompt + " [" + defaultValue + "] ");
    string? input = Console.ReadLine();
    if (int.TryParse(input, out int value))
    {
        Console.WriteLine(" using value " + value);
        return value;
    }
    else
    {
        Console.WriteLine(" using default value " + defaultValue);
        return defaultValue;
    }
}