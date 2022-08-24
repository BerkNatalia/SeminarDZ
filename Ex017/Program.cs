// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введи количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine()); 
double[] arrayNum = new double[n];
  for (int i = 0; i < arrayNum.Length; i++ )
  {
    arrayNum[i] = new Random().Next(1, 100);
    Console.Write(arrayNum[i] + " ");
  }

double max = arrayNum[0];
double min = arrayNum[0];

  for (int i = 1; i < arrayNum.Length; i++)
  {
    if (max < arrayNum[i])
    {
      max = arrayNum[i];
    }
        if (min > arrayNum[i])
    {
      min = arrayNum[i];
    }
  }
  double decision = max - min;
  Console.WriteLine($"\nРазница между максимальным и минимальным элементами: {decision}");