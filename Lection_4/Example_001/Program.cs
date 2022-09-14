/*
работа с матрицей string !
*/
void PrintStringTable(string[,] table)
{
    for (int line = 0; line < table.GetLength(0); line++)
    {
        for (int column = 0; column < table.GetLength(1); column++)
        {
            System.Console.Write($" -{table[line, column]}- ");
        }

        System.Console.WriteLine();
    }
}

string[,] table = new string[2, 5];

table[1, 2] = "*";

PrintStringTable(table);