int number = new Random().Next(10,100);
int i = number;
int tmp = i%10;
int max = 0;

while ( i > 0 )
{
if( tmp > max )
{
max = tmp;
}

i = i/10;

tmp = i%10;
}

System.Console.WriteLine(number);

System.Console.WriteLine(max);