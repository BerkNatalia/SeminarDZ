// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введи количество элементов массива: ");
int n = int.Parse(Console.ReadLine()); 
int[] numbers = new int[n];

void MasArray(int[] array, int min, int max)
{
  for (int i = 0; i<array.Length; i++ )
  {
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array)
{
    for (int i = 0; i<array.Length; i++ )
    {
    Console.Write(array[i] + " ");
    }
  Console.WriteLine();
}

int Quantity(int[] array)
{
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ )
    {
      if (array[i] % 2 == 0)
      {
      quantity++;
      }
    }
  return quantity;
}

MasArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int quantity = Quantity(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");
