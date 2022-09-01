/*
Вычислить число в последовательности Фибаначчи
*/
/*
int i = 1;
int j = 1;
for (i = 1, Console.WriteLine($"Start: i={i}, j={j}"); i < 5; i++, j++, Console.WriteLine($"Step: i={i}, j={j}"))
{
    //...
}
*/

int i;
int j = 1;
for (i = 1, Console.WriteLine($"Start: i={i}, j={j}"); i < 1; i++, j=i*j, Console.WriteLine($"Step: i={i}, j={j}"))
{
    //...
}