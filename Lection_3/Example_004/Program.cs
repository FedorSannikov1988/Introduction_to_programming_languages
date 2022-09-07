/*
Сортируем массив чисел от меньшего к большему и наоборот !
*/

void PrintMass(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        System.Console.Write($"{massiv[i]} ");
    }

    System.Console.WriteLine();
}

void SortMassMinMaX(int[] massiv)
{
    for (int i = 0; i < massiv.Length - 1; i++)
    {
        int PozMinChisla = i;

        for (int j = i + 1; j < massiv.Length; j++)
        {
            if (massiv[j] < massiv[PozMinChisla])
            {
                PozMinChisla = j;
            }
        }

        int byfer = massiv[i];
        
        massiv[i] = massiv[PozMinChisla];

        massiv[PozMinChisla] = byfer;

    }
}

void SortMassMaXMiN(int[] massiv)
{
    for (int i = 0; i < massiv.Length - 1; i++)
    {
        int PozMaxChisla = i;

        for (int j = i + 1; j < massiv.Length; j++)
        {
            if (massiv[j] > massiv[PozMaxChisla])
            {
                PozMaxChisla = j;
            }
        }

        int byfer = massiv[i];
        
        massiv[i] = massiv[PozMaxChisla];

        massiv[PozMaxChisla] = byfer;

    }
}

int[] massiv = { 1, 2, 12, 6, 6, 9, 4, 7, 5 };

PrintMass(massiv);

SortMassMinMaX(massiv);

PrintMass(massiv);

SortMassMaXMiN(massiv);

PrintMass(massiv);