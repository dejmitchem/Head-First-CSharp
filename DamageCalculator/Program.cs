using DamageCalculator;

DamageInterface();

void DamageInterface()
{
    SwordDamage longsword = new SwordDamage();


    while (true)
    {
        Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
        char input = Console.ReadKey(false).KeyChar;

        longsword.Roll = Random.Shared.Next(1, 7) + Random.Shared.Next(1, 7) + Random.Shared.Next(1, 7);

        if (input == '0')
            longsword.SetMagic(false);

        else if (input == '1')
            longsword.SetMagic(true);

        else if (input == '2')
        {
            longsword.SetMagic(false);
            longsword.SetFlaming(true);
        }
        else if (input == '3')
        {
            longsword.SetMagic(true);
            longsword.SetFlaming(true);
        }
        else
            return;

        Console.WriteLine($"\nRolled {longsword.Roll} for {longsword.Damage} HP.");


    }
}