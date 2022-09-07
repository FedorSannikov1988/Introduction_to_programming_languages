/*
В тексте необходимо заменить одни символы на другие
работать со string можно
*/

string DataInput(string message)
{
    System.Console.WriteLine(message);
    return (Console.ReadLine() ?? "");
}

string Replacement(string Text, char OldSimvol, char NewSimvol)
{
    string ResultReplacement = String.Empty;

    for (int i = 0; i < Text.Length; i++)
    {
        if (Text[i] == OldSimvol)
        {
            ResultReplacement = ResultReplacement + $"{NewSimvol}";
        }
        //---
        else
        {
            ResultReplacement = ResultReplacement + $"{Text[i]}";
        }
    }
    return ResultReplacement;
}

//string Text = "данный текст проба пера";
string Text = DataInput("Введите текст в котором нужно осущесвить замену одного символа на другой:");

//string NewText = Replacement(Text, NewSimvol:'+', OldSimvol:' ');

string Text2 = DataInput("Введите один символ который нужно заменить (только один)");
char OldSimvol = Text2[0];

string Text3 = DataInput("Введите один символ на который нужно заменить (только один)");
char NewSimvol = Text3[0];

//обращение к char с помощью (' ') одинарных кавычек !
//char OldSimvol = ' ';
//char NewSimvol = '+';

string NewText = Replacement(Text, OldSimvol, NewSimvol);

System.Console.WriteLine("------");
System.Console.WriteLine(Text);
System.Console.WriteLine("------");
System.Console.WriteLine(NewText);