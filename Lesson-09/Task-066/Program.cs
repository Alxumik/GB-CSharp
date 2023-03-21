/*
Задача 66
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите натуральное число M: ");
string M = Console.ReadLine();
double m = System.Convert.ToDouble(M);
Console.Write("Введите натуральное число N (N >= M): ");
string N = Console.ReadLine();
double n = System.Convert.ToDouble(N);

if(n < m){
    Console.WriteLine("Некорректный ввод.");
    return;
}

double Sum = 0;
for(double i = m; i <= n; i++) Sum += i;

Console.Write("Сумма натуральных элементов в промежутке от M до N = ");
Console.WriteLine(Sum);