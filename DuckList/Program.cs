using DuckList;

List<Duck> ducks = [
    new Duck(17, KindOfDuck.Mallard),
    new Duck(18, KindOfDuck.Muscovy),
    new Duck(14, KindOfDuck.Loon),
    new Duck(11, KindOfDuck.Muscovy),
    new Duck(14, KindOfDuck.Mallard),
    new Duck(13, KindOfDuck.Loon)
    ];

ducks.Sort();
PrintDucks(ducks);

void PrintDucks(List<Duck> ducks)
{
    foreach (var duck in ducks)
    {
        Console.WriteLine($"{duck.Size} inch {duck.Kind}");
    }
}