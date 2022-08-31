//Метод (функция) заполнения массива случайными числами

//---

//Метод заполняющий массив случайными числами
void RandomMass(int[] mass)
{
    int LengthMass = mass.Length;
    int count = 0;

    while (count < LengthMass)
    {
        mass[count] = new Random().Next(1, 10);
        count++;
    }
}

//---

//Метод выводящий все элементы массива
void PrintMass(int[] mass)
{
    int LengthMass = mass.Length;
    int count = 0;
    while (count < LengthMass)
    {
        System.Console.WriteLine($"{mass[count]}");
        count++;
    }
}

//---

//Метод ищущий в массиве заданное число и возвращающий индекс данного числа
int FayndChisloMass(int[] mass, int chislo)
{
    int LengthMass = mass.Length;
    int count = 0;
    int IndexChisla = -1;
    while (count < LengthMass)
    {
        if (mass[count] == chislo)
        {
            IndexChisla = count;
            break;
        }
        count++;
    }
    return IndexChisla;
}

//Метод ввода данных (это мы сделали на практике)
int ZaPRoS(string message, int SposViVoD)
{
if ( SposViVoD == 0 ){ System.Console.Write(message); }
if ( SposViVoD == 1 ){ System.Console.WriteLine(message); }
string strValue = Console.ReadLine() ?? ""; 
int Value = int.Parse (strValue);
return Value;
}

//---

//задаем массив длинной в 10 элементов (естественно по умолчанию все элементы равны 0)
//консрукция задания размерности массива " = new int[10] "
int[] mass = new int[7];

//Используем написанные выше нами методы (или процедуры так как они нечего не возвращают)
//Заполняем массив случайными числами
RandomMass(mass);
//Выводим все элементы массива
PrintMass(mass);

int FayndChislo = ZaPRoS("Введите число которое будет искаться в массиве выведенном выше: ", 0);

if ( FayndChisloMass(mass, FayndChislo) < 0 )
{
    System.Console.WriteLine($"Число {FayndChislo} в массиве небыло найдено");
}
else
{
    System.Console.WriteLine($"Число {FayndChislo} в массиве имеет индекс {FayndChisloMass(mass, FayndChislo)}");
}