/*
Пример использования функции(в С# это называется методом)
В общем я все это знал но пример хороший !
*/

//Функция поиска максимума (мне понравилось как её задали)
int MaX (int Arg1, int Arg2, int Arg3)
{
int maximym = Arg1; 
if (Arg2 > maximym) {maximym = Arg2;}
if (Arg3 > maximym) {maximym = Arg3;}
return maximym;
}

//---

int a1 = -1;
int b1 = 10;
int c1 = 19;

//---

int a2 = 465;
int b2 = 1001;
int c2 = 4332;

//---

int a3 = 1;
int b3 = 9633;
int c3 = 1;

//---

//System.Console.WriteLine($"Максимум {MaX(a1, b1, c1)}");
System.Console.WriteLine($"Максимум { MaX(MaX(a1, b1, c1), MaX(a2, b2, c2), MaX(a3, b3, c3)) }");