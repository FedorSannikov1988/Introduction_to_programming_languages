/*
Напишите программу, которая генерирует последовательность
случайных чисел из 10 элементов в диапазоне от 1 до 10, и
подсчитывает, сколько сгенерировалось чисел больше 5.
*/

//Решаем через функции и массивы !

int DataInput(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[] GenerationMassRand(int dimension)
{
    double[] MassRand = new double[dimension];

    for (int i = 0; i < dimension; i++)
    {
        MassRand[i] = new Random().Next(0, 10) + new Random().NextDouble();
    }
    return MassRand;
}

double[] Comparison(double[] MassChisel, double ChisloForСompare)
{
    double[] MassChiselaMore = new double[MassChisel.Length];

    int j = 0;

    for (int i = 0; i < MassChisel.Length; i++)
    {
        if (MassChisel[i] >= ChisloForСompare)
        {
            MassChiselaMore[j] = MassChisel[i];
            j++;
        }
    }
    return MassChiselaMore;
}