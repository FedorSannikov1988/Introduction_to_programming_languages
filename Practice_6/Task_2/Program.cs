/*
Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/

const int AMOUNTSIDETRIANGLE = 3;

double InputDataInt(string message)
{
    Console.Write(message);
    bool isDigit = double.TryParse(Console.ReadLine(), out double numberDouble);
    if (isDigit)
    {
        return numberDouble;
    }
    throw new Exception("Введенные Вами символы невозможно преобразовать в переменную Double !");
}

bool ExaminationLong(double longTriangle)
{
    if (longTriangle < 0)
    {
        System.Console.WriteLine("Стороны треугольника меньше нуля существовать неможет");
        return false;
    }
    if (longTriangle == 0)
    {
        System.Console.WriteLine("Стороны треугольника равной нуля существовать неможет");
        return false;
    }
    return true;
}

double[] InputSideTriangle()
{
    double[] sideTriangle = new double[AMOUNTSIDETRIANGLE];

    double ByferForSideTriangle = 0;

    for (int i = 1; i <= sideTriangle.Length; i++)
    {
        ByferForSideTriangle = InputDataInt($"Введите длинну стороны треугольника № {i} в метрах: ");

        if (ExaminationLong(ByferForSideTriangle))
        {
            sideTriangle[i - 1] = ByferForSideTriangle;
        }
        else
        {
            break;
        }
    }
    return sideTriangle;
}

bool ExaminationExistenceTriangle(double[] sideTriangle)
{
    if (
        (sideTriangle[0] < (sideTriangle[1] + sideTriangle[2]))
        && (sideTriangle[1] < (sideTriangle[0] + sideTriangle[2]))
        && (sideTriangle[2] < (sideTriangle[1] + sideTriangle[0]))
    )
    {
        return true;
    }
    return false;
}

void AnswerExistenceTriangle(bool existenceTriangle)
{
    if (existenceTriangle)
    {
        System.Console.WriteLine("Треугольник с такими длиннами сторон существует");
    }
    else
    {
        System.Console.WriteLine("Треугольник с такими длиннами сторон не существует");
    }
}

//AnswerExistenceTriangle(ExaminationExistenceTriangle(InputSideTriangle()));

double[] SideTriangle = InputSideTriangle();

bool AnswerYESorNOT = ExaminationExistenceTriangle(SideTriangle);

AnswerExistenceTriangle(AnswerYESorNOT);

System.Console.Read();