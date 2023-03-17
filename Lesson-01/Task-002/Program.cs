Console.Write("Введите число a: ");
string A = Console.ReadLine();
Console.Write("Введите число b: ");
string B = Console.ReadLine();
int a = System.Convert.ToInt32(A);
int b = System.Convert.ToInt32(B);

Console.Write("max = ");
if(a > b) Console.WriteLine(a);
else Console.WriteLine(b);