int MyMethod(bool add3)
{
    int value = 12;

    if (add3)
        value += 3;
    else 
        value -= 2;

    return value;
}

MyMethod(true);

