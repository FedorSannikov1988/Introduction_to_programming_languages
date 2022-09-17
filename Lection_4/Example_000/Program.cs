double Proba1(double N)
{
    if (N == 0)
    {
        return 1;
    }
    System.Console.WriteLine($"{N}");
    System.Console.WriteLine("#");
    return (Proba1(N - 1));
}

double Proba2(double N)
{
    if (N == 0)
    {
        return 0;
    }
    System.Console.WriteLine($"{N}");
    System.Console.WriteLine("*");
    return (Proba2(N - 2));
}

double Proba3(double N)
{
    if (N == 1)
    {
        System.Console.WriteLine($"{N}");
        return 1;
    }
    System.Console.WriteLine($"{N}");
    System.Console.WriteLine("+");
    return (Proba3(N - 1));
}

System.Console.WriteLine("----");
Proba1(N:5);
System.Console.WriteLine("----");
Proba2(N:10);
System.Console.WriteLine("----");
Proba3(N:2);
System.Console.WriteLine("----");