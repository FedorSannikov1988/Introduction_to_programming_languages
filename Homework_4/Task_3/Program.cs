/*
Напишите программу, которая выводит массив 
из 8 элементов, заполненный случайными числами.
Оформите заполнение массива и вывод в виде функции 
(пригодится в следующих задачах).
*/

double[] CreateRandomArray(int Dimension, int MinRandom, int MaxRandom)
{
   double[] array = new double[Dimension];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(MinRandom, MaxRandom) + new Random().NextDouble();
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:f1}\t");
    }
    System.Console.WriteLine();
}

int InputNamber(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool ExaminationNamber(int Chislo)
{
    if (Chislo == 0)
    {
        System.Console.WriteLine("Размерность генерируемого массива случайных чисел не может быть равна нулю");
        return false;
    }

    if (Chislo < 0)
    {
        System.Console.WriteLine("Размерность генерируемого массива случайных чисел не может быть меньше нуля");
        return false;
    }

    return true;

}

int Razmernost = InputNamber("Введите размерность генерируемого массива состоящего из случайных чисел: ");

if (ExaminationNamber(Chislo:Razmernost))
{
    /*
    Можно так же довольно легко организовать ввод с клавиатуры MinRandom и MaxRandom
    но думаю что это лишнее в том числе потому что нехочу писать проверку на их валидность :-)
    что бы пользователь нечего не накосячил (не ввел всякой ерунды)
    */
    
    PrintArray(CreateRandomArray(Dimension:Razmernost, MinRandom: -1000, MaxRandom: 1000));
}

System.Console.Read();