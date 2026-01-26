OperatorExamples();
TryAnIf();
TrySomeLoops();
TryAnIfElse();

void TryAnIf()
{
    int someValue = 4;
    string name = "Bobby Jr.";
    if(someValue == 3 && name == "Joe")
    {
        Console.WriteLine("x is three and the name is Joe.");
    }
    Console.WriteLine("this line runs no matter what");
}

void TryAnIfElse()
{
    int x = 5;
    if (x == 10)
    {
        Console.WriteLine("x must be 10");
    }
    else
    {
        Console.WriteLine("x isn't 10");
    }

}

void TrySomeLoops()
{
    int count = 0;

    while(count < 10)
    {
        count++;
    }

    for(int i = 0; i < 5; i++)
    {
        count--;
    }

    Console.WriteLine("The answer is " + count);
}

void OperatorExamples()
{
    int width = 3;

    width++;

    int height = 2 + 4;
    int area = width * height;
    Console.WriteLine(area);

    while (area < 20)
    {
        height++;
        area = width * height;
    }

    do
    {
        width--;
        area = width * height;

    } while (area > 25);

    string result = "The area ";
    result = result + "is " + area;
    Console.WriteLine(result);

    bool trueValue = true;
    Console.WriteLine(trueValue);
}