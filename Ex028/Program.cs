﻿/*Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> 1, 2, 3, 4, 5
M = 4; N = 8. -> 4, 6, 7, 8*/

Console.WriteLine($"Введите два числа: ");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

PrintInterval(m, n);
void PrintInterval(int m, int n)
{
  int start = m;
  int end = n;
  if(m > n)
  {
	  start = n;
	  end = m;
  }
  for(int i = start; i <= end; i++)
  {
	  Console.Write($"{i} ");
  }
}
Console.WriteLine();