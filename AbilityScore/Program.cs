/// <summary>
/// Simple console application to calculate an ability score from a starting
/// roll and configurable modifiers. The program repeatedly prompts the user
/// for inputs, computes the score and displays the result until the user
/// chooses to quit.
/// </summary>
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

/// <summary>
/// Prompt the user for a <see cref="double"/> value and parse the input.
/// If the input is not a valid double the provided <paramref name="defaultValue"/>
/// is returned.
/// </summary>
/// <param name="defaultValue">The value to return when parsing fails.</param>
/// <param name="prompt">The text displayed to the user when requesting input.</param>
/// <returns>The parsed double or <paramref name="defaultValue"/> if parsing fails.</returns>
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

/// <summary>
/// Prompt the user for an <see cref="int"/> value and parse the input.
/// If the input is not a valid integer the provided <paramref name="defaultValue"/>
/// is returned.
/// </summary>
/// <param name="defaultValue">The value to return when parsing fails.</param>
/// <param name="prompt">The text displayed to the user when requesting input.</param>
/// <returns>The parsed int or <paramref name="defaultValue"/> if parsing fails.</returns>
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
