/*Задача 69: Напишите программу, которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

Console.WriteLine($"Введите два числа: ");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

int exponentiation = Exponentiation(m, n);
Console.WriteLine("Ответ: " + exponentiation);

int Exponentiation(int m, int n)
{
  int result = 1;
  for(int i=1; i <= n; i++)
  {
    result = result * m;
  }
    return result;
}

Console.WriteLine();
