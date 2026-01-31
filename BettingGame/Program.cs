using Guys;

double odds = 0.75;
Guy player = new Guy() { Name = "The Player", Cash = 100 };

Console.WriteLine("Welcome to the casino. The odds are: " + odds);
while (player.Cash > 0)
{
    player.WriteMyInfo();

    Console.Write("How much do you want to bet: ");
    string? howMuch = Console.ReadLine();


    if (int.TryParse(howMuch, out int amount))
    {
        int pot = player.GiveCash(amount);
        if (pot > 0)
        {
            pot *= 2;
            if (Random.Shared.NextDouble() > odds)
            {
                player.ReceiveCash(pot);
                Console.WriteLine("You win " + pot + " bucks!");
            }
            else
            {
                Console.WriteLine("Bad luck, you lose");
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid number.");
    }
}

Console.WriteLine("The house always wins.");