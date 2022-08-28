//блок задания переменных
int a = 36;
int b = 2;
int c = 96;
int d = 63;
int e = 11;

//блок присвоения максимума
int max = a;

//блок условия (топорно), но ведь работает :-)
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.WriteLine($"max = {max}");