/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

Console.WriteLine($"Введите размер трехмерного массива: ");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k: ");
int k = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[m, n, k];

CreateArray(array);
WriteArray(array);

void WriteArray (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      //Console.WriteLine($"m({i}) n({j}) ");
      for (int l = 0; l < array.GetLength(2); l++)
      {
        Console.Write($"m({i}) n({j}) ");
        Console.Write($"k({l}) = {array[i,j,l]}; \n");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
void CreateArray(int[,,] array)
{
  int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(1, 10);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(1, 10);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }

int count = 0; 
  for (int m = 0; m < array.GetLength(0); m++)
  {
    for (int n = 0; n < array.GetLength(1); n++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        array[m, n, k] = temp[count];
        count++;
      }
    }
  }
}
