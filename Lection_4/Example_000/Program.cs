double Proba1(double N)
{
    if (N == 0)
    {
        return 1;
    }
    System.Console.WriteLine("+");
    return (Proba1(N - 1));
}

double Proba2(double N)
{
    if (N == 0)
    {
        return 0;
    }
    //System.Console.WriteLine($"{N}");
    System.Console.WriteLine("*");
    return (Proba2(N - 2));
}

//Proba1(N: 5);

Proba2(N:10);