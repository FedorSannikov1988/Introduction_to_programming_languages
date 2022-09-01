/*
Задача 2: Напишите программу, которая принимает
на вход три числа и выдаёт максимальное из этих чисел.
*/

//Процедура ввода данных
int ZaPRoS(string message, int SposViVoD)
{
    if (SposViVoD == 0)
    {System.Console.Write(message);}
    if (SposViVoD == 1)
    {System.Console.WriteLine(message);}
    string strValue = Console.ReadLine() ?? "";
    int Value = int.Parse(strValue);
    return Value;
}

//Процедура вывода данных (очередной эксперимент)
//Цикл вывода данных (можно превратить в процедуру) !
void ViVoD (int[] MaХ, int j)
{
for (int i = 0; i < j; i++) 
{System.Console.WriteLine($"Максимальное число №{i+1} равно {MaХ[i]}");}
}

//Создали массив для трех чисел
int[] TriChicla = new int[3];

//Запрашиваем три числа
for (int i = 0; i < 3; i++) 
{TriChicla[i] = ZaPRoS($"Введите число №{i+1}: ", 0);}

//Ищем максимум из 3-х чисел
int[] MaХ = new int[3];

int MaХByFF = TriChicla[0];

int j = 0;

for (int i = 0; i < 3; i++) 
{
   if (MaХByFF <= TriChicla[i]) 
    {
    MaХByFF = TriChicla[i]; 
    MaХ[j] = TriChicla[i];
    j++;
    }
}

/*
//Цикл вывода данных (можно превратить в процедуру) !
for (int i = 0; i < j; i++) 
{System.Console.WriteLine($"Максимальное число №{i+1} равно {MaХ[i]}");}
*/

ViVoD(MaХ,j);