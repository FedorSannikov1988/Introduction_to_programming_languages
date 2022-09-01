/*
Программа для вычисления факториала введенного числа
Примечание: решение через функцию/процедуру
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

/*
//Процедура вычисления факториала #1
int Fact(int Chislo)
{
int FactChislo = -1;
    if (Chislo >= 0)
{  
   FactChislo = 1;
   for (int i = 1; i <= Chislo; i++)
   {FactChislo = FactChislo * i;}
}
    return FactChislo;
}
*/

//Процедура вычисления факториала #2
//Более изящно !
int FactPr2(int Chislo)
{
int j = 1;
for (int i=1; i<Chislo; i++, j=j*i)
{/*Тело цикла нам не нужно*/}
return j;
}

int Byfer1 = ZaPRoS("Введите число факториал которого нужно найти: ", 0);

//int Byfer2 = Fact(Byfer1);
int Byfer2 = FactPr2(Byfer1);

if (Byfer1>=0) {System.Console.WriteLine($"Факториал числа {Byfer1} равен {Byfer2}");}
else {System.Console.WriteLine("Факториал числа меньше 0 не сущесвует !");}

//Прикольная конструкция !
/*

int i;
int j = 1;
for (i = 1, Console.WriteLine($"Start: i={i}, j={j}"); i < 1; i++, j=i*j, Console.WriteLine($"Step: i={i}, j={j}"))
{
    //...
}

*/