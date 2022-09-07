//Методы 4-ре условных типа

//Метод №1 (нечего не возвоащают и не принимают)

void Method1()
{
    System.Console.WriteLine("К примеру вывод текстового сообщения");
}

//Method1();

//Метод №2 (нечего не возвоащают но принимают значение)
void Method2(string message)
{
    System.Console.WriteLine(message);
}

//можно так:
//Method2("Сообщение №1");

//System.Console.WriteLine("");

//тогда зачем так
//Method2(message: "Сообщение №2");

void Method2p1(string message, int count)
{
    for (int i = 0; i < count; i++)
    {
        System.Console.WriteLine(message);
    }
}

//можно так:
//Method2p1("Сообщение №3", 5);

//System.Console.WriteLine("***");

//а можно так:
//Method2p1(count:5, message:"Сообщение №4");

//System.Console.WriteLine("***");

//или так:
//Method2p1(message:"Сообщение №4", count:5);

//---

//нечего не принимает но возвращает
int Method3()
{
    return DateTime.Now.Year;
}

//или

int Method3p1()
{
    return DateTime.Now.Hour;
}

//System.Console.WriteLine(Method3());
//System.Console.WriteLine("***");
//System.Console.WriteLine(Method3p1());

//---

string Method4(string message, int count)
{
    //полезная штука
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + message;
    }
    return result;
}

System.Console.WriteLine(Method4(count:10, message:"o"));
System.Console.WriteLine(Method4(count:10, message:"у"));
System.Console.WriteLine(Method4(count:10, message:"э"));