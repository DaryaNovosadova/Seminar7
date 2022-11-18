//Задача 51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0;0); (1;1) и т.д.)

Console.Write("Введите колличество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите колличество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
int[,] array = GetArray(rows, columns, 0, 10);
Console.WriteLine();
PrintArray(array);
int sum = SumDiag(array);
Console.WriteLine();
Console.WriteLine(SumDiag(array));

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumDiag(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j)
            {
                sum = sum +array[i,j];
            }
        }
    }
    return sum;
}