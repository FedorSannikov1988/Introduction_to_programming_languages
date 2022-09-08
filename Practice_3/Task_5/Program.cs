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

    double[] MassChiselaMoreItog = new double[j];

    for (int i = 0; i < j; i++)
    {
        MassChiselaMoreItog[i] = MassChiselaMore[i];
    }

    return MassChiselaMoreItog;
}

void PrintMassiv(double[] Massiv)
{
    for (int i = 0; i < Massiv.Length; i++)
    {
        System.Console.Write($"{Massiv[i]:f3} ");
    }
}

bool ChekDimensionArrayRandom(int Dimension)
{
    if (Dimension <= 0)
    {
        System.Console.WriteLine(
            "Размерность массива случайных чисел не может быть равна 0 или меньше 0"
        );
        return false;
    }
    return true;
}

bool ChekDimensionNamber(int Namber)
{
    if (Namber < 0)
    {
        System.Console.WriteLine(
            "Число с которым сравниваем элементы массива не может быть меньше 0 так как массив состоит из положительных чисел и 0"
        );
        return false;
    }
    return true;
}

//Начало программы (тело ):

int NamberRandom = DataInput(
    "Введите размерность массива из случайных чисел который будет сгенерирован: "
);

double[] RandomArray;

if (ChekDimensionArrayRandom(Dimension: NamberRandom))
{
    RandomArray = GenerationMassRand(dimension: NamberRandom);

    PrintMassiv(Massiv: RandomArray);
}
else
{
    System.Console.WriteLine("Размерность массива случайных чисел теперь будет равна 1");

    RandomArray = GenerationMassRand(dimension: 1);
}

//---

System.Console.WriteLine();

int comparison = DataInput(
    "Введите число с которым необходимо сравнивать каждый из элементов массива: "
);

//---

if (ChekDimensionNamber(comparison))
{
    double[] ChisloMore = Comparison(MassChisel: RandomArray, ChisloForСompare: comparison);

    System.Console.WriteLine("Массив состоящий из чисел которые больше введенного числа:");

    PrintMassiv(Massiv: ChisloMore);
}
else
{
    System.Console.WriteLine("Элементы массива случайных чисел будут сравниваться с числом 1");

    double[] ChisloMore = Comparison(MassChisel: RandomArray, ChisloForСompare: 1);

    System.Console.WriteLine("Массив состоящий из чисел которые больше 1-ого:");

    PrintMassiv(Massiv: ChisloMore);
}