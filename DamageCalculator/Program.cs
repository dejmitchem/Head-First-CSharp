using DamageCalculator;

DamageInterface();

void DamageInterface()
{
    SwordDamage longsword = new SwordDamage(RollDice());


    while (true)
    {
        Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
        char input = Console.ReadKey(false).KeyChar;

        longsword.Roll = Random.Shared.Next(1, 7) + Random.Shared.Next(1, 7) + Random.Shared.Next(1, 7);

        if (input == '0')
        {
            longsword.Magic = false;
            longsword.Flaming = false;
        }
        else if (input == '1')
            longsword.Magic = true;

        else if (input == '2')
        {
            longsword.Magic = false;
            longsword.Flaming = true;
        }
        else if (input == '3')
        {
            longsword.Magic = true;
            longsword.Flaming = true;
        }
        else
            return;

        Console.WriteLine($"\nRolled {longsword.Roll} for {longsword.Damage} HP.");


    }
}

int RollDice()
{
    return Random.Shared.Next(1, 7) + Random.Shared.Next(1, 7) + Random.Shared.Next(1, 7);
}