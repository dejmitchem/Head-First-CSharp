using LumberjackFlapjackApp;

Queue<Lumberjack> lumberjacks = new Queue<Lumberjack>();


while (true)
{
    Console.Write("Next lumberjack's name (blank to end:) ");
    string? name = Console.ReadLine();
    
    if (name == "") break;

    Console.Write("Number of flapjacks: ");
    string? inputFlapjacks = Console.ReadLine();

    if (int.TryParse(inputFlapjacks, out int numFlapjacks))
    {
        Lumberjack nextLumberJack = new Lumberjack(name);
        for (int i = 0; i < numFlapjacks; i++)
        {
            Flapjack flapjack = (Flapjack)Random.Shared.Next(0,4);
            nextLumberJack.TakeFlapjacks(flapjack);
        }
        lumberjacks.Enqueue(nextLumberJack);
    }
    else Console.WriteLine("Invalid value, try again");
}

for(int i = 0; i <= lumberjacks.Count(); i++)
{
    while (true)
    {
        if (!lumberjacks.Peek().EatFlapjacks()) break;
    }
    lumberjacks.Dequeue();
}

