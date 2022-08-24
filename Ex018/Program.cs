// Задача 41. Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write($"Введи число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] masNum = new int[m];
InNum(m);
void InNum(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    masNum[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int Comparison(int[] masNum)
{
  int count = 0;
  for (int i = 0; i < masNum.Length; i++)
  {
    if(masNum[i] > 0 ) count += 1; 
  }
  return count;
}
Console.WriteLine($"Введено чисел больше 0: {Comparison(masNum)} ");