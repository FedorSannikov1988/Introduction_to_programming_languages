/*
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int FunctionAckerman(int m, int n)
{
    if (m == 0)
    {
        return (n + 1);
    }

    if ((m > 0) && (n == 0))
    {
        return (FunctionAckerman(m - 1, 1));
    }
    
    return (FunctionAckerman(m - 1, FunctionAckerman(m, n - 1)));
}

bool ExaminationMandNforFunctionAckerman(int m, int n)
{
    if ((m < 0) || (n < 0))
    {
        System.Console.WriteLine("Введенные значения m и/или n функции Аккермана не соответствуют условию задачи");
        return false;
    }
    return true;
}

int InputDataInt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int numberInt);
    if (isDigit)
    {
        return numberInt;
    }
    throw new Exception("Введенные Вами символы невозможно преобразовать в переменную Int32 !");
}

System.Console.WriteLine("Данная программа вычисляет функцию Аккермана по средством рекурсии");

int M = InputDataInt("Введите m для функции Аккермана: ");

int N = InputDataInt("Введите n для функции Аккермана: ");

if (ExaminationMandNforFunctionAckerman(M, N))
{
    int VariableAckerman = FunctionAckerman(M, N);
      
    System.Console.WriteLine($"Значение функции Аккермана {VariableAckerman} для m = {M} равна n = {N}");
}

System.Console.Read();