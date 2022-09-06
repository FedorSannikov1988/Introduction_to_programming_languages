/*
Напишите программу для разворота слова (стринговой строки).
*/

string DataInput(string message)
{
    System.Console.Write(message);
    return (Console.ReadLine() ?? "0");
}

string InputDataVisMessage()
{
    string simvol = DataInput("Введите слово/симовлы для его/их разворота (отзеркаливания): ");
    return simvol;
}

char[] PerevertachString(string word)
{
    char[] newWord = new char[word.Length];

    for (int i = 0; i < word.Length; i++)
    {
        newWord[i] = word[word.Length - (i + 1)];
    }
    return newWord;
}

string Word = InputDataVisMessage();

System.Console.WriteLine("**********************");
System.Console.WriteLine(Word);
System.Console.WriteLine("**********************");
//char и string необходимо записыват в виде приведенном ниже 
System.Console.WriteLine(PerevertachString(Word));
System.Console.WriteLine("**********************");