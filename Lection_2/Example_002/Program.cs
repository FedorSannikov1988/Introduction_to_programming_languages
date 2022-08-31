/*
Работа с массивами !
*/

int MaX (int Arg1, int Arg2, int Arg3)
{
int maximym = Arg1; 
if (Arg2 > maximym) {maximym = Arg2;}
if (Arg3 > maximym) {maximym = Arg3;}
return maximym;
}

//Задаем переменные через массив 

//Работа с массивом int
//Уже использовали на практике !
int[] MaSSiV1 = {1, 2, 3, 4, 5, 6, 7, 8, 9};
MaSSiV1[0] = 12;
System.Console.WriteLine($"{MaSSiV1[0]}");