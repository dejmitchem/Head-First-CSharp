using IsStatementPractice;

Animal[] animals = 
{
    new Wolf(false),
    new Hippo(),
    new Wolf(true),
    new Wolf(false),
    new Hippo()
};

foreach (Animal animal in animals)
{
    animal.MakeNoise();
    if (animal is IPackHunter packHunter)
    {
        packHunter.HuntInPack();
    }
    if (animal is ISwimmer swimmer)
    {
        swimmer.Swim();
    }
    Console.WriteLine();
}