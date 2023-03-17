Console.Write("Введите число a: ");
string A = Console.ReadLine();
Console.Write("Введите число b: ");
string B = Console.ReadLine();
Console.Write("Введите число c: ");
string C = Console.ReadLine();

int a = System.Convert.ToInt32(A);
int b = System.Convert.ToInt32(B);
int c = System.Convert.ToInt32(C);
int max = a;

if(b > max) max = b;
if(c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);