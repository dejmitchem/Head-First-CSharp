namespace PickRandomCards;



internal class CardPicker
{
    public static string[] PickSomeCards(int numberOfCards)
    {


        string[] pickedCards = new string[numberOfCards];
        for (int i = 0; i < numberOfCards; i++)
        {
            pickedCards[i] = RandomValue() + " of " + RandomSuit();
        }
        return pickedCards;
    }

    private static string RandomSuit()
    {
        string[] suits = ["Hearts", "Diamonds", "Clubs", "Spades"];
        int value = Random.Shared.Next(0, 4);
        return suits[value];
    }

    private static string RandomValue()
    {
        int value = Random.Shared.Next(1, 14);
        if (value == 1) return "Ace";
        if (value == 11) return "Jack";
        if (value == 12) return "Queen";
        if (value == 13) return "King";
        return value.ToString();
    }
}
