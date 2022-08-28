//Console.WriteLine("Пожалуйста введите Ваше имя ");
Console.Write("Пожалуйста введите Ваше имя ");

string UserName = Console.ReadLine() ?? "NOT NAME";

/* 
string User_Name = Console.ReadLine(); 
Почему без -> ?? "" 
Нравится читать ошибки - ?
*/

/*
Console.Write("Привет, ");
Console.Write(User_Name);
Console.Write(" !");
*/

Console.WriteLine($"Привет, {UserName } !");