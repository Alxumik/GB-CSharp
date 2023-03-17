Console.Write("Введите трёхначное число: ");
string N = Console.ReadLine();
int n = System.Convert.ToInt32(N);

int res2 = n / 10;
int dig2 = res2 % 10;
Console.WriteLine(dig2);