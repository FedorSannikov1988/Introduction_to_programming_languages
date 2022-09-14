int FibonacciInt(int N)
{
    if (N == 1 || N == 2)
    {
        return 1;
    }
    else
    {
        return (FibonacciInt(N - 1) + FibonacciInt(N - 2));
    }
}

double FibonacciDouble(double N)
{
    if (N == 1 || N == 0)
    {
        return 1;
    }
    else
    {
        return (FibonacciDouble(N - 1) + FibonacciDouble(N - 2));
    }
}

/*
for (int i = 1; i <= 40; i++)
{
    System.Console.WriteLine($"f({i}) = {FibonacciInt(N: i)}");
}
*/

for (int i = 1; i <= 40; i++)
{
    System.Console.WriteLine($"f({i}) = {FibonacciDouble(N: i)}");
}