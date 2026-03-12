using CardClass;


List<Card> cards = new List<Card>();


Console.Write("How many cards would you like to draw? ");
if (int.TryParse(Console.ReadLine(), out int numberOfCards)) 
{ 
     for (int i = 0; i < numberOfCards; i++)
            cards.Add(RandomCard());
}
else
    Console.WriteLine("Invalid input, try again.");


CardComparerByValue comparer = new CardComparerByValue();
cards.Sort(comparer);
PrintCards(cards);




static Card RandomCard()
{
    return new Card((Suits)Random.Shared.Next(0, 4), (Values)Random.Shared.Next(1,14));
}   

static void PrintCards(List<Card> cards)
{
    foreach (Card card in cards)
        Console.WriteLine(card.Name);
}