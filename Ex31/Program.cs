/*Задача 69: Напишите программу, которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

Console.WriteLine($"Введите два числа: ");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Power(m, n);
Console.WriteLine("Ответ: " + Power(m, n));

int Power(int m, int n)
{
    if(n == 1) return m;
    if(n < 0) return Power( 1 / m, -n);
        return m * Power(m, n - 1);
    return Power(m * m, n / 2);
}

 Console.WriteLine();
