/*
Необходимо найти индекс элемента массива равного заданному числу
*/

int [] massiv = {1, 2, 3, 5, 12, 7, 8, 9, 10, 11, 12};

//Самое интересное лично для меня (функция определяющая размерность массива)
int sIzEmassiv = massiv.Length;

int chislo = 12;

int index = 0 ;

while (index < sIzEmassiv)
{
if ( massiv[index] == chislo ) 
{
System.Console.WriteLine($"Индекс массива {index} для искомого числа {massiv[index]}");

//Так же очень интересно ! Оператор прерывания (прерывания цикла и программы) !
break;
}
    index ++;
}