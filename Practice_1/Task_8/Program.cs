/*
Вычислить число в последовательности Фибаначчи
*/

//Процедура ввода данных
int ZaPRoS(string message, int SposViVoD)
{
    if (SposViVoD == 0) {System.Console.Write(message);}
    if (SposViVoD == 1) {System.Console.WriteLine(message);}
    string strValue = Console.ReadLine() ?? "";
    //int Value = int.Parse(strValue);
    //коечто поинтереснее:
    bool isNumber = int.TryParse(strValue, out int Value);
    if (isNumber) {return Value;}
    throw new Exception ("Введенные символы невозможно преобразовать в целое число !");
    //если не используем одинадцатую строчку
    //return Value;
}

//Процедура вычисления числа Фибоначчи (положительного числа)
int Fibonahhi(int N)
{
    int F = 0;
    //Специально завел переменную/контейнек что бы сохранить введенное значение в переменной N
    int ByFFeR = N;
    int ZnaK = 1;
    //---
    if ( N < 0 && N%2 == 0 ) { ByFFeR = (-1) * ByFFeR; ZnaK = -1; }
    //
    if ( N < 0 && N%2 != 0 ) { ByFFeR = (-1) * ByFFeR; }
    //---
    if ( ByFFeR == 0 ) { F = 0; }
    //---
    if ( ByFFeR == 1 ) { F = 1; }
    //---
    if ( ByFFeR >= 2 ) 
    { 
        int Fn1 = 1;
        int Fn2 = 0;

        for ( int i = 1; i < ByFFeR; i++ )
        {
            F = Fn1 + Fn2;
            Fn2 = Fn1;
            Fn1 = F;
        }
    }
    return (F*ZnaK);
}

//Через переменные 

int ByFFeRvvod = ZaPRoS("Введити порядковый номер числа в ряду Фибоначчи: ", 0);

int ByFFeRvivod = Fibonahhi(ByFFeRvvod);

System.Console.WriteLine($"Число Фибоначчи с порядковым номером {ByFFeRvvod} равно {ByFFeRvivod}");

/*
//Напрямую через функции

//P.S.:Для вывода все равно лучше заводить переменные (иначе каряво получается)!

int ByFFeR = Fibonahhi( ZaPRoS("Введити порядковый номер числа в ряду Фибоначчи: ", 0) );

System.Console.WriteLine($"Число Фибоначчи равно {ByFFeR}");
*/