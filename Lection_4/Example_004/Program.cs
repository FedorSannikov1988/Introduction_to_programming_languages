int FactorialInt(int N)
{
    if (N == 1 || N == 0)
    {
        return 1;
    }
    else
    {
        return (N * FactorialInt(N - 1));
    }
}

double FactorialDouble(double N)
{
    if (N == 1 || N == 0)
    {
        return 1;
    }
    else
    {
        return (N * FactorialDouble(N - 1));
    }
}
/*
for (int i = 0; i < 40; i++)
{
    System.Console.WriteLine($"{i}! = {FactorialInt(N: i)}");
}
*/

for (int i = 0; i < 5; i++)
{
    System.Console.WriteLine($"{i}! = {FactorialDouble(N: i)}");
}