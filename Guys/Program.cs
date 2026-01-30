using Guys;

Guy Joe = new Guy() { Name = "Joe", Cash = 50 };
Guy Bob = new Guy() { Name = "Bob", Cash = 100 };

while (true)
{
    Joe.WriteMyInfo();
    Bob.WriteMyInfo();

    Console.Write("Enter an amount: ");
    string? howMuch = Console.ReadLine();
    if (howMuch == "") return;

    if (int.TryParse(howMuch, out int howMuchInt))
    {
        Console.Write("Who should give the cash: ");
        string? whichGuy = Console.ReadLine();
        if (whichGuy == "Joe")
        {
            int cashGiven = Joe.GiveCash(howMuchInt);
            Bob.ReceiveCash(cashGiven);
        }
        else if (whichGuy == "Bob")
        {
            int cashGiven = Bob.GiveCash(howMuchInt);
            Joe.ReceiveCash(cashGiven);
        }
        else
        {
            Console.WriteLine("Invalid guy.");
        }

    }
    else
    {
        Console.WriteLine("Please enter an amount (or a blank line to exit)");
    }
}

