/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.WriteLine($"Введите размер двух матриц: ");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите l: ");
int l = Convert.ToInt32(Console.ReadLine());

int[,] firstarray = new int[m, n];
CreateArray(firstarray);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstarray);

int[,] secomdarray = new int[k, l];
CreateArray(secomdarray);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secomdarray);

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,10);
    }
  }
}
void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

int[,] resultMatrix = new int[m,l];

ProizMatrix(firstarray, secomdarray, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);

void ProizMatrix(int[,] firstarray, int[,] secomdarray, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int z = 0; z < firstarray.GetLength(1); z++)
      {
        sum += firstarray[i,z] * secomdarray[z,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}