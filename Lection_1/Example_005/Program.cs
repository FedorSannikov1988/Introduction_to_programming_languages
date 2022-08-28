Console.Write("Пожалуйста введите имя пользователя: ");

string UserName = Console.ReadLine() ?? "NOT NAME";

if (UserName.ToLower() == "федор")
{
    Console.WriteLine($"Я рад тебе {UserName}. Как же долго я тебя ждал !");
}
else
{
   Console.WriteLine($"Тебе чего надо {UserName} иди отсюда !");
}