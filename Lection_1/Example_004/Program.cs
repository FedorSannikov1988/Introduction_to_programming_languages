int NamberA = new Random().Next(1,10); //случайное целое число от 0 до 9
Console.WriteLine($"Первое число {NamberA}");

int NamberB = new Random().Next(1,10);
Console.WriteLine($"Первое число {NamberB}");

int Rezalt = NamberA + NamberB;
Console.WriteLine($"Результат вычисления (сложения двух чисел) {Rezalt}");