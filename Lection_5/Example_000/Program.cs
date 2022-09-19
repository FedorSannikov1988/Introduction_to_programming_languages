/*
VAR !
*/

int a0 = 12;

Console.WriteLine(a0.GetType().Name);

var a1 = 12;

Console.WriteLine(a1.GetType().Name);

var a2 = 12.12;

Console.WriteLine(a2.GetType().Name);

var a3 = "12.12";

Console.WriteLine(a3.GetType().Name);

var a4 = 't';

Console.WriteLine(a4.GetType().Name);

double a5 = 1;
var a6 = a5;

Console.WriteLine(a6.GetType().Name);