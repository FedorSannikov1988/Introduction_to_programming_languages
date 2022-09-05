/*
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateCoords(int NamberChetvert)
{
    if (NamberChetvert>= 1 && NamberChetvert <= 4)
    {
        return true;
    }

    System.Console.WriteLine("Четверти имеют номера с 1-ой по 4-ую");
    return false;
}

void DeterminateQuarter(int NamberChetvert)
{
      if (NamberChetvert == 1)
    {
        System.Console.WriteLine("x > 0 && y > 0");
    }
    if (NamberChetvert == 2)
    {
        System.Console.WriteLine("x < 0 && y > 0");
    }
    if (NamberChetvert == 3)
    {
        System.Console.WriteLine("x < 0 && y < 0");
    }
    if (NamberChetvert == 4)
    {
        System.Console.WriteLine("x > 0 && y < 0");
    }  
}

int NamberChetvert = Prompt("Введите номер четверти: ");
`
if (ValidateCoords(NamberChetvert))
{
    DeterminateQuarter(NamberChetvert);
}