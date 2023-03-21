/*
Задача 66
Задайте значение N.
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Write("Введите натуральное число N: ");
string N = Console.ReadLine();
double n = System.Convert.ToDouble(N);

void PrintNumber(double n)
{
    if(n == 0) return;
    Console.WriteLine(n);
    PrintNumber(--n);
}

PrintNumber(n);

/*
// Решение с циклом, без рекурсии.
while(n > 0) Console.WriteLine(n--);
*/