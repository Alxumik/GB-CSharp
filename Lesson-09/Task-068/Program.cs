/*
Задача 68
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine("Вычисление функции Аккермана A(m,n)");
Console.Write("Введите неотрицательное число m: ");
string M = Console.ReadLine();
int m = System.Convert.ToInt32(M);
Console.Write("Введите неотрицательное число n: ");
string N = Console.ReadLine();
int n = System.Convert.ToInt32(N);

int A(int m, int n)
{
  if (m == 0) return (n + 1);
    else if (n == 0) return A(m - 1, 1);
        else return A(m - 1, A(m, n - 1));
}

Console.WriteLine($"Значение функции Аккермана = {A(m, n)}");