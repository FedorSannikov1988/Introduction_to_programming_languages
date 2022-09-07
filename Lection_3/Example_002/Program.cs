//Второй тип
void Rectangle(int X, int Y, string Simvol)
{
    for (int i = 1; i <= Y; i++)
    {
        for (int j = 1; j <= X; j++)
        {
            System.Console.Write($"{Simvol}");
        }
        System.Console.WriteLine();
    }
}

Rectangle(Simvol:"+",Y:25, X:30);