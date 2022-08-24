// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введи количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine()); 
int RanNum(int number, int min, int max)
{
  int[] ranNum = new int[number];
  int sum = 0;
  Console.Write("Получившийся массив: ");
    for (int i = 0; i <ranNum.Length; i++ )
    {
      ranNum[i] = new Random().Next(min, max);
      Console.Write(ranNum[i] + " ");
      if (i % 2 != 0)
      {
        sum = sum + ranNum[i];
      }
    }
  return sum;
}

int ranNum =  RanNum(number, 1, 100);
Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {ranNum}");