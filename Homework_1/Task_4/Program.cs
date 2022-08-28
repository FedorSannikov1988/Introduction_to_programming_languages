/*
Задача 4: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
*/

//Блок (функция) запроса и ввода данных:
/*
Поскольку четные и нечетные числа принадлежат множеству целых чисел
(по крайней мере так говорит Google) вернул фунции ввода int
(использовал int.Parse ();)
*/
int DataVvod(string message)
{
System.Console.Write(message);
string strValue = Console.ReadLine() ?? ""; 
int Value = int.Parse (strValue);
return Value;
}

//Блок вывода сообщений пользователю
System.Console.WriteLine("Данная программа принимает одно число, а на выходе показывает все чётные числа от 1 до введенного числа.");
System.Console.WriteLine("Не вводите числа меньше 0 или 0 так так как они не соовевуют условию задачи");

//Ввод данных (переменных)
int Chiclo = DataVvod("Введите число: ");

//---

if ( Chiclo <= 0 )
{
    System.Console.WriteLine("Вы ввели число меньше 0 или 0");
    System.Console.WriteLine("Программа не будет выполнена !");
}

//---

if ( Chiclo == 1 ) 
{ 
    System.Console.WriteLine($"Вы ввели {Chiclo} это разрешено, но не имеет смысла так не будет выведено не одно число!");
}

//---

if ( Chiclo > 1 )
{
System.Console.WriteLine("Числа соотвевующие условию задачи:");

//Хочу использовать for для решения данной задачи
/*
int CounTer = 2;

while ( CounTer <= Chiclo )
{
    //System.Console.WriteLine(CounTer);
    System.Console.Write($" {CounTer} ");
    CounTer = CounTer + 2;
}
*/

//На мой взгляд более красивое решение
for (int i = 2; i <= Chiclo ; i=i+2)
{
   //System.Console.WriteLine(i);
   System.Console.Write($" {i} ");
}

}