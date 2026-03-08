using CardClass;

Card myCard = new Card((Suits)Random.Shared.Next(4), (Values)Random.Shared.Next(1, 14));
Console.WriteLine(myCard.Name);