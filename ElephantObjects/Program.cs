using ElephantObjects;

Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };


while (true) {
    Console.WriteLine("Press 1 for Lloyd, 2 for Lucidna, 3 to swap");

    char key = Console.ReadKey(true).KeyChar;

    Console.WriteLine("You pressed " + key);

    if (key == '1')
        lloyd.WhoAmI();
    else if (key == '2')
        lucinda.WhoAmI();
    else if (key == '3')
        SwapRefernces();
    else
        Console.WriteLine("Invalid key" );

}


void SwapRefernces()
{
    Elephant holder = lloyd;
    lloyd = lucinda;
    lucinda = holder;
    Console.WriteLine("Refernces have been swapped");
}