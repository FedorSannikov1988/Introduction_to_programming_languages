using System.Linq;

string text = "(1,2) (2,3) (3,4) (4,5)".Replace("(", "").Replace(")", "");

System.Console.WriteLine(text);
System.Console.WriteLine();

var data = text.Split(" ")
    .Select(item => item.Split(',')) //- ?
    .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
    .Where(e => e.x % 2 == 0)
    .Select(point => (point.x * 1, point.y * 1))
    .ToArray();

/*
for (int i = 0; i < data.Length; i++)
{
    for (int k = 0; k < data[i].Length; k++)
    {
        System.Console.WriteLine(data[i][k]);
    }
    System.Console.WriteLine();
}
*/

for (int i = 0; i < data.Length; i++)
{
    System.Console.WriteLine(data[i]);
}