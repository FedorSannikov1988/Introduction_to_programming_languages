/*
Напишите программу, которая выводит случайное трёхзначное число и 
удаляет вторую цифру этого числа. Не использовать строки для расчета.
456 -> 46
782 -> 72
918 -> 98
*/

int FaynChislo(int chislo, int namber)
{

int byffer = chislo;

int[] massbyffer = new int[3];

for ( int i = 2; i >= 0; i-- )
{
    massbyffer[i] = byffer%10;
    byffer = byffer/10;
}

int flag = massbyffer[(namber-1)];

return flag;

}

int RanChislo = new Random().Next(100, 1000);  

System.Console.WriteLine("Данная программа выводит случайное трёхзначное число и удаляет вторую цифру этого числа.");

System.Console.WriteLine($"Случайное трехзначное число: {RanChislo}");

int OtveT = (FaynChislo(RanChislo, 1)*10) + FaynChislo(RanChislo, 3) ;

System.Console.WriteLine($"Случайное число из которого вынули второе по счету цифру: {OtveT}");